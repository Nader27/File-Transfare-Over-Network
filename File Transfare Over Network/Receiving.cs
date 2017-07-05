using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace File_Transfare_Over_Network
{
    public partial class Receiving : UserControl
    {
        public static Receiving _instance;
        public static Receiving Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Receiving();
                return _instance;
            }
        }
        private Int32 ReceivePort = 1418;
        private Int32 CancelPort = 2468;
        public new MainForm ParentForm { get; set; }
        public Receiving()
        {
            InitializeComponent();
        }

        public void ReceiveData()
        {
            TcpListener Listener = null;
            try
            {
                Listener = new TcpListener(IPAddress.Any, ReceivePort);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            while(true)
            {
                try
                {
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        byte[] RecData = new byte[client.SendBufferSize];
                        int RecBytes;

                        Invoke((MethodInvoker)delegate
                        {
                            Status.Text = "Status : Receiving...";
                            progressBar1.Maximum = Receive.Instance.FileSize/1024;
                        });
                        int totalrecbytes = 0;
                        FileStream Fs = new FileStream(Receive.Instance.Path_textBox.Text + "//" + Path.GetFileName(Receive.Instance.FileName), FileMode.OpenOrCreate, FileAccess.Write);
                        while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                        {
                            Fs.Write(RecData, 0, RecBytes);
                            totalrecbytes += RecBytes;
                            Invoke((MethodInvoker)delegate
                            {
                                progressBar1.Value = totalrecbytes / 1024;
                                if (!(progressBar1.Value >= progressBar1.Maximum))
                                {
                                    Present_label.Text = (int)((float)((float)progressBar1.Value / (float)(progressBar1.Maximum)) * 100) + "%";
                                }
                            });
                        }
                        Fs.Close();
                        Invoke((MethodInvoker)delegate
                        {
                            Status.Text = "Status : Complete";
                            progressBar1.Value = progressBar1.Maximum;
                            Cancelbutton.Text = "Finish";
                        });
                        netstream.Close();
                        client.Close();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        Status.Text = "Status : " + ex.Message;
                    });
                    //netstream.Close();
                }
            }
        }

        private TcpClient client;
        private NetworkStream netstream;

        private void Receive_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ReceiveData();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            TcpClient Canceler = new TcpClient(Receive.Instance.ClientIPAddress.ToString(), CancelPort);
            if (Canceler.Connected)
                Canceler.Close();
            
            Status.Text = "Status : Canceled";
        }
    }
}
