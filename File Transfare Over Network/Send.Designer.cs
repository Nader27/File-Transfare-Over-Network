namespace File_Transfare_Over_Network
{
    partial class Send
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Browsebutton = new System.Windows.Forms.Button();
            this.Path_textBox = new System.Windows.Forms.TextBox();
            this.Path_Label = new System.Windows.Forms.Label();
            this.Interface_Label = new System.Windows.Forms.Label();
            this.Interface_comboBox = new System.Windows.Forms.ComboBox();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Scanbutton = new System.Windows.Forms.Button();
            this.Receiver_comboBox = new System.Windows.Forms.ComboBox();
            this.Receiver_Label = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Present_label = new System.Windows.Forms.Label();
            this.UTP_Label = new System.Windows.Forms.Label();
            this.GZip_Label = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Gzip_Switch = new System.Windows.Forms.Button();
            this.UTP_Switch = new System.Windows.Forms.Button();
            this.Scan_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Start_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Send_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Browsebutton
            // 
            this.Browsebutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebutton.Location = new System.Drawing.Point(385, 5);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(75, 31);
            this.Browsebutton.TabIndex = 0;
            this.Browsebutton.Text = "Browse";
            this.Browsebutton.UseVisualStyleBackColor = true;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // Path_textBox
            // 
            this.Path_textBox.Location = new System.Drawing.Point(95, 10);
            this.Path_textBox.Name = "Path_textBox";
            this.Path_textBox.Size = new System.Drawing.Size(284, 20);
            this.Path_textBox.TabIndex = 1;
            this.Path_textBox.TextChanged += new System.EventHandler(this.Path_textBox_TextChanged);
            // 
            // Path_Label
            // 
            this.Path_Label.AutoSize = true;
            this.Path_Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path_Label.Location = new System.Drawing.Point(20, 10);
            this.Path_Label.Name = "Path_Label";
            this.Path_Label.Size = new System.Drawing.Size(40, 19);
            this.Path_Label.TabIndex = 2;
            this.Path_Label.Text = "Path";
            // 
            // Interface_Label
            // 
            this.Interface_Label.AutoSize = true;
            this.Interface_Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interface_Label.Location = new System.Drawing.Point(20, 50);
            this.Interface_Label.Name = "Interface_Label";
            this.Interface_Label.Size = new System.Drawing.Size(71, 19);
            this.Interface_Label.TabIndex = 3;
            this.Interface_Label.Text = "Interface";
            // 
            // Interface_comboBox
            // 
            this.Interface_comboBox.FormattingEnabled = true;
            this.Interface_comboBox.Location = new System.Drawing.Point(95, 50);
            this.Interface_comboBox.Name = "Interface_comboBox";
            this.Interface_comboBox.Size = new System.Drawing.Size(284, 21);
            this.Interface_comboBox.TabIndex = 4;
            this.Interface_comboBox.SelectedIndexChanged += new System.EventHandler(this.Interface_comboBox_SelectedIndexChanged);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.Location = new System.Drawing.Point(385, 45);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(75, 31);
            this.Refreshbutton.TabIndex = 5;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Scanbutton
            // 
            this.Scanbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanbutton.Location = new System.Drawing.Point(385, 85);
            this.Scanbutton.Name = "Scanbutton";
            this.Scanbutton.Size = new System.Drawing.Size(75, 31);
            this.Scanbutton.TabIndex = 8;
            this.Scanbutton.Text = "Scan";
            this.Scanbutton.UseVisualStyleBackColor = true;
            this.Scanbutton.Click += new System.EventHandler(this.Scanbutton_Click);
            // 
            // Receiver_comboBox
            // 
            this.Receiver_comboBox.FormattingEnabled = true;
            this.Receiver_comboBox.Location = new System.Drawing.Point(95, 90);
            this.Receiver_comboBox.Name = "Receiver_comboBox";
            this.Receiver_comboBox.Size = new System.Drawing.Size(284, 21);
            this.Receiver_comboBox.TabIndex = 7;
            this.Receiver_comboBox.SelectedIndexChanged += new System.EventHandler(this.Receiver_comboBox_SelectedIndexChanged);
            // 
            // Receiver_Label
            // 
            this.Receiver_Label.AutoSize = true;
            this.Receiver_Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver_Label.Location = new System.Drawing.Point(20, 90);
            this.Receiver_Label.Name = "Receiver_Label";
            this.Receiver_Label.Size = new System.Drawing.Size(68, 19);
            this.Receiver_Label.TabIndex = 6;
            this.Receiver_Label.Text = "Receiver";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(24, 163);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(380, 23);
            this.progressBar.TabIndex = 9;
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(24, 213);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 31);
            this.Backbutton.TabIndex = 10;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Enabled = false;
            this.Startbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbutton.Location = new System.Drawing.Point(198, 213);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 31);
            this.Startbutton.TabIndex = 11;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Enabled = false;
            this.Cancelbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.Location = new System.Drawing.Point(385, 213);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 31);
            this.Cancelbutton.TabIndex = 12;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Present_label
            // 
            this.Present_label.AutoSize = true;
            this.Present_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Present_label.Location = new System.Drawing.Point(410, 163);
            this.Present_label.Name = "Present_label";
            this.Present_label.Size = new System.Drawing.Size(34, 19);
            this.Present_label.TabIndex = 13;
            this.Present_label.Text = "0%";
            // 
            // UTP_Label
            // 
            this.UTP_Label.AutoSize = true;
            this.UTP_Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTP_Label.Location = new System.Drawing.Point(20, 130);
            this.UTP_Label.Name = "UTP_Label";
            this.UTP_Label.Size = new System.Drawing.Size(39, 19);
            this.UTP_Label.TabIndex = 14;
            this.UTP_Label.Text = "UTP";
            // 
            // GZip_Label
            // 
            this.GZip_Label.AutoSize = true;
            this.GZip_Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GZip_Label.Location = new System.Drawing.Point(220, 130);
            this.GZip_Label.Name = "GZip_Label";
            this.GZip_Label.Size = new System.Drawing.Size(42, 19);
            this.GZip_Label.TabIndex = 15;
            this.GZip_Label.Text = "GZip";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(24, 189);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(45, 13);
            this.Status.TabIndex = 18;
            this.Status.Text = "Status :";
            // 
            // Gzip_Switch
            // 
            this.Gzip_Switch.BackColor = System.Drawing.Color.Transparent;
            this.Gzip_Switch.BackgroundImage = global::File_Transfare_Over_Network.Properties.Resources.off;
            this.Gzip_Switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gzip_Switch.CausesValidation = false;
            this.Gzip_Switch.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gzip_Switch.FlatAppearance.BorderSize = 0;
            this.Gzip_Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gzip_Switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gzip_Switch.Location = new System.Drawing.Point(300, 125);
            this.Gzip_Switch.Name = "Gzip_Switch";
            this.Gzip_Switch.Size = new System.Drawing.Size(70, 32);
            this.Gzip_Switch.TabIndex = 17;
            this.Gzip_Switch.UseVisualStyleBackColor = false;
            this.Gzip_Switch.Click += new System.EventHandler(this.Gzip_Switch_Click);
            // 
            // UTP_Switch
            // 
            this.UTP_Switch.BackColor = System.Drawing.Color.Transparent;
            this.UTP_Switch.BackgroundImage = global::File_Transfare_Over_Network.Properties.Resources.on;
            this.UTP_Switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UTP_Switch.CausesValidation = false;
            this.UTP_Switch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UTP_Switch.FlatAppearance.BorderSize = 0;
            this.UTP_Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UTP_Switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTP_Switch.Location = new System.Drawing.Point(95, 125);
            this.UTP_Switch.Name = "UTP_Switch";
            this.UTP_Switch.Size = new System.Drawing.Size(70, 32);
            this.UTP_Switch.TabIndex = 16;
            this.UTP_Switch.UseVisualStyleBackColor = false;
            this.UTP_Switch.Click += new System.EventHandler(this.UTP_Switch_Click);
            // 
            // Scan_backgroundWorker
            // 
            this.Scan_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Scan_backgroundWorker_DoWork);
            // 
            // Send_backgroundWorker
            // 
            this.Send_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Send_backgroundWorker_DoWork);
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Gzip_Switch);
            this.Controls.Add(this.UTP_Switch);
            this.Controls.Add(this.GZip_Label);
            this.Controls.Add(this.UTP_Label);
            this.Controls.Add(this.Present_label);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Scanbutton);
            this.Controls.Add(this.Receiver_comboBox);
            this.Controls.Add(this.Receiver_Label);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Interface_comboBox);
            this.Controls.Add(this.Interface_Label);
            this.Controls.Add(this.Path_Label);
            this.Controls.Add(this.Path_textBox);
            this.Controls.Add(this.Browsebutton);
            this.Name = "Send";
            this.Size = new System.Drawing.Size(476, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.TextBox Path_textBox;
        private System.Windows.Forms.Label Path_Label;
        private System.Windows.Forms.Label Interface_Label;
        private System.Windows.Forms.ComboBox Interface_comboBox;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.Button Scanbutton;
        private System.Windows.Forms.ComboBox Receiver_comboBox;
        private System.Windows.Forms.Label Receiver_Label;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label Present_label;
        private System.Windows.Forms.Label UTP_Label;
        private System.Windows.Forms.Label GZip_Label;
        private System.Windows.Forms.Button UTP_Switch;
        private System.Windows.Forms.Button Gzip_Switch;
        private System.Windows.Forms.Label Status;
        private System.ComponentModel.BackgroundWorker Scan_backgroundWorker;
        private System.ComponentModel.BackgroundWorker Start_backgroundWorker;
        private System.ComponentModel.BackgroundWorker Send_backgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
