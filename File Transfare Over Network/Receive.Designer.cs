namespace File_Transfare_Over_Network
{
    partial class Receive
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
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Interface_comboBox = new System.Windows.Forms.ComboBox();
            this.Interface_label = new System.Windows.Forms.Label();
            this.Save_Location_Label = new System.Windows.Forms.Label();
            this.Path_textBox = new System.Windows.Forms.TextBox();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Scan_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Run_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.Location = new System.Drawing.Point(377, 108);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(75, 31);
            this.Refreshbutton.TabIndex = 11;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Interface_comboBox
            // 
            this.Interface_comboBox.FormattingEnabled = true;
            this.Interface_comboBox.Location = new System.Drawing.Point(87, 114);
            this.Interface_comboBox.Name = "Interface_comboBox";
            this.Interface_comboBox.Size = new System.Drawing.Size(284, 21);
            this.Interface_comboBox.TabIndex = 10;
            this.Interface_comboBox.SelectedIndexChanged += new System.EventHandler(this.Interface_comboBox_SelectedIndexChanged);
            // 
            // Interface_label
            // 
            this.Interface_label.AutoSize = true;
            this.Interface_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interface_label.Location = new System.Drawing.Point(15, 116);
            this.Interface_label.Name = "Interface_label";
            this.Interface_label.Size = new System.Drawing.Size(71, 19);
            this.Interface_label.TabIndex = 9;
            this.Interface_label.Text = "Interface";
            // 
            // Save_Location_Label
            // 
            this.Save_Location_Label.AutoSize = true;
            this.Save_Location_Label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Location_Label.Location = new System.Drawing.Point(3, 62);
            this.Save_Location_Label.Name = "Save_Location_Label";
            this.Save_Location_Label.Size = new System.Drawing.Size(83, 14);
            this.Save_Location_Label.TabIndex = 8;
            this.Save_Location_Label.Text = "Save Location";
            // 
            // Path_textBox
            // 
            this.Path_textBox.Location = new System.Drawing.Point(87, 56);
            this.Path_textBox.Name = "Path_textBox";
            this.Path_textBox.Size = new System.Drawing.Size(284, 20);
            this.Path_textBox.TabIndex = 7;
            this.Path_textBox.Text = "C:\\";
            this.Path_textBox.TextChanged += new System.EventHandler(this.Path_textBox_TextChanged);
            // 
            // Browsebutton
            // 
            this.Browsebutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebutton.Location = new System.Drawing.Point(377, 49);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(75, 31);
            this.Browsebutton.TabIndex = 6;
            this.Browsebutton.Text = "Browse";
            this.Browsebutton.UseVisualStyleBackColor = true;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Enabled = false;
            this.Startbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbutton.Location = new System.Drawing.Point(198, 213);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 31);
            this.Startbutton.TabIndex = 14;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(24, 213);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 31);
            this.Backbutton.TabIndex = 13;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Scan_backgroundWorker
            // 
            this.Scan_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Scan_backgroundWorker_DoWork);
            // 
            // Run_backgroundWorker
            // 
            this.Run_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Run_backgroundWorker_DoWork);
            // 
            // Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Interface_comboBox);
            this.Controls.Add(this.Interface_label);
            this.Controls.Add(this.Save_Location_Label);
            this.Controls.Add(this.Path_textBox);
            this.Controls.Add(this.Browsebutton);
            this.Name = "Receive";
            this.Size = new System.Drawing.Size(476, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.ComboBox Interface_comboBox;
        private System.Windows.Forms.Label Interface_label;
        private System.Windows.Forms.Label Save_Location_Label;
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Backbutton;
        public System.ComponentModel.BackgroundWorker Run_backgroundWorker;
        public System.ComponentModel.BackgroundWorker Scan_backgroundWorker;
        public System.Windows.Forms.TextBox Path_textBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
