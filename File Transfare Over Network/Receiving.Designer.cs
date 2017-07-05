namespace File_Transfare_Over_Network
{
    partial class Receiving
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
            this.Present_label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Receive_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Present_label
            // 
            this.Present_label.AutoSize = true;
            this.Present_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Present_label.Location = new System.Drawing.Point(414, 112);
            this.Present_label.Name = "Present_label";
            this.Present_label.Size = new System.Drawing.Size(34, 19);
            this.Present_label.TabIndex = 15;
            this.Present_label.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 112);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(25, 138);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(45, 13);
            this.Status.TabIndex = 20;
            this.Status.Text = "Status :";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.Location = new System.Drawing.Point(192, 213);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 31);
            this.Cancelbutton.TabIndex = 19;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Receive_backgroundWorker
            // 
            this.Receive_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Receive_backgroundWorker_DoWork);
            // 
            // Receiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Present_label);
            this.Controls.Add(this.progressBar1);
            this.Name = "Receiving";
            this.Size = new System.Drawing.Size(476, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Present_label;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button Cancelbutton;
        public System.ComponentModel.BackgroundWorker Receive_backgroundWorker;
    }
}
