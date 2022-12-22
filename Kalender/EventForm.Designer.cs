namespace Kalender
{
    partial class EventForm
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
            this.tx = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtanggal = new System.Windows.Forms.Label();
            this.txacara = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx
            // 
            this.tx.Enabled = false;
            this.tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx.Location = new System.Drawing.Point(12, 36);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(300, 26);
            this.tx.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 26);
            this.textBox2.TabIndex = 1;
            // 
            // txtanggal
            // 
            this.txtanggal.AutoSize = true;
            this.txtanggal.Location = new System.Drawing.Point(18, 20);
            this.txtanggal.Name = "txtanggal";
            this.txtanggal.Size = new System.Drawing.Size(46, 13);
            this.txtanggal.TabIndex = 2;
            this.txtanggal.Text = "Tanggal";
            // 
            // txacara
            // 
            this.txacara.AutoSize = true;
            this.txacara.Location = new System.Drawing.Point(18, 83);
            this.txacara.Name = "txacara";
            this.txacara.Size = new System.Drawing.Size(35, 13);
            this.txacara.TabIndex = 3;
            this.txacara.Text = "Acara";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 203);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txacara);
            this.Controls.Add(this.txtanggal);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tx);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtanggal;
        private System.Windows.Forms.Label txacara;
        private System.Windows.Forms.Button btnSave;
    }
}