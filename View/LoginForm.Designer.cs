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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.ImgPassword = new System.Windows.Forms.PictureBox();
            this.ImgUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtUser.Location = new System.Drawing.Point(607, 296);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(1);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(300, 29);
            this.TxtUser.TabIndex = 0;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(607, 273);
            this.LblUser.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(104, 18);
            this.LblUser.TabIndex = 131;
            this.LblUser.Text = "Benutzername";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtPassword.Location = new System.Drawing.Point(607, 360);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(300, 29);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(607, 337);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(71, 18);
            this.LblPassword.TabIndex = 129;
            this.LblPassword.Text = "Passwort";
            // 
            // ImgLogo
            // 
            this.ImgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgLogo.InitialImage")));
            this.ImgLogo.Location = new System.Drawing.Point(607, 206);
            this.ImgLogo.Margin = new System.Windows.Forms.Padding(0);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(120, 40);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 134;
            this.ImgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // CmdLogin
            // 
            this.CmdLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(176)))));
            this.CmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmdLogin.ForeColor = System.Drawing.Color.White;
            this.CmdLogin.Location = new System.Drawing.Point(607, 406);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(300, 40);
            this.CmdLogin.TabIndex = 2;
            this.CmdLogin.Text = "ANMELDEN";
            this.CmdLogin.UseVisualStyleBackColor = false;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // ImgPassword
            // 
            this.ImgPassword.BackColor = System.Drawing.Color.White;
            this.ImgPassword.Image = ((System.Drawing.Image)(resources.GetObject("ImgPassword.Image")));
            this.ImgPassword.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgPassword.InitialImage")));
            this.ImgPassword.Location = new System.Drawing.Point(881, 366);
            this.ImgPassword.Margin = new System.Windows.Forms.Padding(1);
            this.ImgPassword.Name = "ImgPassword";
            this.ImgPassword.Size = new System.Drawing.Size(18, 18);
            this.ImgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPassword.TabIndex = 140;
            this.ImgPassword.TabStop = false;
            this.ImgPassword.Visible = false;
            // 
            // ImgUser
            // 
            this.ImgUser.BackColor = System.Drawing.Color.White;
            this.ImgUser.Image = ((System.Drawing.Image)(resources.GetObject("ImgUser.Image")));
            this.ImgUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgUser.InitialImage")));
            this.ImgUser.Location = new System.Drawing.Point(881, 302);
            this.ImgUser.Margin = new System.Windows.Forms.Padding(1);
            this.ImgUser.Name = "ImgUser";
            this.ImgUser.Size = new System.Drawing.Size(18, 18);
            this.ImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUser.TabIndex = 141;
            this.ImgUser.TabStop = false;
            this.ImgUser.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ImgUser);
            this.Controls.Add(this.ImgPassword);
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login manfy";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CmdLogin;
        private System.Windows.Forms.PictureBox ImgPassword;
        private System.Windows.Forms.PictureBox ImgUser;
    }
}