using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Transfare_Over_Network
{
    public partial class Start : UserControl
    {
        public static Start _instance;
        public static Start Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Start();
                return _instance;
            }
        }
        public Start()
        {
            InitializeComponent();
        }
        public new MainForm ParentForm { get; set; }
        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm == null)
                return;
            MainForm MainForm = (this.ParentForm as MainForm);
            if (!MainForm.panel.Controls.Contains(Send.Instance))
            {
                MainForm.panel.Controls.Add(Send.Instance);
                Send.Instance.Dock = DockStyle.Fill;
                Send.Instance.BringToFront();
                Send.Instance.ParentForm = this.ParentForm;
            }
            else Send.Instance.BringToFront();
        }

        private void Receivebutton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm == null)
                return;
            MainForm MainForm = (this.ParentForm as MainForm);
            if (!MainForm.panel.Controls.Contains(Receive.Instance))
            {
                MainForm.panel.Controls.Add(Receive.Instance);
                Receive.Instance.Dock = DockStyle.Fill;
                Receive.Instance.BringToFront();
                Receive.Instance.ParentForm = this.ParentForm;
            }
            else Receive.Instance.BringToFront();
        }

    }
}
