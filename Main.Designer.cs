namespace HRApplication
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvHRApp = new System.Windows.Forms.DataGridView();
            this.cmbEmployeeStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRApp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-9, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Location = new System.Drawing.Point(34, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Location = new System.Drawing.Point(151, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDismiss.Location = new System.Drawing.Point(266, 13);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(75, 30);
            this.btnDismiss.TabIndex = 3;
            this.btnDismiss.Text = "Zwolnij";
            this.btnDismiss.UseVisualStyleBackColor = false;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Aqua;
            this.btnRefresh.Location = new System.Drawing.Point(382, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvHRApp
            // 
            this.dgvHRApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHRApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHRApp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHRApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRApp.Location = new System.Drawing.Point(1, 58);
            this.dgvHRApp.Name = "dgvHRApp";
            this.dgvHRApp.RowHeadersVisible = false;
            this.dgvHRApp.RowHeadersWidth = 51;
            this.dgvHRApp.RowTemplate.Height = 24;
            this.dgvHRApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHRApp.Size = new System.Drawing.Size(1307, 561);
            this.dgvHRApp.TabIndex = 5;
            // 
            // cmbEmployeeStatus
            // 
            this.cmbEmployeeStatus.FormattingEnabled = true;
            this.cmbEmployeeStatus.Location = new System.Drawing.Point(551, 18);
            this.cmbEmployeeStatus.Name = "cmbEmployeeStatus";
            this.cmbEmployeeStatus.Size = new System.Drawing.Size(170, 24);
            this.cmbEmployeeStatus.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 618);
            this.Controls.Add(this.cmbEmployeeStatus);
            this.Controls.Add(this.dgvHRApp);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Zarządzaj Pracownikami";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvHRApp;
        private System.Windows.Forms.ComboBox cmbEmployeeStatus;
    }
}

