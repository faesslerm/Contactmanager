namespace Contactmanager
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.TxtHistory = new System.Windows.Forms.TextBox();
            this.LblTitleHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgLogo
            // 
            this.ImgLogo.BackColor = System.Drawing.Color.Transparent;
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgLogo.InitialImage")));
            this.ImgLogo.Location = new System.Drawing.Point(17, 17);
            this.ImgLogo.Margin = new System.Windows.Forms.Padding(1);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(120, 40);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 8;
            this.ImgLogo.TabStop = false;
            // 
            // TxtHistory
            // 
            this.TxtHistory.BackColor = System.Drawing.Color.White;
            this.TxtHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHistory.Location = new System.Drawing.Point(18, 122);
            this.TxtHistory.Margin = new System.Windows.Forms.Padding(1);
            this.TxtHistory.Multiline = true;
            this.TxtHistory.Name = "TxtHistory";
            this.TxtHistory.Size = new System.Drawing.Size(946, 519);
            this.TxtHistory.TabIndex = 106;
            // 
            // LblTitleHistory
            // 
            this.LblTitleHistory.AutoSize = true;
            this.LblTitleHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblTitleHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblTitleHistory.Location = new System.Drawing.Point(15, 82);
            this.LblTitleHistory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblTitleHistory.Name = "LblTitleHistory";
            this.LblTitleHistory.Size = new System.Drawing.Size(67, 24);
            this.LblTitleHistory.TabIndex = 107;
            this.LblTitleHistory.Text = "History";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.LblTitleHistory);
            this.Controls.Add(this.TxtHistory);
            this.Controls.Add(this.ImgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.TextBox TxtHistory;
        private System.Windows.Forms.Label LblTitleHistory;
    }
}