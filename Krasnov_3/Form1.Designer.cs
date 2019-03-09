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
            this.textBoxCoord = new System.Windows.Forms.TextBox();
            this.lblInfoRows = new System.Windows.Forms.Label();
            this.lblCountRows = new System.Windows.Forms.Label();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.labelInfoSelected = new System.Windows.Forms.Label();
            this.textBoxCountSelectedRows = new System.Windows.Forms.TextBox();
            this.btnRewrite = new System.Windows.Forms.Button();
            this.textBoxIndexDeleteRow = new System.Windows.Forms.TextBox();
            this.labelInfoDelete = new System.Windows.Forms.Label();
            this.lblInfoColumnSort = new System.Windows.Forms.Label();
            this.btnSortedName = new System.Windows.Forms.Button();
            this.btnSortedAdmArea = new System.Windows.Forms.Button();
            this.textBoxCoordX = new System.Windows.Forms.TextBox();
            this.textBoxCoordY = new System.Windows.Forms.TextBox();
            this.lblCoordX = new System.Windows.Forms.Label();
            this.lblCoordY = new System.Windows.Forms.Label();
            this.btnGetNearHead = new System.Windows.Forms.Button();
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
            this.btnWrite.Location = new System.Drawing.Point(549, 12);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(166, 49);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Сохранить в новый файл";
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
            this.dataGridView.AllowUserToDeleteRows = false;
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
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            // 
            // btnDeleteStr
            // 
            this.btnDeleteStr.Location = new System.Drawing.Point(1243, 469);
            this.btnDeleteStr.Name = "btnDeleteStr";
            this.btnDeleteStr.Size = new System.Drawing.Size(166, 49);
            this.btnDeleteStr.TabIndex = 5;
            this.btnDeleteStr.Text = "Удалить строку";
            this.btnDeleteStr.UseVisualStyleBackColor = true;
            this.btnDeleteStr.Click += new System.EventHandler(this.btnDeleteStr_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1243, 344);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(176, 42);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Вывести нужное количество строк";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(721, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 49);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Дописать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxCoord
            // 
            this.textBoxCoord.Location = new System.Drawing.Point(1243, 129);
            this.textBoxCoord.Multiline = true;
            this.textBoxCoord.Name = "textBoxCoord";
            this.textBoxCoord.ReadOnly = true;
            this.textBoxCoord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoord.Size = new System.Drawing.Size(219, 61);
            this.textBoxCoord.TabIndex = 9;
            // 
            // lblInfoRows
            // 
            this.lblInfoRows.AutoSize = true;
            this.lblInfoRows.Location = new System.Drawing.Point(1226, 246);
            this.lblInfoRows.Name = "lblInfoRows";
            this.lblInfoRows.Size = new System.Drawing.Size(201, 17);
            this.lblInfoRows.TabIndex = 10;
            this.lblInfoRows.Text = "Количество строк в таблице:";
            // 
            // lblCountRows
            // 
            this.lblCountRows.AutoSize = true;
            this.lblCountRows.Location = new System.Drawing.Point(1433, 246);
            this.lblCountRows.Name = "lblCountRows";
            this.lblCountRows.Size = new System.Drawing.Size(16, 17);
            this.lblCountRows.TabIndex = 11;
            this.lblCountRows.Text = "0";
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(1243, 196);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(219, 24);
            this.comboBoxDistrict.TabIndex = 12;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            this.comboBoxDistrict.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxDistrict_MouseClick);
            // 
            // labelInfoSelected
            // 
            this.labelInfoSelected.AutoSize = true;
            this.labelInfoSelected.Location = new System.Drawing.Point(1226, 286);
            this.labelInfoSelected.Name = "labelInfoSelected";
            this.labelInfoSelected.Size = new System.Drawing.Size(208, 17);
            this.labelInfoSelected.TabIndex = 13;
            this.labelInfoSelected.Text = "Количество выводимых строк:";
            // 
            // textBoxCountSelectedRows
            // 
            this.textBoxCountSelectedRows.Location = new System.Drawing.Point(1226, 316);
            this.textBoxCountSelectedRows.Name = "textBoxCountSelectedRows";
            this.textBoxCountSelectedRows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCountSelectedRows.Size = new System.Drawing.Size(219, 22);
            this.textBoxCountSelectedRows.TabIndex = 14;
            // 
            // btnRewrite
            // 
            this.btnRewrite.Location = new System.Drawing.Point(893, 12);
            this.btnRewrite.Name = "btnRewrite";
            this.btnRewrite.Size = new System.Drawing.Size(166, 49);
            this.btnRewrite.TabIndex = 15;
            this.btnRewrite.Text = "Переписать";
            this.btnRewrite.UseVisualStyleBackColor = true;
            this.btnRewrite.Click += new System.EventHandler(this.btnRewrite_Click);
            // 
            // textBoxIndexDeleteRow
            // 
            this.textBoxIndexDeleteRow.Location = new System.Drawing.Point(1226, 441);
            this.textBoxIndexDeleteRow.Name = "textBoxIndexDeleteRow";
            this.textBoxIndexDeleteRow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIndexDeleteRow.Size = new System.Drawing.Size(219, 22);
            this.textBoxIndexDeleteRow.TabIndex = 16;
            // 
            // labelInfoDelete
            // 
            this.labelInfoDelete.AutoSize = true;
            this.labelInfoDelete.Location = new System.Drawing.Point(1226, 421);
            this.labelInfoDelete.Name = "labelInfoDelete";
            this.labelInfoDelete.Size = new System.Drawing.Size(185, 17);
            this.labelInfoDelete.TabIndex = 17;
            this.labelInfoDelete.Text = "Индекс удаляемой строки:";
            // 
            // lblInfoColumnSort
            // 
            this.lblInfoColumnSort.AutoSize = true;
            this.lblInfoColumnSort.Location = new System.Drawing.Point(1240, 532);
            this.lblInfoColumnSort.Name = "lblInfoColumnSort";
            this.lblInfoColumnSort.Size = new System.Drawing.Size(174, 17);
            this.lblInfoColumnSort.TabIndex = 18;
            this.lblInfoColumnSort.Text = "Сортировать по столбцу:";
            // 
            // btnSortedName
            // 
            this.btnSortedName.Location = new System.Drawing.Point(1229, 552);
            this.btnSortedName.Name = "btnSortedName";
            this.btnSortedName.Size = new System.Drawing.Size(110, 46);
            this.btnSortedName.TabIndex = 19;
            this.btnSortedName.Text = "Name";
            this.btnSortedName.UseVisualStyleBackColor = true;
            this.btnSortedName.Click += new System.EventHandler(this.btnSortedName_Click);
            // 
            // btnSortedAdmArea
            // 
            this.btnSortedAdmArea.Location = new System.Drawing.Point(1352, 552);
            this.btnSortedAdmArea.Name = "btnSortedAdmArea";
            this.btnSortedAdmArea.Size = new System.Drawing.Size(110, 46);
            this.btnSortedAdmArea.TabIndex = 20;
            this.btnSortedAdmArea.Text = "AdmArea";
            this.btnSortedAdmArea.UseVisualStyleBackColor = true;
            this.btnSortedAdmArea.Click += new System.EventHandler(this.btnSortedAdmArea_Click);
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.Location = new System.Drawing.Point(1226, 57);
            this.textBoxCoordX.Name = "textBoxCoordX";
            this.textBoxCoordX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoordX.Size = new System.Drawing.Size(118, 22);
            this.textBoxCoordX.TabIndex = 21;
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.Location = new System.Drawing.Point(1352, 57);
            this.textBoxCoordY.Name = "textBoxCoordY";
            this.textBoxCoordY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoordY.Size = new System.Drawing.Size(118, 22);
            this.textBoxCoordY.TabIndex = 22;
            // 
            // lblCoordX
            // 
            this.lblCoordX.AutoSize = true;
            this.lblCoordX.Location = new System.Drawing.Point(1226, 37);
            this.lblCoordX.Name = "lblCoordX";
            this.lblCoordX.Size = new System.Drawing.Size(105, 17);
            this.lblCoordX.TabIndex = 23;
            this.lblCoordX.Text = "Координата Х:";
            // 
            // lblCoordY
            // 
            this.lblCoordY.AutoSize = true;
            this.lblCoordY.Location = new System.Drawing.Point(1349, 37);
            this.lblCoordY.Name = "lblCoordY";
            this.lblCoordY.Size = new System.Drawing.Size(105, 17);
            this.lblCoordY.TabIndex = 24;
            this.lblCoordY.Text = "Координата Y:";
            // 
            // btnGetNearHead
            // 
            this.btnGetNearHead.Location = new System.Drawing.Point(1251, 81);
            this.btnGetNearHead.Name = "btnGetNearHead";
            this.btnGetNearHead.Size = new System.Drawing.Size(198, 42);
            this.btnGetNearHead.TabIndex = 25;
            this.btnGetNearHead.Text = "Найти ближайший штаб";
            this.btnGetNearHead.UseVisualStyleBackColor = true;
            this.btnGetNearHead.Click += new System.EventHandler(this.btnGetNearHead_Click);
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
            this.Controls.Add(this.btnGetNearHead);
            this.Controls.Add(this.lblCoordY);
            this.Controls.Add(this.lblCoordX);
            this.Controls.Add(this.textBoxCoordY);
            this.Controls.Add(this.textBoxCoordX);
            this.Controls.Add(this.btnSortedAdmArea);
            this.Controls.Add(this.btnSortedName);
            this.Controls.Add(this.lblInfoColumnSort);
            this.Controls.Add(this.labelInfoDelete);
            this.Controls.Add(this.textBoxIndexDeleteRow);
            this.Controls.Add(this.btnRewrite);
            this.Controls.Add(this.textBoxCountSelectedRows);
            this.Controls.Add(this.labelInfoSelected);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.lblCountRows);
            this.Controls.Add(this.lblInfoRows);
            this.Controls.Add(this.textBoxCoord);
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
        private System.Windows.Forms.TextBox textBoxCoord;
        private System.Windows.Forms.Label lblInfoRows;
        private System.Windows.Forms.Label lblCountRows;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.Label labelInfoSelected;
        private System.Windows.Forms.TextBox textBoxCountSelectedRows;
        private System.Windows.Forms.Button btnRewrite;
        private System.Windows.Forms.TextBox textBoxIndexDeleteRow;
        private System.Windows.Forms.Label labelInfoDelete;
        private System.Windows.Forms.Label lblInfoColumnSort;
        private System.Windows.Forms.Button btnSortedName;
        private System.Windows.Forms.Button btnSortedAdmArea;
        private System.Windows.Forms.TextBox textBoxCoordX;
        private System.Windows.Forms.TextBox textBoxCoordY;
        private System.Windows.Forms.Label lblCoordX;
        private System.Windows.Forms.Label lblCoordY;
        private System.Windows.Forms.Button btnGetNearHead;
    }
}

