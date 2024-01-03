namespace HRApplication
{
    partial class AddEditEmployee
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbEmployeeType = new System.Windows.Forms.Label();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.lbEmploymentDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.lbComments = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbDismissDate = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbEmploymentDate = new System.Windows.Forms.TextBox();
            this.tbHourlyRate = new System.Windows.Forms.TextBox();
            this.tbDismissDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(191, 27);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(200, 22);
            this.tbId.TabIndex = 16;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(191, 106);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 22);
            this.tbLastName.TabIndex = 15;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(191, 66);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 22);
            this.tbFirstName.TabIndex = 2;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(33, 33);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 16);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Id";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(33, 72);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(32, 16);
            this.lbFirstName.TabIndex = 4;
            this.lbFirstName.Text = "Imię";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(33, 112);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(65, 16);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Nazwisko";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(33, 153);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(101, 16);
            this.lbBirthday.TabIndex = 6;
            this.lbBirthday.Text = "Data Urodzenia";
            // 
            // lbEmployeeType
            // 
            this.lbEmployeeType.AutoSize = true;
            this.lbEmployeeType.Location = new System.Drawing.Point(33, 199);
            this.lbEmployeeType.Name = "lbEmployeeType";
            this.lbEmployeeType.Size = new System.Drawing.Size(76, 16);
            this.lbEmployeeType.TabIndex = 8;
            this.lbEmployeeType.Text = "Stanowisko";
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Location = new System.Drawing.Point(191, 191);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(200, 24);
            this.cmbEmployeeType.TabIndex = 9;
            // 
            // lbEmploymentDate
            // 
            this.lbEmploymentDate.AutoSize = true;
            this.lbEmploymentDate.Location = new System.Drawing.Point(33, 242);
            this.lbEmploymentDate.Name = "lbEmploymentDate";
            this.lbEmploymentDate.Size = new System.Drawing.Size(113, 16);
            this.lbEmploymentDate.TabIndex = 12;
            this.lbEmploymentDate.Text = "Data Zatrudnienia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stawka Godzinowa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(431, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(191, 378);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(200, 110);
            this.rtbComments.TabIndex = 17;
            this.rtbComments.Text = "";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(33, 424);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(45, 16);
            this.lbComments.TabIndex = 18;
            this.lbComments.Text = "Uwagi";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(302, 504);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 23);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbDismissDate
            // 
            this.lbDismissDate.AutoSize = true;
            this.lbDismissDate.Location = new System.Drawing.Point(33, 333);
            this.lbDismissDate.Name = "lbDismissDate";
            this.lbDismissDate.Size = new System.Drawing.Size(103, 16);
            this.lbDismissDate.TabIndex = 22;
            this.lbDismissDate.Text = "Data Zwolnienia";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(191, 147);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(200, 22);
            this.tbBirthday.TabIndex = 23;
            // 
            // tbEmploymentDate
            // 
            this.tbEmploymentDate.Location = new System.Drawing.Point(191, 236);
            this.tbEmploymentDate.Name = "tbEmploymentDate";
            this.tbEmploymentDate.Size = new System.Drawing.Size(200, 22);
            this.tbEmploymentDate.TabIndex = 24;
            // 
            // tbHourlyRate
            // 
            this.tbHourlyRate.Location = new System.Drawing.Point(191, 279);
            this.tbHourlyRate.Name = "tbHourlyRate";
            this.tbHourlyRate.Size = new System.Drawing.Size(200, 22);
            this.tbHourlyRate.TabIndex = 26;
            // 
            // tbDismissDate
            // 
            this.tbDismissDate.Location = new System.Drawing.Point(191, 326);
            this.tbDismissDate.Name = "tbDismissDate";
            this.tbDismissDate.Size = new System.Drawing.Size(200, 22);
            this.tbDismissDate.TabIndex = 27;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 539);
            this.Controls.Add(this.tbDismissDate);
            this.Controls.Add(this.tbHourlyRate);
            this.Controls.Add(this.tbEmploymentDate);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.lbDismissDate);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmploymentDate);
            this.Controls.Add(this.cmbEmployeeType);
            this.Controls.Add(this.lbEmployeeType);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(449, 586);
            this.MinimumSize = new System.Drawing.Size(449, 586);
            this.Name = "AddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbEmployeeType;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
        private System.Windows.Forms.Label lbEmploymentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbDismissDate;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.TextBox tbEmploymentDate;
        private System.Windows.Forms.TextBox tbHourlyRate;
        private System.Windows.Forms.TextBox tbDismissDate;
    }
}