namespace Krasnov_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.headquarterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOWNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xWGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yWGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLOBALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headquarterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(202, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(166, 49);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(413, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(166, 49);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(624, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(166, 49);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rOWNUMDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.admAreaDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.publicPhoneDataGridViewTextBoxColumn,
            this.extraInfoDataGridViewTextBoxColumn,
            this.xWGSDataGridViewTextBoxColumn,
            this.yWGSDataGridViewTextBoxColumn,
            this.gLOBALIDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.headquarterBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(29, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1023, 338);
            this.dataGridView.TabIndex = 4;
            // 
            // headquarterBindingSource
            // 
            this.headquarterBindingSource.DataSource = typeof(Krasnov_3.Headquarter);
            // 
            // rOWNUMDataGridViewTextBoxColumn
            // 
            this.rOWNUMDataGridViewTextBoxColumn.DataPropertyName = "ROWNUM";
            this.rOWNUMDataGridViewTextBoxColumn.HeaderText = "ROWNUM";
            this.rOWNUMDataGridViewTextBoxColumn.Name = "rOWNUMDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // admAreaDataGridViewTextBoxColumn
            // 
            this.admAreaDataGridViewTextBoxColumn.DataPropertyName = "AdmArea";
            this.admAreaDataGridViewTextBoxColumn.HeaderText = "AdmArea";
            this.admAreaDataGridViewTextBoxColumn.Name = "admAreaDataGridViewTextBoxColumn";
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // publicPhoneDataGridViewTextBoxColumn
            // 
            this.publicPhoneDataGridViewTextBoxColumn.DataPropertyName = "PublicPhone";
            this.publicPhoneDataGridViewTextBoxColumn.HeaderText = "PublicPhone";
            this.publicPhoneDataGridViewTextBoxColumn.Name = "publicPhoneDataGridViewTextBoxColumn";
            // 
            // extraInfoDataGridViewTextBoxColumn
            // 
            this.extraInfoDataGridViewTextBoxColumn.DataPropertyName = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.HeaderText = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.Name = "extraInfoDataGridViewTextBoxColumn";
            // 
            // xWGSDataGridViewTextBoxColumn
            // 
            this.xWGSDataGridViewTextBoxColumn.DataPropertyName = "X_WGS";
            this.xWGSDataGridViewTextBoxColumn.HeaderText = "X_WGS";
            this.xWGSDataGridViewTextBoxColumn.Name = "xWGSDataGridViewTextBoxColumn";
            // 
            // yWGSDataGridViewTextBoxColumn
            // 
            this.yWGSDataGridViewTextBoxColumn.DataPropertyName = "Y_WGS";
            this.yWGSDataGridViewTextBoxColumn.HeaderText = "Y_WGS";
            this.yWGSDataGridViewTextBoxColumn.Name = "yWGSDataGridViewTextBoxColumn";
            // 
            // gLOBALIDDataGridViewTextBoxColumn
            // 
            this.gLOBALIDDataGridViewTextBoxColumn.DataPropertyName = "GLOBALID";
            this.gLOBALIDDataGridViewTextBoxColumn.HeaderText = "GLOBALID";
            this.gLOBALIDDataGridViewTextBoxColumn.Name = "gLOBALIDDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headquarterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOWNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLOBALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource headquarterBindingSource;
    }
}

