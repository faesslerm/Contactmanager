namespace Contactmanager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GridSearchResults = new System.Windows.Forms.DataGridView();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.CmdAddEmployee = new System.Windows.Forms.Button();
            this.CmdAddCustomer = new System.Windows.Forms.Button();
            this.TxtSearchBar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImgDelete = new System.Windows.Forms.PictureBox();
            this.ImgEdit = new System.Windows.Forms.PictureBox();
            this.TxtIntro1 = new System.Windows.Forms.TextBox();
            this.TxtIntro2 = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.ImgSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // GridSearchResults
            // 
            this.GridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSearchResults.Location = new System.Drawing.Point(40, 468);
            this.GridSearchResults.Name = "GridSearchResults";
            this.GridSearchResults.RowHeadersWidth = 92;
            this.GridSearchResults.RowTemplate.Height = 37;
            this.GridSearchResults.Size = new System.Drawing.Size(1489, 557);
            this.GridSearchResults.TabIndex = 5;
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
            this.ImgLogo.TabIndex = 6;
            this.ImgLogo.TabStop = false;
            // 
            // CmdAddEmployee
            // 
            this.CmdAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(139)))), ((int)(((byte)(184)))));
            this.CmdAddEmployee.ForeColor = System.Drawing.Color.White;
            this.CmdAddEmployee.Location = new System.Drawing.Point(40, 162);
            this.CmdAddEmployee.Margin = new System.Windows.Forms.Padding(7);
            this.CmdAddEmployee.Name = "CmdAddEmployee";
            this.CmdAddEmployee.Size = new System.Drawing.Size(355, 69);
            this.CmdAddEmployee.TabIndex = 7;
            this.CmdAddEmployee.Text = "Mitarbeiter erfassen";
            this.CmdAddEmployee.UseVisualStyleBackColor = false;
            this.CmdAddEmployee.Click += new System.EventHandler(this.CmdAddEmployee_Click);
            // 
            // CmdAddCustomer
            // 
            this.CmdAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(152)))), ((int)(((byte)(167)))));
            this.CmdAddCustomer.ForeColor = System.Drawing.Color.White;
            this.CmdAddCustomer.Location = new System.Drawing.Point(40, 254);
            this.CmdAddCustomer.Margin = new System.Windows.Forms.Padding(7); this.CmdAddCustomer.Name = "CmdAddCustomer";
            this.CmdAddCustomer.Size = new System.Drawing.Size(355, 69);
            this.CmdAddCustomer.TabIndex = 8;
            this.CmdAddCustomer.Text = "Kunde erfassen";
            this.CmdAddCustomer.UseVisualStyleBackColor = false;
            this.CmdAddCustomer.Click += new System.EventHandler(this.CmdAddCustomer_Click);
            // 
            // TxtSearchBar
            // 
            this.TxtSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.TxtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtSearchBar.Location = new System.Drawing.Point(40, 375);
            this.TxtSearchBar.Name = "TxtSearchBar";
            this.TxtSearchBar.Size = new System.Drawing.Size(980, 68);
            this.TxtSearchBar.TabIndex = 9;
            this.TxtSearchBar.TextChanged += new System.EventHandler(this.TxtSearchBar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1011, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ImgDelete
            // 
            this.ImgDelete.Image = ((System.Drawing.Image)(resources.GetObject("ImgDelete.Image")));
            this.ImgDelete.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgDelete.InitialImage")));
            this.ImgDelete.Location = new System.Drawing.Point(1489, 1053);
            this.ImgDelete.Name = "ImgDelete";
            this.ImgDelete.Size = new System.Drawing.Size(40, 40);
            this.ImgDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgDelete.TabIndex = 132;
            this.ImgDelete.TabStop = false;
            this.ImgDelete.Click += new System.EventHandler(this.CmdDeleteSelected_Click);
            // 
            // ImgEdit
            // 
            this.ImgEdit.Image = ((System.Drawing.Image)(resources.GetObject("ImgEdit.Image")));
            this.ImgEdit.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgEdit.InitialImage")));
            this.ImgEdit.Location = new System.Drawing.Point(1431, 1053);
            this.ImgEdit.Name = "ImgEdit";
            this.ImgEdit.Size = new System.Drawing.Size(40, 40);
            this.ImgEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgEdit.TabIndex = 133;
            this.ImgEdit.TabStop = false;
            this.ImgEdit.Click += new System.EventHandler(this.CmdEditSelected_Click);
            // 
            // TxtIntro1
            // 
            this.TxtIntro1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.TxtIntro1.Location = new System.Drawing.Point(450, 63);
            this.TxtIntro1.Multiline = true;
            this.TxtIntro1.Name = "TxtIntro1";
            this.TxtIntro1.Size = new System.Drawing.Size(519, 157);
            this.TxtIntro1.TabIndex = 135;
            this.TxtIntro1.Text = "Mit Hilfe des CRM manfy sind alle relevanten Daten der Mitarbeiter und Kunden an " +
    "einem zentralen Ort abrufbar, so dass keine wichtigen Informationen verloren geh" +
    "en.";
            // 
            // TxtIntro2
            // 
            this.TxtIntro2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.TxtIntro2.Location = new System.Drawing.Point(450, 220);
            this.TxtIntro2.Multiline = true;
            this.TxtIntro2.Name = "TxtIntro2";
            this.TxtIntro2.Size = new System.Drawing.Size(519, 103);
            this.TxtIntro2.TabIndex = 136;
            this.TxtIntro2.Text = "Das Produkt wurde entwickelt von Fiona Schmidiger, Markus Fässler und Anina Heinz" +
    "e.";
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSearch.ForeColor = System.Drawing.Color.White;
            this.LblSearch.Location = new System.Drawing.Point(59, 393);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(141, 36);
            this.LblSearch.TabIndex = 137;
            this.LblSearch.Text = "SUCHEN";
            // 
            // ImgSearch
            // 
            this.ImgSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(202)))), ((int)(((byte)(204)))));
            this.ImgSearch.Image = ((System.Drawing.Image)(resources.GetObject("ImgSearch.Image")));
            this.ImgSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImgSearch.InitialImage")));
            this.ImgSearch.Location = new System.Drawing.Point(967, 389);
            this.ImgSearch.Name = "ImgSearch";
            this.ImgSearch.Size = new System.Drawing.Size(40, 40);
            this.ImgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgSearch.TabIndex = 138;
            this.ImgSearch.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1572, 1131);
            this.Controls.Add(this.ImgSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TxtIntro2);
            this.Controls.Add(this.TxtIntro1);
            this.Controls.Add(this.ImgEdit);
            this.Controls.Add(this.ImgDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtSearchBar);
            this.Controls.Add(this.CmdAddCustomer);
            this.Controls.Add(this.CmdAddEmployee);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.GridSearchResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "manfy";
            ((System.ComponentModel.ISupportInitialize)(this.GridSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridSearchResults;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Button CmdAddEmployee;
        private System.Windows.Forms.Button CmdAddCustomer;
        private System.Windows.Forms.TextBox TxtSearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ImgDelete;
        private System.Windows.Forms.PictureBox ImgEdit;
        private System.Windows.Forms.TextBox TxtIntro1;
        private System.Windows.Forms.TextBox TxtIntro2;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.PictureBox ImgSearch;
    }
}