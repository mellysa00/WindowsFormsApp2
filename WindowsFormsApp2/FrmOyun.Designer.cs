namespace WindowsFormsApp2
{
    partial class FrmOyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOyun));
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge = new System.Windows.Forms.Panel();
            this.lblsure = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlGosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 400;
            this.tmrButton.Tick += new System.EventHandler(this.tmrButton_Tick);
            // 
            // pnlGosterge
            // 
            this.pnlGosterge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlGosterge.Controls.Add(this.lblsure);
            this.pnlGosterge.Controls.Add(this.lblskor);
            this.pnlGosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGosterge.Location = new System.Drawing.Point(742, 0);
            this.pnlGosterge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGosterge.Name = "pnlGosterge";
            this.pnlGosterge.Size = new System.Drawing.Size(131, 554);
            this.pnlGosterge.TabIndex = 0;
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(48, 137);
            this.lblsure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(38, 17);
            this.lblsure.TabIndex = 1;
            this.lblsure.Text = "Süre";
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(48, 183);
            this.lblskor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(37, 17);
            this.lblskor.TabIndex = 0;
            this.lblskor.Text = "Skor";
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "snbhr.jpg.jpg");
            // 
            // FrmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 554);
            this.Controls.Add(this.pnlGosterge);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOyun";
            this.Text = "FrmOyun";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.pnlGosterge.ResumeLayout(false);
            this.pnlGosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Panel pnlGosterge;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.ImageList ımageList1;
    }
}