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
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace File_Transfare_Over_Network
{
    public partial class Receive : UserControl
    {
        public static Receive _instance;
        public static Receive Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Receive();
                return _instance;
            }
        }

        private Thread tcphandlerThread;
        private Thread sendipThread;
        public new MainForm ParentForm { get; set; }
        private IPAddress MyIPAddress;
        public IPAddress ClientIPAddress;
        public TcpListener listener;
        public TcpListener Scanlistener;
        public string FileName;
        public int FileSize;
        private static int ScanPort = 6815;
        private static int ConnectionPort = 6816;

        public Receive()
        {
            InitializeComponent();
            listener = new TcpListener(IPAddress.Any, ConnectionPort);
            Scanlistener = new TcpListener(IPAddress.Any, ScanPort);
        }


        private void Browsebutton_Click(object sender, EventArgs e)
        {

            FolderBrowser fb = new FolderBrowser();
            fb.Description = "Please select a file or folder below:";
            fb.IncludeFiles = true;
            fb.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                Path_textBox.Text = fb.SelectedPath;
                fb.InitialDirectory = fb.SelectedPath;

            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Start.Instance.BringToFront();
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
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                {
                    if (nic.Description == Interface_comboBox.SelectedItem.ToString())
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            MyIPAddress = ip.Address;
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(Path_textBox.Text) || !(Interface_comboBox.SelectedIndex > -1))
            {
                Startbutton.Enabled = false;
            }
            else
                Startbutton.Enabled = true;
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm == null)
                return;
            MainForm MainForm = (this.ParentForm as MainForm);
            if (!MainForm.panel.Controls.Contains(Wait.Instance))
            {
                MainForm.panel.Controls.Add(Wait.Instance);
                Wait.Instance.Dock = DockStyle.Fill;
                Wait.Instance.BringToFront();
                Wait.Instance.ParentForm = this.ParentForm;
            }
            else Wait.Instance.BringToFront();
            Scan_backgroundWorker.RunWorkerAsync();
            Run_backgroundWorker.RunWorkerAsync();
        }

        private void Scan()
        {
            Scanlistener.Start();
            while (!Scan_backgroundWorker.CancellationPending)
            {
                try
                {
                    TcpClient Server = Scanlistener.AcceptTcpClient();
                    sendipThread = new Thread(new ParameterizedThreadStart(sendip));
                    sendipThread.Start(Server);
                }
                catch (Exception e) { break; }
            }
        }

        private void sendip(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            Byte[] sendBytes = Encoding.UTF8.GetBytes(MyIPAddress.ToString());
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Close();
        }

        private void Run()
        {
            listener.Start();
            while (!Run_backgroundWorker.CancellationPending)
            {
                try
                {
                    TcpClient Server = listener.AcceptTcpClient();
                    tcphandlerThread = new Thread(new ParameterizedThreadStart(tcphandler));
                    tcphandlerThread.Start(Server);
                }
                catch (Exception e) { break; }
            }
        }

        private void tcphandler(object mclient)
        {
            TcpClient client = (TcpClient)mclient;
            NetworkStream stream = client.GetStream();
            // Reads NetworkStream into a byte buffer.
            byte[] bytes = new byte[client.ReceiveBufferSize];

            // Read can return anything from 0 to numBytesToRead. 
            // This method blocks until at least one byte is read.
            stream.Read(bytes, 0, (int)client.ReceiveBufferSize);

            // Returns the data received from the host to the console.
            string returndata = Encoding.UTF8.GetString(bytes);

            returndata = returndata.Replace("\0", String.Empty);
            List<string> str = returndata.Split('*').ToList<string>();
            ClientIPAddress = IPAddress.Parse(str.ElementAt(0));
            FileName = str.ElementAt(1);
            FileSize = int.Parse(str.ElementAt(2));
            IPHostEntry entry = Dns.GetHostEntry(ClientIPAddress);
            Func<int> start = delegate ()
            {
                Wait.Instance.Waitting_Label.Text = "   Connected To " + entry.HostName;
                return 0;
            };
            Invoke(start);
        }

        private void Path_textBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Path_textBox.Text) || !(Interface_comboBox.SelectedIndex > -1))
            {
                Startbutton.Enabled = false;
            }
            else
                Startbutton.Enabled = true;
        }

        private void Scan_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Scan();
        }

        private void Run_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Run();
        }
    }
}
