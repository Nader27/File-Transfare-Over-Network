namespace File_Transfare_Over_Network
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Receive_Label = new System.Windows.Forms.Label();
            this.Send_Label = new System.Windows.Forms.Label();
            this.Receivebutton = new System.Windows.Forms.Button();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Receive_Label
            // 
            this.Receive_Label.AutoSize = true;
            this.Receive_Label.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receive_Label.Location = new System.Drawing.Point(312, 32);
            this.Receive_Label.Name = "Receive_Label";
            this.Receive_Label.Size = new System.Drawing.Size(106, 30);
            this.Receive_Label.TabIndex = 15;
            this.Receive_Label.Text = "Receive";
            // 
            // Send_Label
            // 
            this.Send_Label.AutoSize = true;
            this.Send_Label.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Label.Location = new System.Drawing.Point(74, 32);
            this.Send_Label.Name = "Send_Label";
            this.Send_Label.Size = new System.Drawing.Size(70, 30);
            this.Send_Label.TabIndex = 14;
            this.Send_Label.Text = "Send";
            // 
            // Receivebutton
            // 
            this.Receivebutton.Image = ((System.Drawing.Image)(resources.GetObject("Receivebutton.Image")));
            this.Receivebutton.Location = new System.Drawing.Point(288, 65);
            this.Receivebutton.Name = "Receivebutton";
            this.Receivebutton.Size = new System.Drawing.Size(150, 150);
            this.Receivebutton.TabIndex = 13;
            this.Receivebutton.UseVisualStyleBackColor = true;
            this.Receivebutton.Click += new System.EventHandler(this.Receivebutton_Click);
            // 
            // Sendbutton
            // 
            this.Sendbutton.Image = ((System.Drawing.Image)(resources.GetObject("Sendbutton.Image")));
            this.Sendbutton.Location = new System.Drawing.Point(38, 65);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(150, 150);
            this.Sendbutton.TabIndex = 12;
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Receive_Label);
            this.Controls.Add(this.Send_Label);
            this.Controls.Add(this.Receivebutton);
            this.Controls.Add(this.Sendbutton);
            this.Name = "Start";
            this.Size = new System.Drawing.Size(476, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Receive_Label;
        private System.Windows.Forms.Label Send_Label;
        private System.Windows.Forms.Button Receivebutton;
        private System.Windows.Forms.Button Sendbutton;
    }
}
