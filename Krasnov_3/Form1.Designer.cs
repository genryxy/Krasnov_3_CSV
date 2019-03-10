namespace Krasnov_3
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteStr = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBoxCoord = new System.Windows.Forms.TextBox();
            this.lblInfoRows = new System.Windows.Forms.Label();
            this.lblCountRows = new System.Windows.Forms.Label();
            this.labelInfoSelected = new System.Windows.Forms.Label();
            this.textBoxCountSelectedRows = new System.Windows.Forms.TextBox();
            this.textBoxIndexDeleteRow = new System.Windows.Forms.TextBox();
            this.labelInfoDelete = new System.Windows.Forms.Label();
            this.textBoxCoordX = new System.Windows.Forms.TextBox();
            this.textBoxCoordY = new System.Windows.Forms.TextBox();
            this.lblCoordX = new System.Windows.Forms.Label();
            this.lblCoordY = new System.Windows.Forms.Label();
            this.btnGetNearHead = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFilterAdmArea = new System.Windows.Forms.ToolStripLabel();
            this.toolComboBoxDistrict = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToExistingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overwriteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedByColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCoords = new System.Windows.Forms.ToolStripLabel();
            this.toolComboBoxAdmArea = new System.Windows.Forms.ToolStripComboBox();
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
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(415, 69);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1104, 478);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            // 
            // btnDeleteStr
            // 
            this.btnDeleteStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStr.Location = new System.Drawing.Point(127, 474);
            this.btnDeleteStr.Name = "btnDeleteStr";
            this.btnDeleteStr.Size = new System.Drawing.Size(128, 34);
            this.btnDeleteStr.TabIndex = 5;
            this.btnDeleteStr.Text = "Delete row";
            this.btnDeleteStr.UseVisualStyleBackColor = true;
            this.btnDeleteStr.Click += new System.EventHandler(this.btnDeleteStr_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(99, 385);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(176, 42);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show the required number of rows";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textBoxCoord
            // 
            this.textBoxCoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoord.Location = new System.Drawing.Point(64, 201);
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
            this.lblInfoRows.Location = new System.Drawing.Point(54, 329);
            this.lblInfoRows.Name = "lblInfoRows";
            this.lblInfoRows.Size = new System.Drawing.Size(212, 17);
            this.lblInfoRows.TabIndex = 10;
            this.lblInfoRows.Text = "The number of rows in the table:";
            // 
            // lblCountRows
            // 
            this.lblCountRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountRows.AutoSize = true;
            this.lblCountRows.BackColor = System.Drawing.SystemColors.Info;
            this.lblCountRows.Location = new System.Drawing.Point(272, 329);
            this.lblCountRows.Name = "lblCountRows";
            this.lblCountRows.Size = new System.Drawing.Size(16, 17);
            this.lblCountRows.TabIndex = 11;
            this.lblCountRows.Text = "0";
            // 
            // labelInfoSelected
            // 
            this.labelInfoSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoSelected.AutoSize = true;
            this.labelInfoSelected.BackColor = System.Drawing.SystemColors.Info;
            this.labelInfoSelected.Location = new System.Drawing.Point(54, 362);
            this.labelInfoSelected.Name = "labelInfoSelected";
            this.labelInfoSelected.Size = new System.Drawing.Size(175, 17);
            this.labelInfoSelected.TabIndex = 13;
            this.labelInfoSelected.Text = "Number of rows displayed:";
            // 
            // textBoxCountSelectedRows
            // 
            this.textBoxCountSelectedRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountSelectedRows.Location = new System.Drawing.Point(243, 359);
            this.textBoxCountSelectedRows.Name = "textBoxCountSelectedRows";
            this.textBoxCountSelectedRows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCountSelectedRows.Size = new System.Drawing.Size(64, 22);
            this.textBoxCountSelectedRows.TabIndex = 14;
            // 
            // textBoxIndexDeleteRow
            // 
            this.textBoxIndexDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIndexDeleteRow.Location = new System.Drawing.Point(226, 446);
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
            this.labelInfoDelete.Location = new System.Drawing.Point(54, 449);
            this.labelInfoDelete.Name = "labelInfoDelete";
            this.labelInfoDelete.Size = new System.Drawing.Size(166, 17);
            this.labelInfoDelete.TabIndex = 17;
            this.labelInfoDelete.Text = "Index of the deleted row: ";
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoordX.Location = new System.Drawing.Point(57, 115);
            this.textBoxCoordX.Name = "textBoxCoordX";
            this.textBoxCoordX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCoordX.Size = new System.Drawing.Size(118, 22);
            this.textBoxCoordX.TabIndex = 21;
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoordY.Location = new System.Drawing.Point(200, 115);
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
            this.lblCoordX.Location = new System.Drawing.Point(61, 86);
            this.lblCoordX.Name = "lblCoordX";
            this.lblCoordX.Size = new System.Drawing.Size(94, 17);
            this.lblCoordX.TabIndex = 23;
            this.lblCoordX.Text = "Coordinate X:";
            // 
            // lblCoordY
            // 
            this.lblCoordY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoordY.AutoSize = true;
            this.lblCoordY.BackColor = System.Drawing.SystemColors.Info;
            this.lblCoordY.Location = new System.Drawing.Point(213, 86);
            this.lblCoordY.Name = "lblCoordY";
            this.lblCoordY.Size = new System.Drawing.Size(94, 17);
            this.lblCoordY.TabIndex = 24;
            this.lblCoordY.Text = "Coordinate Y:";
            // 
            // btnGetNearHead
            // 
            this.btnGetNearHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetNearHead.Location = new System.Drawing.Point(90, 143);
            this.btnGetNearHead.Name = "btnGetNearHead";
            this.btnGetNearHead.Size = new System.Drawing.Size(198, 42);
            this.btnGetNearHead.TabIndex = 25;
            this.btnGetNearHead.Text = "Search the nearest headquarter";
            this.btnGetNearHead.UseVisualStyleBackColor = true;
            this.btnGetNearHead.Click += new System.EventHandler(this.btnGetNearHead_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnDownload,
            this.toolStripSeparator1,
            this.toolStripLabelCoords,
            this.toolComboBoxDistrict,
            this.toolStripSeparator2,
            this.toolStripLabelFilterAdmArea,
            this.toolComboBoxAdmArea});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1531, 28);
            this.toolStrip.TabIndex = 27;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnDownload
            // 
            this.toolBtnDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnDownload.Image")));
            this.toolBtnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDownload.Name = "toolBtnDownload";
            this.toolBtnDownload.Size = new System.Drawing.Size(102, 25);
            this.toolBtnDownload.Text = "Download";
            this.toolBtnDownload.Click += new System.EventHandler(this.toolBtnDownload_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabelFilterAdmArea
            // 
            this.toolStripLabelFilterAdmArea.Name = "toolStripLabelFilterAdmArea";
            this.toolStripLabelFilterAdmArea.Size = new System.Drawing.Size(132, 25);
            this.toolStripLabelFilterAdmArea.Text = "Filter by AdmArea:";
            // 
            // toolComboBoxDistrict
            // 
            this.toolComboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolComboBoxDistrict.Name = "toolComboBoxDistrict";
            this.toolComboBoxDistrict.Size = new System.Drawing.Size(210, 28);
            this.toolComboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.toolComboBoxDistrict_SelectedIndexChanged);
            this.toolComboBoxDistrict.Click += new System.EventHandler(this.toolComboBoxDistrict_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.sortedByColumnToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1531, 28);
            this.menuStrip.TabIndex = 28;
            this.menuStrip.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.addToExistingFileToolStripMenuItem,
            this.overwriteFileToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // addToExistingFileToolStripMenuItem
            // 
            this.addToExistingFileToolStripMenuItem.Name = "addToExistingFileToolStripMenuItem";
            this.addToExistingFileToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.addToExistingFileToolStripMenuItem.Text = "Add to Existing File";
            this.addToExistingFileToolStripMenuItem.Click += new System.EventHandler(this.addToExistingFileToolStripMenuItem_Click);
            // 
            // overwriteFileToolStripMenuItem
            // 
            this.overwriteFileToolStripMenuItem.Name = "overwriteFileToolStripMenuItem";
            this.overwriteFileToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.overwriteFileToolStripMenuItem.Text = "Overwrite File";
            this.overwriteFileToolStripMenuItem.Click += new System.EventHandler(this.overwriteFileToolStripMenuItem_Click);
            // 
            // sortedByColumnToolStripMenuItem
            // 
            this.sortedByColumnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.admAreaToolStripMenuItem});
            this.sortedByColumnToolStripMenuItem.Name = "sortedByColumnToolStripMenuItem";
            this.sortedByColumnToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.sortedByColumnToolStripMenuItem.Text = "Sorted by Column";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // admAreaToolStripMenuItem
            // 
            this.admAreaToolStripMenuItem.Name = "admAreaToolStripMenuItem";
            this.admAreaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.admAreaToolStripMenuItem.Text = "AdmArea";
            this.admAreaToolStripMenuItem.Click += new System.EventHandler(this.admAreaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabelCoords
            // 
            this.toolStripLabelCoords.Name = "toolStripLabelCoords";
            this.toolStripLabelCoords.Size = new System.Drawing.Size(176, 25);
            this.toolStripLabelCoords.Text = "Coordinates of one area: ";
            // 
            // toolComboBoxAdmArea
            // 
            this.toolComboBoxAdmArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolComboBoxAdmArea.Name = "toolComboBoxAdmArea";
            this.toolComboBoxAdmArea.Size = new System.Drawing.Size(280, 28);
            this.toolComboBoxAdmArea.SelectedIndexChanged += new System.EventHandler(this.toolComboBoxAdmArea_SelectedIndexChanged);
            this.toolComboBoxAdmArea.Click += new System.EventHandler(this.toolComboBoxAdmArea_Click);
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
            // tableHeaderBindingSource
            // 
            this.tableHeaderBindingSource.DataSource = typeof(Krasnov_3.TableHeader);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 575);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnGetNearHead);
            this.Controls.Add(this.lblCoordY);
            this.Controls.Add(this.lblCoordX);
            this.Controls.Add(this.textBoxCoordY);
            this.Controls.Add(this.textBoxCoordX);
            this.Controls.Add(this.labelInfoDelete);
            this.Controls.Add(this.textBoxIndexDeleteRow);
            this.Controls.Add(this.textBoxCountSelectedRows);
            this.Controls.Add(this.labelInfoSelected);
            this.Controls.Add(this.lblCountRows);
            this.Controls.Add(this.lblInfoRows);
            this.Controls.Add(this.textBoxCoord);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDeleteStr);
            this.Controls.Add(this.dataGridView);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с csv-файлом";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDeleteStr;
        private System.Windows.Forms.BindingSource tableHeaderBindingSource;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox textBoxCoord;
        private System.Windows.Forms.Label lblInfoRows;
        private System.Windows.Forms.Label lblCountRows;
        private System.Windows.Forms.Label labelInfoSelected;
        private System.Windows.Forms.TextBox textBoxCountSelectedRows;
        private System.Windows.Forms.TextBox textBoxIndexDeleteRow;
        private System.Windows.Forms.Label labelInfoDelete;
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
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToExistingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overwriteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolBtnDownload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolComboBoxDistrict;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilterAdmArea;
        private System.Windows.Forms.ToolStripMenuItem sortedByColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admAreaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCoords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolComboBoxAdmArea;
    }
}

