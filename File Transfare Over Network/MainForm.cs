using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Transfare_Over_Network
{
    public partial class MainForm : Form
    {

        private bool dragging;
        private Point dragging_start_point;
        private Start Start;
        public MainForm()
        {
            InitializeComponent();
            dragging_start_point = new Point(0, 0);
            Start = Start.Instance;
            Start.ParentForm = this;
            panel.Controls.Add(Start);
            Start.Instance.Dock = DockStyle.Fill;
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.dragging_start_point.X, p.Y - this.dragging_start_point.Y);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragging_start_point = new Point(e.X, e.Y);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseToTry_button_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            this.Hide();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
        }
    }
}
