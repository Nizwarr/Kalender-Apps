namespace Kalender
{
    partial class UserControlHari
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
            this.lbhari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbhari
            // 
            this.lbhari.AutoSize = true;
            this.lbhari.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhari.Location = new System.Drawing.Point(44, 31);
            this.lbhari.Name = "lbhari";
            this.lbhari.Size = new System.Drawing.Size(25, 19);
            this.lbhari.TabIndex = 0;
            this.lbhari.Text = "00";
            // 
            // UserControlHari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lbhari);
            this.Name = "UserControlHari";
            this.Size = new System.Drawing.Size(110, 80);
            this.Load += new System.EventHandler(this.UserControlHari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhari;
    }
}
