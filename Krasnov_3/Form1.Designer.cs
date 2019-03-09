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
            this.tableHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.tableHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.Location = new System.Drawing.Point(1339, 7);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(123, 58);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Сохранить в новый файл";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(1209, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(115, 58);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Загрузить";
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
            this.dataGridView.Location = new System.Drawing.Point(12, 7);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1173, 578);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            // 
            // btnDeleteStr
            // 
            this.btnDeleteStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStr.Location = new System.Drawing.Point(1286, 487);
            this.btnDeleteStr.Name = "btnDeleteStr";
            this.btnDeleteStr.Size = new System.Drawing.Size(128, 34);
            this.btnDeleteStr.TabIndex = 5;
            this.btnDeleteStr.Text = "Удалить строку";
            this.btnDeleteStr.UseVisualStyleBackColor = true;
            this.btnDeleteStr.Click += new System.EventHandler(this.btnDeleteStr_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(1260, 405);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(176, 42);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Вывести нужное количество строк";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(1209, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 39);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Дописать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxCoord
            // 
            this.textBoxCoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoord.Location = new System.Drawing.Point(1216, 203);
            this.textBoxCoord.Multiline = true;
            this.textBoxCoord.Name = "textBoxCoord";
            this.textBoxCoord.ReadOnly = true;
            this.textBoxCoord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoord.Size = new System.Drawing.Size(271, 96);
            this.textBoxCoord.TabIndex = 9;
            // 
            // lblInfoRows
            // 
            this.lblInfoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoRows.AutoSize = true;
            this.lblInfoRows.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfoRows.Location = new System.Drawing.Point(1206, 344);
            this.lblInfoRows.Name = "lblInfoRows";
            this.lblInfoRows.Size = new System.Drawing.Size(201, 17);
            this.lblInfoRows.TabIndex = 10;
            this.lblInfoRows.Text = "Количество строк в таблице:";
            // 
            // lblCountRows
            // 
            this.lblCountRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountRows.AutoSize = true;
            this.lblCountRows.BackColor = System.Drawing.SystemColors.Info;
            this.lblCountRows.Location = new System.Drawing.Point(1420, 344);
            this.lblCountRows.Name = "lblCountRows";
            this.lblCountRows.Size = new System.Drawing.Size(16, 17);
            this.lblCountRows.TabIndex = 11;
            this.lblCountRows.Text = "0";
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(1216, 305);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(243, 24);
            this.comboBoxDistrict.TabIndex = 12;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            this.comboBoxDistrict.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxDistrict_MouseClick);
            // 
            // labelInfoSelected
            // 
            this.labelInfoSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoSelected.AutoSize = true;
            this.labelInfoSelected.BackColor = System.Drawing.SystemColors.Info;
            this.labelInfoSelected.Location = new System.Drawing.Point(1206, 377);
            this.labelInfoSelected.Name = "labelInfoSelected";
            this.labelInfoSelected.Size = new System.Drawing.Size(208, 17);
            this.labelInfoSelected.TabIndex = 13;
            this.labelInfoSelected.Text = "Количество выводимых строк:";
            // 
            // textBoxCountSelectedRows
            // 
            this.textBoxCountSelectedRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountSelectedRows.Location = new System.Drawing.Point(1423, 373);
            this.textBoxCountSelectedRows.Name = "textBoxCountSelectedRows";
            this.textBoxCountSelectedRows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCountSelectedRows.Size = new System.Drawing.Size(64, 22);
            this.textBoxCountSelectedRows.TabIndex = 14;
            // 
            // btnRewrite
            // 
            this.btnRewrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRewrite.Location = new System.Drawing.Point(1341, 67);
            this.btnRewrite.Name = "btnRewrite";
            this.btnRewrite.Size = new System.Drawing.Size(121, 40);
            this.btnRewrite.TabIndex = 15;
            this.btnRewrite.Text = "Переписать";
            this.btnRewrite.UseVisualStyleBackColor = true;
            this.btnRewrite.Click += new System.EventHandler(this.btnRewrite_Click);
            // 
            // textBoxIndexDeleteRow
            // 
            this.textBoxIndexDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIndexDeleteRow.Location = new System.Drawing.Point(1404, 459);
            this.textBoxIndexDeleteRow.Name = "textBoxIndexDeleteRow";
            this.textBoxIndexDeleteRow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIndexDeleteRow.Size = new System.Drawing.Size(83, 22);
            this.textBoxIndexDeleteRow.TabIndex = 16;
            // 
            // labelInfoDelete
            // 
            this.labelInfoDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoDelete.AutoSize = true;
            this.labelInfoDelete.BackColor = System.Drawing.SystemColors.Info;
            this.labelInfoDelete.Location = new System.Drawing.Point(1206, 464);
            this.labelInfoDelete.Name = "labelInfoDelete";
            this.labelInfoDelete.Size = new System.Drawing.Size(185, 17);
            this.labelInfoDelete.TabIndex = 17;
            this.labelInfoDelete.Text = "Индекс удаляемой строки:";
            // 
            // lblInfoColumnSort
            // 
            this.lblInfoColumnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoColumnSort.AutoSize = true;
            this.lblInfoColumnSort.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfoColumnSort.Location = new System.Drawing.Point(1226, 535);
            this.lblInfoColumnSort.Name = "lblInfoColumnSort";
            this.lblInfoColumnSort.Size = new System.Drawing.Size(174, 17);
            this.lblInfoColumnSort.TabIndex = 18;
            this.lblInfoColumnSort.Text = "Сортировать по столбцу:";
            // 
            // btnSortedName
            // 
            this.btnSortedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortedName.Location = new System.Drawing.Point(1216, 555);
            this.btnSortedName.Name = "btnSortedName";
            this.btnSortedName.Size = new System.Drawing.Size(90, 30);
            this.btnSortedName.TabIndex = 19;
            this.btnSortedName.Text = "Name";
            this.btnSortedName.UseVisualStyleBackColor = true;
            this.btnSortedName.Click += new System.EventHandler(this.btnSortedName_Click);
            // 
            // btnSortedAdmArea
            // 
            this.btnSortedAdmArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortedAdmArea.Location = new System.Drawing.Point(1346, 555);
            this.btnSortedAdmArea.Name = "btnSortedAdmArea";
            this.btnSortedAdmArea.Size = new System.Drawing.Size(90, 30);
            this.btnSortedAdmArea.TabIndex = 20;
            this.btnSortedAdmArea.Text = "AdmArea";
            this.btnSortedAdmArea.UseVisualStyleBackColor = true;
            this.btnSortedAdmArea.Click += new System.EventHandler(this.btnSortedAdmArea_Click);
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoordX.Location = new System.Drawing.Point(1209, 130);
            this.textBoxCoordX.Name = "textBoxCoordX";
            this.textBoxCoordX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoordX.Size = new System.Drawing.Size(118, 22);
            this.textBoxCoordX.TabIndex = 21;
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoordY.Location = new System.Drawing.Point(1352, 130);
            this.textBoxCoordY.Name = "textBoxCoordY";
            this.textBoxCoordY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoordY.Size = new System.Drawing.Size(118, 22);
            this.textBoxCoordY.TabIndex = 22;
            // 
            // lblCoordX
            // 
            this.lblCoordX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoordX.AutoSize = true;
            this.lblCoordX.BackColor = System.Drawing.SystemColors.Info;
            this.lblCoordX.Location = new System.Drawing.Point(1212, 110);
            this.lblCoordX.Name = "lblCoordX";
            this.lblCoordX.Size = new System.Drawing.Size(105, 17);
            this.lblCoordX.TabIndex = 23;
            this.lblCoordX.Text = "Координата Х:";
            // 
            // lblCoordY
            // 
            this.lblCoordY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoordY.AutoSize = true;
            this.lblCoordY.BackColor = System.Drawing.SystemColors.Info;
            this.lblCoordY.Location = new System.Drawing.Point(1349, 110);
            this.lblCoordY.Name = "lblCoordY";
            this.lblCoordY.Size = new System.Drawing.Size(105, 17);
            this.lblCoordY.TabIndex = 24;
            this.lblCoordY.Text = "Координата Y:";
            // 
            // btnGetNearHead
            // 
            this.btnGetNearHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetNearHead.Location = new System.Drawing.Point(1251, 157);
            this.btnGetNearHead.Name = "btnGetNearHead";
            this.btnGetNearHead.Size = new System.Drawing.Size(198, 42);
            this.btnGetNearHead.TabIndex = 25;
            this.btnGetNearHead.Text = "Найти ближайший штаб";
            this.btnGetNearHead.UseVisualStyleBackColor = true;
            this.btnGetNearHead.Click += new System.EventHandler(this.btnGetNearHead_Click);
            // 
            // tableHeaderBindingSource
            // 
            this.tableHeaderBindingSource.DataSource = typeof(Krasnov_3.TableHeader);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // admAreaDataGridViewTextBoxColumn
            // 
            this.admAreaDataGridViewTextBoxColumn.DataPropertyName = "AdmArea";
            this.admAreaDataGridViewTextBoxColumn.HeaderText = "AdmArea";
            this.admAreaDataGridViewTextBoxColumn.Name = "admAreaDataGridViewTextBoxColumn";
            this.admAreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.admAreaDataGridViewTextBoxColumn.Width = 95;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.districtDataGridViewTextBoxColumn.Width = 80;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.addressDataGridViewTextBoxColumn.Width = 89;
            // 
            // publicPhoneDataGridViewTextBoxColumn
            // 
            this.publicPhoneDataGridViewTextBoxColumn.DataPropertyName = "PublicPhone";
            this.publicPhoneDataGridViewTextBoxColumn.HeaderText = "PublicPhone";
            this.publicPhoneDataGridViewTextBoxColumn.Name = "publicPhoneDataGridViewTextBoxColumn";
            this.publicPhoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.publicPhoneDataGridViewTextBoxColumn.Width = 116;
            // 
            // extraInfoDataGridViewTextBoxColumn
            // 
            this.extraInfoDataGridViewTextBoxColumn.DataPropertyName = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.HeaderText = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.Name = "extraInfoDataGridViewTextBoxColumn";
            this.extraInfoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.extraInfoDataGridViewTextBoxColumn.Width = 92;
            // 
            // xWGSDataGridViewTextBoxColumn
            // 
            this.xWGSDataGridViewTextBoxColumn.DataPropertyName = "X_WGS";
            this.xWGSDataGridViewTextBoxColumn.HeaderText = "X_WGS";
            this.xWGSDataGridViewTextBoxColumn.Name = "xWGSDataGridViewTextBoxColumn";
            this.xWGSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xWGSDataGridViewTextBoxColumn.Width = 87;
            // 
            // yWGSDataGridViewTextBoxColumn
            // 
            this.yWGSDataGridViewTextBoxColumn.DataPropertyName = "Y_WGS";
            this.yWGSDataGridViewTextBoxColumn.HeaderText = "Y_WGS";
            this.yWGSDataGridViewTextBoxColumn.Name = "yWGSDataGridViewTextBoxColumn";
            this.yWGSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yWGSDataGridViewTextBoxColumn.Width = 87;
            // 
            // gLOBALIDDataGridViewTextBoxColumn
            // 
            this.gLOBALIDDataGridViewTextBoxColumn.DataPropertyName = "GLOBALID";
            this.gLOBALIDDataGridViewTextBoxColumn.HeaderText = "GLOBALID";
            this.gLOBALIDDataGridViewTextBoxColumn.Name = "gLOBALIDDataGridViewTextBoxColumn";
            this.gLOBALIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gLOBALIDDataGridViewTextBoxColumn.Width = 106;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLOBALIDDataGridViewTextBoxColumn;
    }
}

