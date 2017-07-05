namespace File_Transfare_Over_Network
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Title_Label = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.CloseToTry_button = new System.Windows.Forms.Button();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.ForeColor = System.Drawing.Color.Tomato;
            this.Title_Label.Location = new System.Drawing.Point(12, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(365, 29);
            this.Title_Label.TabIndex = 2;
            this.Title_Label.Text = "File Transfare Over Network";
            this.Title_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Title_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Title_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "File Transfare is Still opend";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(476, 247);
            this.panel.TabIndex = 8;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // CloseToTry_button
            // 
            this.CloseToTry_button.BackColor = System.Drawing.Color.Transparent;
            this.CloseToTry_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseToTry_button.BackgroundImage")));
            this.CloseToTry_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseToTry_button.CausesValidation = false;
            this.CloseToTry_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseToTry_button.FlatAppearance.BorderSize = 0;
            this.CloseToTry_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseToTry_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseToTry_button.Location = new System.Drawing.Point(414, 0);
            this.CloseToTry_button.Name = "CloseToTry_button";
            this.CloseToTry_button.Size = new System.Drawing.Size(25, 25);
            this.CloseToTry_button.TabIndex = 7;
            this.CloseToTry_button.UseVisualStyleBackColor = false;
            this.CloseToTry_button.Click += new System.EventHandler(this.CloseToTry_button_Click);
            // 
            // Minimize_button
            // 
            this.Minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize_button.BackgroundImage")));
            this.Minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize_button.CausesValidation = false;
            this.Minimize_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minimize_button.FlatAppearance.BorderSize = 0;
            this.Minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_button.Location = new System.Drawing.Point(445, 0);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(25, 25);
            this.Minimize_button.TabIndex = 6;
            this.Minimize_button.UseVisualStyleBackColor = false;
            this.Minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.Transparent;
            this.Close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close_button.BackgroundImage")));
            this.Close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_button.CausesValidation = false;
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(476, 0);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(25, 25);
            this.Close_button.TabIndex = 5;
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.CloseToTry_button);
            this.Controls.Add(this.Minimize_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Title_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.Text = "File Transfare Over Network";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.Button CloseToTry_button;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.Panel panel;
    }
}

