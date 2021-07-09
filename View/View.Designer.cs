
namespace Contactmanager
{
    partial class View
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdUpdateSave = new System.Windows.Forms.Button();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.LblComment = new System.Windows.Forms.Label();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.LblSex = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.NumAge = new System.Windows.Forms.NumericUpDown();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblLastname = new System.Windows.Forms.Label();
            this.LblFirstname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.LstData = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personenverwaltung nach MVC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdUpdateSave);
            this.groupBox1.Controls.Add(this.TxtComment);
            this.groupBox1.Controls.Add(this.LblComment);
            this.groupBox1.Controls.Add(this.RadFemale);
            this.groupBox1.Controls.Add(this.RadMale);
            this.groupBox1.Controls.Add(this.LblSex);
            this.groupBox1.Controls.Add(this.CmdSave);
            this.groupBox1.Controls.Add(this.NumAge);
            this.groupBox1.Controls.Add(this.TxtLastname);
            this.groupBox1.Controls.Add(this.TxtFirstname);
            this.groupBox1.Controls.Add(this.LblAge);
            this.groupBox1.Controls.Add(this.LblLastname);
            this.groupBox1.Controls.Add(this.LblFirstname);
            this.groupBox1.Location = new System.Drawing.Point(14, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Erfassung";
            // 
            // CmdUpdateSave
            // 
            this.CmdUpdateSave.Location = new System.Drawing.Point(514, 143);
            this.CmdUpdateSave.Name = "CmdUpdateSave";
            this.CmdUpdateSave.Size = new System.Drawing.Size(114, 33);
            this.CmdUpdateSave.TabIndex = 12;
            this.CmdUpdateSave.Text = "Änderung speichern";
            this.CmdUpdateSave.UseVisualStyleBackColor = true;
            this.CmdUpdateSave.Visible = false;
            this.CmdUpdateSave.Click += new System.EventHandler(this.CmdUpdateSave_Click);
            // 
            // TxtComment
            // 
            this.TxtComment.Location = new System.Drawing.Point(312, 57);
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtComment.Size = new System.Drawing.Size(316, 80);
            this.TxtComment.TabIndex = 11;
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(313, 31);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(76, 13);
            this.LblComment.TabIndex = 10;
            this.LblComment.Text = "Bemerkungen:";
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Location = new System.Drawing.Point(158, 151);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(63, 17);
            this.RadFemale.TabIndex = 9;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "weiblich";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Location = new System.Drawing.Point(72, 151);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(67, 17);
            this.RadMale.TabIndex = 8;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "männlich";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // LblSex
            // 
            this.LblSex.AutoSize = true;
            this.LblSex.Location = new System.Drawing.Point(6, 153);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(64, 13);
            this.LblSex.TabIndex = 7;
            this.LblSex.Text = "Geschlecht:";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(515, 143);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(114, 33);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // NumAge
            // 
            this.NumAge.Location = new System.Drawing.Point(72, 111);
            this.NumAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NumAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAge.Name = "NumAge";
            this.NumAge.Size = new System.Drawing.Size(219, 20);
            this.NumAge.TabIndex = 5;
            this.NumAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(72, 72);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(219, 20);
            this.TxtLastname.TabIndex = 4;
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(72, 31);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(219, 20);
            this.TxtFirstname.TabIndex = 3;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(6, 113);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(31, 13);
            this.LblAge.TabIndex = 2;
            this.LblAge.Text = "Alter:";
            // 
            // LblLastname
            // 
            this.LblLastname.AutoSize = true;
            this.LblLastname.Location = new System.Drawing.Point(6, 75);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(62, 13);
            this.LblLastname.TabIndex = 1;
            this.LblLastname.Text = "Nachname:";
            // 
            // LblFirstname
            // 
            this.LblFirstname.AutoSize = true;
            this.LblFirstname.Location = new System.Drawing.Point(6, 34);
            this.LblFirstname.Name = "LblFirstname";
            this.LblFirstname.Size = new System.Drawing.Size(52, 13);
            this.LblFirstname.TabIndex = 0;
            this.LblFirstname.Text = "Vorname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmdUpdate);
            this.groupBox2.Controls.Add(this.CmdDelete);
            this.groupBox2.Controls.Add(this.LstData);
            this.groupBox2.Location = new System.Drawing.Point(16, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 236);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datensätze";
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(407, 199);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(108, 31);
            this.CmdUpdate.TabIndex = 2;
            this.CmdUpdate.Text = "Ändern";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(521, 199);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(108, 31);
            this.CmdDelete.TabIndex = 1;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // LstData
            // 
            this.LstData.FormattingEnabled = true;
            this.LstData.Location = new System.Drawing.Point(7, 20);
            this.LstData.Name = "LstData";
            this.LstData.Size = new System.Drawing.Size(622, 173);
            this.LstData.TabIndex = 0;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.NumericUpDown NumAge;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblLastname;
        private System.Windows.Forms.Label LblFirstname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.ListBox LstData;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.Label LblSex;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Button CmdUpdateSave;
    }
}


