using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;

namespace File_Transfare_Over_Network
{
    public partial class Wait : UserControl
    {
        public static Wait _instance;
        public static Wait Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Wait();
                return _instance;
            }
        }
        public new MainForm ParentForm { get; set; }
        private int s, ms;
        public Wait()
        {
            InitializeComponent();
            s = 0;
            ms = 0;
        }
        private void Stopbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Receive.Instance.listener.Stop();
                Receive.Instance.Scanlistener.Stop();
                Receive.Instance.Scan_backgroundWorker.CancelAsync();
                Receive.Instance.Run_backgroundWorker.CancelAsync();
            }
            catch (Exception ex) { }
            Receive.Instance.BringToFront();
        }

        private void Waitting_Label_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(Waitting_Label.Text, "Waitting For Connection ..."))
                return;
            Receive.Instance.listener.Stop();
            Receive.Instance.Scanlistener.Stop();
            //if(Receive.Instance.Scan_backgroundWorker.IsBusy)
            //    Receive.Instance.Scan_backgroundWorker.CancelAsync();
            //if (Receive.Instance.Run_backgroundWorker.IsBusy)
            //    Receive.Instance.Run_backgroundWorker.CancelAsync();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (s == 3)
            {
                timer.Stop();
                if (this.ParentForm == null)
                    return;
                MainForm MainForm = (this.ParentForm as MainForm);
                if (!MainForm.panel.Controls.Contains(Receiving.Instance))
                {

                    MainForm.panel.Controls.Add(Receiving.Instance);
                    Receiving.Instance.Dock = DockStyle.Fill;
                    Receiving.Instance.BringToFront();
                    Receiving.Instance.ParentForm = this.ParentForm;

                }
                else Receiving.Instance.BringToFront();
                Waitting_Label.Text = "Waitting For Connection ...";
                s = 0;
                ms = 0;
                Receiving.Instance.Receive_backgroundWorker.RunWorkerAsync();
                return;
            }
            ms++;
            if (ms > 10)
            {
                s++;
                ms = 0;
            }
        }
    }
}
