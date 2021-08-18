namespace Contactmanager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblTitleLogin = new System.Windows.Forms.Label();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTitle
            // 
            this.TxtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtTitle.Location = new System.Drawing.Point(231, 242);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(214, 25);
            this.TxtTitle.TabIndex = 132;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblUser.Location = new System.Drawing.Point(229, 226);
            this.LblUser.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(75, 13);
            this.LblUser.TabIndex = 131;
            this.LblUser.Text = "Benutzername";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.TxtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtFirstname.Location = new System.Drawing.Point(231, 294);
            this.TxtFirstname.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(214, 25);
            this.TxtFirstname.TabIndex = 130;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblPassword.Location = new System.Drawing.Point(229, 278);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(50, 13);
            this.LblPassword.TabIndex = 129;
            this.LblPassword.Text = "Passwort";
            // 
            // LblTitleLogin
            // 
            this.LblTitleLogin.AutoSize = true;
            this.LblTitleLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblTitleLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblTitleLogin.Location = new System.Drawing.Point(228, 199);
            this.LblTitleLogin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblTitleLogin.Name = "LblTitleLogin";
            this.LblTitleLogin.Size = new System.Drawing.Size(43, 17);
            this.LblTitleLogin.TabIndex = 133;
            this.LblTitleLogin.Text = "Login";
            // 
            // ImgLogo
            // 
            this.ImgLogo.BackColor = System.Drawing.Color.Transparent;
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgLogo.InitialImage")));
            this.ImgLogo.Location = new System.Drawing.Point(231, 154);
            this.ImgLogo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(86, 27);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 134;
            this.ImgLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 507);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.LblTitleLogin);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TxtFirstname);
            this.Controls.Add(this.LblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "LoginForm";
            this.Text = "Login manfy";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblTitleLogin;
        private System.Windows.Forms.PictureBox ImgLogo;
    }
}