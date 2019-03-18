namespace Krasnov_3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblInfoRows = new System.Windows.Forms.Label();
            this.lblCountRows = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToExistingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overwriteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedByColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnAddHead = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelIndex = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxIndexOfRow = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGetNear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxCount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnShow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCoords = new System.Windows.Forms.ToolStripLabel();
            this.toolComboBoxDistrict = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFilterAdmArea = new System.Windows.Forms.ToolStripLabel();
            this.toolComboBoxAdmArea = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelFilterDistrict = new System.Windows.Forms.ToolStripLabel();
            this.toolComboBoxFiltDistrict = new System.Windows.Forms.ToolStripComboBox();
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
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.dataGridView.Location = new System.Drawing.Point(50, 90);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1194, 502);
            this.dataGridView.TabIndex = 4;
            // 
            // lblInfoRows
            // 
            this.lblInfoRows.AutoSize = true;
            this.lblInfoRows.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfoRows.Location = new System.Drawing.Point(97, 63);
            this.lblInfoRows.Name = "lblInfoRows";
            this.lblInfoRows.Size = new System.Drawing.Size(212, 17);
            this.lblInfoRows.TabIndex = 10;
            this.lblInfoRows.Text = "The number of rows in the table:";
            // 
            // lblCountRows
            // 
            this.lblCountRows.AutoSize = true;
            this.lblCountRows.BackColor = System.Drawing.SystemColors.Info;
            this.lblCountRows.Location = new System.Drawing.Point(315, 63);
            this.lblCountRows.Name = "lblCountRows";
            this.lblCountRows.Size = new System.Drawing.Size(16, 17);
            this.lblCountRows.TabIndex = 11;
            this.lblCountRows.Text = "0";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.sortedByColumnToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1570, 28);
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
            // toolBtnDownload
            // 
            this.toolBtnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnDownload.Image")));
            this.toolBtnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDownload.Name = "toolBtnDownload";
            this.toolBtnDownload.Size = new System.Drawing.Size(24, 25);
            this.toolBtnDownload.Text = "Download";
            this.toolBtnDownload.Click += new System.EventHandler(this.toolBtnDownload_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripBtnAddHead
            // 
            this.toolStripBtnAddHead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAddHead.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAddHead.Image")));
            this.toolStripBtnAddHead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddHead.Name = "toolStripBtnAddHead";
            this.toolStripBtnAddHead.Size = new System.Drawing.Size(24, 25);
            this.toolStripBtnAddHead.Text = "Add Head";
            this.toolStripBtnAddHead.Click += new System.EventHandler(this.toolStripAddHead_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabelIndex
            // 
            this.toolStripLabelIndex.Name = "toolStripLabelIndex";
            this.toolStripLabelIndex.Size = new System.Drawing.Size(124, 25);
            this.toolStripLabelIndex.Text = "Index of the row: ";
            // 
            // toolStripTextBoxIndexOfRow
            // 
            this.toolStripTextBoxIndexOfRow.Name = "toolStripTextBoxIndexOfRow";
            this.toolStripTextBoxIndexOfRow.Size = new System.Drawing.Size(50, 28);
            // 
            // toolStripBtnDelete
            // 
            this.toolStripBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDelete.Image")));
            this.toolStripBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDelete.Name = "toolStripBtnDelete";
            this.toolStripBtnDelete.Size = new System.Drawing.Size(24, 25);
            this.toolStripBtnDelete.Text = "Delete";
            this.toolStripBtnDelete.Click += new System.EventHandler(this.toolStripBtnDelete_Click);
            // 
            // toolStripBtnGetNear
            // 
            this.toolStripBtnGetNear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnGetNear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnGetNear.Image")));
            this.toolStripBtnGetNear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGetNear.Name = "toolStripBtnGetNear";
            this.toolStripBtnGetNear.Size = new System.Drawing.Size(24, 25);
            this.toolStripBtnGetNear.Text = "Near head";
            this.toolStripBtnGetNear.Click += new System.EventHandler(this.toolStripBtnGetNear_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabelCount
            // 
            this.toolStripLabelCount.Name = "toolStripLabelCount";
            this.toolStripLabelCount.Size = new System.Drawing.Size(123, 25);
            this.toolStripLabelCount.Text = "Number of rows: ";
            // 
            // toolStripTextBoxCount
            // 
            this.toolStripTextBoxCount.Name = "toolStripTextBoxCount";
            this.toolStripTextBoxCount.Size = new System.Drawing.Size(50, 28);
            // 
            // toolStripBtnShow
            // 
            this.toolStripBtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnShow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnShow.Image")));
            this.toolStripBtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnShow.Name = "toolStripBtnShow";
            this.toolStripBtnShow.Size = new System.Drawing.Size(24, 25);
            this.toolStripBtnShow.Text = "Show";
            this.toolStripBtnShow.Click += new System.EventHandler(this.toolStripBtnShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabelCoords
            // 
            this.toolStripLabelCoords.Name = "toolStripLabelCoords";
            this.toolStripLabelCoords.Size = new System.Drawing.Size(176, 25);
            this.toolStripLabelCoords.Text = "Coordinates of one area: ";
            // 
            // toolComboBoxDistrict
            // 
            this.toolComboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolComboBoxDistrict.Name = "toolComboBoxDistrict";
            this.toolComboBoxDistrict.Size = new System.Drawing.Size(170, 28);
            this.toolComboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.toolComboBoxDistrict_SelectedIndexChanged);
            this.toolComboBoxDistrict.Click += new System.EventHandler(this.toolComboBoxDistrict_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabelFilterAdmArea
            // 
            this.toolStripLabelFilterAdmArea.Name = "toolStripLabelFilterAdmArea";
            this.toolStripLabelFilterAdmArea.Size = new System.Drawing.Size(132, 25);
            this.toolStripLabelFilterAdmArea.Text = "Filter by AdmArea:";
            // 
            // toolComboBoxAdmArea
            // 
            this.toolComboBoxAdmArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolComboBoxAdmArea.Name = "toolComboBoxAdmArea";
            this.toolComboBoxAdmArea.Size = new System.Drawing.Size(220, 28);
            this.toolComboBoxAdmArea.SelectedIndexChanged += new System.EventHandler(this.toolComboBoxAdmArea_SelectedIndexChanged);
            this.toolComboBoxAdmArea.Click += new System.EventHandler(this.toolComboBoxAdmArea_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnDownload,
            this.toolStripSeparator3,
            this.toolStripBtnAddHead,
            this.toolStripSeparator4,
            this.toolStripLabelIndex,
            this.toolStripTextBoxIndexOfRow,
            this.toolStripBtnDelete,
            this.toolStripSeparator6,
            this.toolStripBtnGetNear,
            this.toolStripSeparator7,
            this.toolStripBtnEdit,
            this.toolStripSeparator5,
            this.toolStripLabelCount,
            this.toolStripTextBoxCount,
            this.toolStripBtnShow,
            this.toolStripSeparator1,
            this.toolStripLabelCoords,
            this.toolComboBoxDistrict,
            this.toolStripSeparator2,
            this.toolStripLabelFilterAdmArea,
            this.toolComboBoxAdmArea,
            this.toolStripLabelFilterDistrict,
            this.toolComboBoxFiltDistrict});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1570, 28);
            this.toolStrip.TabIndex = 27;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripBtnEdit
            // 
            this.toolStripBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEdit.Image")));
            this.toolStripBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEdit.Name = "toolStripBtnEdit";
            this.toolStripBtnEdit.Size = new System.Drawing.Size(24, 25);
            this.toolStripBtnEdit.Text = "Edit";
            this.toolStripBtnEdit.Click += new System.EventHandler(this.toolStripBtnEdit_Click);
            // 
            // toolStripLabelFilterDistrict
            // 
            this.toolStripLabelFilterDistrict.Name = "toolStripLabelFilterDistrict";
            this.toolStripLabelFilterDistrict.Size = new System.Drawing.Size(116, 25);
            this.toolStripLabelFilterDistrict.Text = "Filter by District:";
            // 
            // toolComboBoxFiltDistrict
            // 
            this.toolComboBoxFiltDistrict.Name = "toolComboBoxFiltDistrict";
            this.toolComboBoxFiltDistrict.Size = new System.Drawing.Size(170, 28);
            this.toolComboBoxFiltDistrict.SelectedIndexChanged += new System.EventHandler(this.toolComboBoxFiltDistrict_SelectedIndexChanged);
            this.toolComboBoxFiltDistrict.Click += new System.EventHandler(this.toolComboBoxFiltDistrict_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // admAreaDataGridViewTextBoxColumn
            // 
            this.admAreaDataGridViewTextBoxColumn.DataPropertyName = "AdmArea";
            this.admAreaDataGridViewTextBoxColumn.HeaderText = "AdmArea";
            this.admAreaDataGridViewTextBoxColumn.Name = "admAreaDataGridViewTextBoxColumn";
            this.admAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.admAreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.admAreaDataGridViewTextBoxColumn.Width = 95;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            this.districtDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.districtDataGridViewTextBoxColumn.Width = 80;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.addressDataGridViewTextBoxColumn.Width = 89;
            // 
            // publicPhoneDataGridViewTextBoxColumn
            // 
            this.publicPhoneDataGridViewTextBoxColumn.DataPropertyName = "PublicPhone";
            this.publicPhoneDataGridViewTextBoxColumn.HeaderText = "PublicPhone";
            this.publicPhoneDataGridViewTextBoxColumn.Name = "publicPhoneDataGridViewTextBoxColumn";
            this.publicPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.publicPhoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.publicPhoneDataGridViewTextBoxColumn.Width = 116;
            // 
            // extraInfoDataGridViewTextBoxColumn
            // 
            this.extraInfoDataGridViewTextBoxColumn.DataPropertyName = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.HeaderText = "ExtraInfo";
            this.extraInfoDataGridViewTextBoxColumn.Name = "extraInfoDataGridViewTextBoxColumn";
            this.extraInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.extraInfoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.extraInfoDataGridViewTextBoxColumn.Width = 92;
            // 
            // xWGSDataGridViewTextBoxColumn
            // 
            this.xWGSDataGridViewTextBoxColumn.DataPropertyName = "X_WGS";
            this.xWGSDataGridViewTextBoxColumn.HeaderText = "X_WGS";
            this.xWGSDataGridViewTextBoxColumn.Name = "xWGSDataGridViewTextBoxColumn";
            this.xWGSDataGridViewTextBoxColumn.ReadOnly = true;
            this.xWGSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.xWGSDataGridViewTextBoxColumn.Width = 87;
            // 
            // yWGSDataGridViewTextBoxColumn
            // 
            this.yWGSDataGridViewTextBoxColumn.DataPropertyName = "Y_WGS";
            this.yWGSDataGridViewTextBoxColumn.HeaderText = "Y_WGS";
            this.yWGSDataGridViewTextBoxColumn.Name = "yWGSDataGridViewTextBoxColumn";
            this.yWGSDataGridViewTextBoxColumn.ReadOnly = true;
            this.yWGSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yWGSDataGridViewTextBoxColumn.Width = 87;
            // 
            // gLOBALIDDataGridViewTextBoxColumn
            // 
            this.gLOBALIDDataGridViewTextBoxColumn.DataPropertyName = "GLOBALID";
            this.gLOBALIDDataGridViewTextBoxColumn.HeaderText = "GLOBALID";
            this.gLOBALIDDataGridViewTextBoxColumn.Name = "gLOBALIDDataGridViewTextBoxColumn";
            this.gLOBALIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gLOBALIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gLOBALIDDataGridViewTextBoxColumn.Width = 106;
            // 
            // tableHeaderBindingSource
            // 
            this.tableHeaderBindingSource.DataSource = typeof(Krasnov_3.TableHeader);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 599);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblCountRows);
            this.Controls.Add(this.lblInfoRows);
            this.Controls.Add(this.dataGridView);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1500, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Headquarters";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableHeaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource tableHeaderBindingSource;
        private System.Windows.Forms.Label lblInfoRows;
        private System.Windows.Forms.Label lblCountRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yWGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLOBALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToExistingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overwriteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortedByColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolBtnDownload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddHead;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelIndex;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxIndexOfRow;
        private System.Windows.Forms.ToolStripButton toolStripBtnDelete;
        private System.Windows.Forms.ToolStripButton toolStripBtnGetNear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCount;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCount;
        private System.Windows.Forms.ToolStripButton toolStripBtnShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCoords;
        private System.Windows.Forms.ToolStripComboBox toolComboBoxDistrict;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilterAdmArea;
        private System.Windows.Forms.ToolStripComboBox toolComboBoxAdmArea;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripBtnEdit;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilterDistrict;
        private System.Windows.Forms.ToolStripComboBox toolComboBoxFiltDistrict;
    }
}

