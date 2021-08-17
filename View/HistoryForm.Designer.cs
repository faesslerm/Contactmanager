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
            this.TxtEmployeeNr = new System.Windows.Forms.TextBox();
            this.LblTitleHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgLogo
            // 
            this.ImgLogo.BackColor = System.Drawing.Color.Transparent;
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgLogo.InitialImage")));
            this.ImgLogo.Location = new System.Drawing.Point(40, 40);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(200, 60);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 8;
            this.ImgLogo.TabStop = false;
            // 
            // TxtEmployeeNr
            // 
            this.TxtEmployeeNr.BackColor = System.Drawing.Color.White;
            this.TxtEmployeeNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmployeeNr.Location = new System.Drawing.Point(41, 237);
            this.TxtEmployeeNr.Multiline = true;
            this.TxtEmployeeNr.Name = "TxtEmployeeNr";
            this.TxtEmployeeNr.Size = new System.Drawing.Size(1480, 830);
            this.TxtEmployeeNr.TabIndex = 106;
            // 
            // LblTitleHistory
            // 
            this.LblTitleHistory.AutoSize = true;
            this.LblTitleHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblTitleHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblTitleHistory.Location = new System.Drawing.Point(35, 164);
            this.LblTitleHistory.Name = "LblTitleHistory";
            this.LblTitleHistory.Size = new System.Drawing.Size(230, 36);
            this.LblTitleHistory.TabIndex = 107;
            this.LblTitleHistory.Text = "History ansehen";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 1121);
            this.Controls.Add(this.LblTitleHistory);
            this.Controls.Add(this.TxtEmployeeNr);
            this.Controls.Add(this.ImgLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.TextBox TxtEmployeeNr;
        private System.Windows.Forms.Label LblTitleHistory;
    }
}