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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteStr = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGetCoordOneDistrict = new System.Windows.Forms.Button();
            this.textBoxCoord = new System.Windows.Forms.TextBox();
            this.lblInfoRows = new System.Windows.Forms.Label();
            this.lblCountRows = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xWGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yWGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLOBALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(205, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(166, 49);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Сохранить";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(377, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(166, 49);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.admAreaDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.publicPhoneDataGridViewTextBoxColumn,
            this.extraInfoDataGridViewTextBoxColumn,
            this.xWGSDataGridViewTextBoxColumn,
            this.yWGSDataGridViewTextBoxColumn,
            this.gLOBALIDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tableHeaderBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(33, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1187, 518);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            this.dataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserDeletedRow);
            // 
            // btnDeleteStr
            // 
            this.btnDeleteStr.Location = new System.Drawing.Point(549, 12);
            this.btnDeleteStr.Name = "btnDeleteStr";
            this.btnDeleteStr.Size = new System.Drawing.Size(166, 49);
            this.btnDeleteStr.TabIndex = 5;
            this.btnDeleteStr.Text = "Удалить строку";
            this.btnDeleteStr.UseVisualStyleBackColor = true;
            this.btnDeleteStr.Click += new System.EventHandler(this.btnDeleteStr_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(33, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(166, 49);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Вывести N строк";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(721, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 49);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Дозаписать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGetCoordOneDistrict
            // 
            this.btnGetCoordOneDistrict.Location = new System.Drawing.Point(893, 12);
            this.btnGetCoordOneDistrict.Name = "btnGetCoordOneDistrict";
            this.btnGetCoordOneDistrict.Size = new System.Drawing.Size(166, 49);
            this.btnGetCoordOneDistrict.TabIndex = 8;
            this.btnGetCoordOneDistrict.Text = "Координаты одного района";
            this.btnGetCoordOneDistrict.UseVisualStyleBackColor = true;
            this.btnGetCoordOneDistrict.Click += new System.EventHandler(this.btnGetCoordOneDistrict_Click);
            // 
            // textBoxCoord
            // 
            this.textBoxCoord.Location = new System.Drawing.Point(1261, 229);
            this.textBoxCoord.Multiline = true;
            this.textBoxCoord.Name = "textBoxCoord";
            this.textBoxCoord.ReadOnly = true;
            this.textBoxCoord.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCoord.Size = new System.Drawing.Size(219, 95);
            this.textBoxCoord.TabIndex = 9;
            // 
            // lblInfoRows
            // 
            this.lblInfoRows.AutoSize = true;
            this.lblInfoRows.Location = new System.Drawing.Point(1260, 342);
            this.lblInfoRows.Name = "lblInfoRows";
            this.lblInfoRows.Size = new System.Drawing.Size(131, 17);
            this.lblInfoRows.TabIndex = 10;
            this.lblInfoRows.Text = "Количество строк:";
            // 
            // lblCountRows
            // 
            this.lblCountRows.AutoSize = true;
            this.lblCountRows.Location = new System.Drawing.Point(1407, 342);
            this.lblCountRows.Name = "lblCountRows";
            this.lblCountRows.Size = new System.Drawing.Size(16, 17);
            this.lblCountRows.TabIndex = 11;
            this.lblCountRows.Text = "0";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(1261, 387);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(219, 24);
            this.comboBox.TabIndex = 12;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
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
            // tableHeaderBindingSource
            // 
            this.tableHeaderBindingSource.DataSource = typeof(Krasnov_3.TableHeader);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 610);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lblCountRows);
            this.Controls.Add(this.lblInfoRows);
            this.Controls.Add(this.textBoxCoord);
            this.Controls.Add(this.btnGetCoordOneDistrict);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDeleteStr);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с csv-файлом";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDeleteStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOWNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableHeaderBindingSource;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLOBALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGetCoordOneDistrict;
        private System.Windows.Forms.TextBox textBoxCoord;
        private System.Windows.Forms.Label lblInfoRows;
        private System.Windows.Forms.Label lblCountRows;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

