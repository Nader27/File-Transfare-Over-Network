using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.DirectoryServices;
using System.IO.Compression;
using System.Threading;

namespace File_Transfare_Over_Network
{
    public partial class Send : UserControl
    {
        public static Send _instance;
        public static Send Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Send();
                return _instance;
            }
        }

        private bool UTP;
        private bool GZIP;

        public new MainForm ParentForm { get; set; }

        private TcpClient EstablishConnection;
        private TcpClient SendConnection;
        private IPEndPoint localEndPoint;
        private NetworkInterface NetworkInterface;
        public IPAddress ClientIP;
        private List<IPAddress> AllClients;
        private byte[] SendingBuffer;

        private static Int32 ScanPort = 6815;
        private static Int32 ConnectionPort = 6816;
        private static Int32 SendPort = 1418;
        private FileStream Fs;
        NetworkStream netstream;

        public Send()
        {
            InitializeComponent();
            UTP = true;
            GZIP = false;
            AllClients = new List<IPAddress>();
            EstablishConnection = new TcpClient();
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Path_textBox.Text = openFileDialog.FileName;
                openFileDialog.InitialDirectory = openFileDialog.FileName;
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            Interface_comboBox.Items.Clear();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet) || (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)) && (nic.OperationalStatus == OperationalStatus.Up))
                {
                    Interface_comboBox.Items.Add(nic.Description);
                }
            }
        }

        private void Interface_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Path_textBox.Text) || !(Interface_comboBox.SelectedIndex > -1) || !(Receiver_comboBox.SelectedIndex > -1))
            {
                Startbutton.Enabled = false;
            }
            else
                Startbutton.Enabled = true;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                {
                    if (nic.Description == Interface_comboBox.SelectedItem.ToString())
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            localEndPoint = new IPEndPoint(ip.Address, port: 0);
                            NetworkInterface = nic;
                        }
                    }
                }
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Start.Instance.BringToFront();
        }

        private void UTP_Switch_Click(object sender, EventArgs e)
        {
            if (UTP)
            {
                UTP_Switch.BackgroundImage = Properties.Resources.off;
                UTP = false;
            }
            else
            {
                UTP_Switch.BackgroundImage = Properties.Resources.on;
                UTP = true;
            }
        }

        private void Gzip_Switch_Click(object sender, EventArgs e)
        {
            if (GZIP)
            {
                Gzip_Switch.BackgroundImage = Properties.Resources.off;
                GZIP = false;
            }
            else
            {
                Gzip_Switch.BackgroundImage = Properties.Resources.on;
                GZIP = true;
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Startbutton.Enabled = false;
            Cancelbutton.Enabled = true;
            Backbutton.Enabled = false;
            Path_textBox.Enabled = false;
            Interface_comboBox.Enabled = false;
            Receiver_comboBox.Enabled = false;
            UTP_Switch.Enabled = false;
            if (UTP)
                UTP_Switch.BackgroundImage = Properties.Resources.on_disapled;
            else
                UTP_Switch.BackgroundImage = Properties.Resources.off_disapled;
            Gzip_Switch.Enabled = false;
            if (GZIP)
                Gzip_Switch.BackgroundImage = Properties.Resources.on_disapled;
            else
                Gzip_Switch.BackgroundImage = Properties.Resources.off_disapled;
            Status.Text = "Status : Establishing Connection To " + ClientIP.ToString();
            try
            {
                TcpClient Runclient = new TcpClient(ClientIP.ToString(), ConnectionPort);
                FileStream ff = new FileStream(Path_textBox.Text, FileMode.Open,FileAccess.Read);
                
                byte[] data = Encoding.ASCII.GetBytes(localEndPoint.Address.ToString()+"*"+ ff.Name+"*"+(int)ff.Length);
                NetworkStream stream = Runclient.GetStream();
                stream.Write(data, 0, data.Length);
                Runclient.Close();
                stream.Close();
            }
            catch (Exception ex)
            {
                Status.Text = "Status : Client " + ClientIP.ToString() + " Not Found or Disconnected";
            }
            Send_backgroundWorker.RunWorkerAsync();

        }

        private void Scanbutton_Click(object sender, EventArgs e)
        {
            Receiver_comboBox.Items.Clear();
            AllClients.Clear();
            Scan_backgroundWorker.RunWorkerAsync();
        }

        private void Scan_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int wantedPort = 6815;
            DirectoryEntry root = new DirectoryEntry("WinNT:");
            foreach (DirectoryEntry computers in root.Children)
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    if (computer.Name != "Schema")
                    {
                        IPHostEntry ipEntry = Dns.GetHostByName(computer.Name);
                        IPAddress[] addr = ipEntry.AddressList;
                        foreach (IPAddress ipCandidate in addr)
                        {
                            try
                            {
                                //try to connect
                                sock.Connect(ipCandidate, wantedPort);
                                if (sock.Connected == true)  // if succesful => something is listening on this port
                                {
                                    // Reads NetworkStream into a byte buffer.
                                    byte[] bytes = new byte[sock.ReceiveBufferSize];
                                    sock.Receive(bytes);

                                    // Returns the data received from the host
                                    string returndata = Encoding.UTF8.GetString(bytes);
                                    returndata = returndata.Replace("\0", String.Empty);

                                    sock.Close();

                                    IPAddress IP = IPAddress.Parse(returndata);
                                    IPHostEntry entry = Dns.GetHostEntry(IP);
                                    Func<int> start = delegate ()
                                    {
                                        Receiver_comboBox.Items.Add(entry.HostName + " ( " + returndata + " )");
                                        AllClients.Add(IP);
                                        return 0;
                                    };
                                    Invoke(start);
                                }
                                //else -. goes to exception
                            }
                            catch (SocketException ex)
                            {
                                //TODO: if you want, do smth here
                                //Console.WriteLine("\tDIDN'T work at " + ipCandidate);
                            }
                        }
                    }
                }
            }
        }

        private void Path_textBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Path_textBox.Text) || !(Interface_comboBox.SelectedIndex > -1) || !(Receiver_comboBox.SelectedIndex > -1))
            {
                Startbutton.Enabled = false;
            }
            else
                Startbutton.Enabled = true;
        }

        private void Receiver_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Path_textBox.Text) || !(Interface_comboBox.SelectedIndex > -1) || !(Receiver_comboBox.SelectedIndex > -1))
            {
                Startbutton.Enabled = false;
            }
            else
                Startbutton.Enabled = true;
            ClientIP = AllClients.ElementAt(Receiver_comboBox.SelectedIndex);
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Startbutton.Enabled = true;
            Cancelbutton.Enabled = false;
            Backbutton.Enabled = true;
            Path_textBox.Enabled = true;
            Interface_comboBox.Enabled = true;
            Receiver_comboBox.Enabled = true;
            UTP_Switch.Enabled = true;
            if (UTP)
                UTP_Switch.BackgroundImage = Properties.Resources.on;
            else
                UTP_Switch.BackgroundImage = Properties.Resources.off;
            Gzip_Switch.Enabled = false;
            if (GZIP)
                Gzip_Switch.BackgroundImage = Properties.Resources.on;
            else
                Gzip_Switch.BackgroundImage = Properties.Resources.off;
            Status.Text = "Status : Canceled";
            if (EstablishConnection.Connected)
                EstablishConnection.Close();
        }

        private void ProcessDirectory(string Path)
        {
            if (File.Exists(Path))
            {
                // This path is a file
                SendFile(Path);
            }
            else foreach (string path in Directory.GetFiles(Path))
                {
                    if (File.Exists(path))
                    {
                        // This path is a file
                        SendFile(path);
                    }
                    else if (Directory.Exists(path))
                    {
                        // This path is a directory
                        ProcessDirectory(path);
                    }
                }

        }

        private void SendFile(string path)
        {
            Status.Invoke((MethodInvoker)delegate { Status.Text = "Status : Connected to the Server..."; });
            Fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            int NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(SendConnection.SendBufferSize)));
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Maximum = NoOfPackets;
            });
            int TotalLength = (int)Fs.Length, CurrentPacketLength;
            Status.Invoke((MethodInvoker)delegate
            {
                Status.Text = "Status : Sending...";
            });
            for (int i = 0; i < NoOfPackets; i++)
            {
                if (TotalLength > SendConnection.SendBufferSize)
                {
                    CurrentPacketLength = SendConnection.SendBufferSize;
                    TotalLength = TotalLength - CurrentPacketLength;
                }
                else
                    CurrentPacketLength = TotalLength;
                SendingBuffer = new byte[CurrentPacketLength];
                Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                int present = (int)(((float)i / (float)NoOfPackets) * 100);
                Invoke((MethodInvoker)delegate
                {
                    Present_label.Text = present + "%";
                    progressBar.Value = i;
                });
            }
            Status.Invoke((MethodInvoker)delegate
            {
                Status.Text = "Status : File Sent Successfully";
                progressBar.Value = progressBar.Maximum;
                Present_label.Text = "100 %";
            });
        }

        private void Send_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            again:
            try
            {
                SendConnection = new TcpClient(ClientIP.ToString(), SendPort);
                netstream = SendConnection.GetStream();
            }
            catch (Exception ex)
            {
                Func<int> start = delegate ()
                {
                    Status.Text = "Status : " + ClientIP.ToString() + " has Refused Connection";
                    Thread.Sleep(3000);
                    Status.Text = "Status : Retrying To Connect ..";
                    Thread.Sleep(5000);
                    return 0;
                };
                Invoke(start);
                goto again;
            }
            ProcessDirectory(Path_textBox.Text);
            netstream.Close();
            SendConnection.Close();
        }

    }
}
