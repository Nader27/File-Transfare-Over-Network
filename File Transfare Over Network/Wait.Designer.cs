namespace File_Transfare_Over_Network
{
    partial class Wait
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
            this.components = new System.ComponentModel.Container();
            this.Waitting_Label = new System.Windows.Forms.Label();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Waitting_Label
            // 
            this.Waitting_Label.AutoSize = true;
            this.Waitting_Label.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Waitting_Label.Location = new System.Drawing.Point(72, 100);
            this.Waitting_Label.Name = "Waitting_Label";
            this.Waitting_Label.Size = new System.Drawing.Size(332, 33);
            this.Waitting_Label.TabIndex = 0;
            this.Waitting_Label.Text = "Waitting For Connection ...";
            this.Waitting_Label.TextChanged += new System.EventHandler(this.Waitting_Label_TextChanged);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopbutton.Location = new System.Drawing.Point(198, 213);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(75, 31);
            this.Stopbutton.TabIndex = 12;
            this.Stopbutton.Text = "Stop";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.Waitting_Label);
            this.Name = "Wait";
            this.Size = new System.Drawing.Size(476, 247);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Stopbutton;
        public System.Windows.Forms.Label Waitting_Label;
        private System.Windows.Forms.Timer timer;
    }
}
