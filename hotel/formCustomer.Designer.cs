namespace hotel
{
    partial class formCustomer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label code_meliLabel;
            System.Windows.Forms.Label familyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label codeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomer));
            this.saveBtn = new System.Windows.Forms.Button();
            this.hotelDataSet = new hotel.hotelDataSet();
            this.tbl_customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_customerTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_customerTableAdapter();
            this.tableAdapterManager = new hotel.hotelDataSetTableAdapters.TableAdapterManager();
            this.tbl_customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.code_meliTextBox = new System.Windows.Forms.TextBox();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_customerDataGridView = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mobileLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            code_meliLabel = new System.Windows.Forms.Label();
            familyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingNavigator)).BeginInit();
            this.tbl_customerBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            mobileLabel.Location = new System.Drawing.Point(205, 82);
            mobileLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(62, 22);
            mobileLabel.TabIndex = 39;
            mobileLabel.Text = "موبایل :";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            phoneLabel.Location = new System.Drawing.Point(203, 26);
            phoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(47, 22);
            phoneLabel.TabIndex = 37;
            phoneLabel.Text = "تلفن :";
            // 
            // code_meliLabel
            // 
            code_meliLabel.AutoSize = true;
            code_meliLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            code_meliLabel.Location = new System.Drawing.Point(775, 65);
            code_meliLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            code_meliLabel.Name = "code_meliLabel";
            code_meliLabel.Size = new System.Drawing.Size(64, 22);
            code_meliLabel.TabIndex = 35;
            code_meliLabel.Text = "کد ملی :";
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            familyLabel.Location = new System.Drawing.Point(463, 73);
            familyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new System.Drawing.Size(100, 22);
            familyLabel.TabIndex = 33;
            familyLabel.Text = "نام خانوادگی :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(463, 22);
            nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 22);
            nameLabel.TabIndex = 31;
            nameLabel.Text = "نام :";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            codeLabel.Location = new System.Drawing.Point(766, 22);
            codeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(86, 22);
            codeLabel.TabIndex = 30;
            codeLabel.Text = "کد مشتری :";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(357, 135);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(140, 31);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "ثبت";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_customerBindingSource
            // 
            this.tbl_customerBindingSource.DataMember = "tbl_customer";
            this.tbl_customerBindingSource.DataSource = this.hotelDataSet;
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_customerTableAdapter = this.tbl_customerTableAdapter;
            this.tableAdapterManager.tbl_hazinehTableAdapter = null;
            this.tableAdapterManager.tbl_personelTableAdapter = null;
            this.tableAdapterManager.tbl_reserveTableAdapter = null;
            this.tableAdapterManager.tbl_roomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hotel.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_customerBindingNavigator
            // 
            this.tbl_customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_customerBindingNavigator.BindingSource = this.tbl_customerBindingSource;
            this.tbl_customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_customerBindingNavigatorSaveItem});
            this.tbl_customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_customerBindingNavigator.Name = "tbl_customerBindingNavigator";
            this.tbl_customerBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tbl_customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_customerBindingNavigator.Size = new System.Drawing.Size(1360, 37);
            this.tbl_customerBindingNavigator.TabIndex = 23;
            this.tbl_customerBindingNavigator.Text = "bindingNavigator1";
            this.tbl_customerBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 34);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(81, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tbl_customerBindingNavigatorSaveItem
            // 
            this.tbl_customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_customerBindingNavigatorSaveItem.Image")));
            this.tbl_customerBindingNavigatorSaveItem.Name = "tbl_customerBindingNavigatorSaveItem";
            this.tbl_customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 34);
            this.tbl_customerBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_customerBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(mobileLabel);
            this.panel1.Controls.Add(this.mobileTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(code_meliLabel);
            this.panel1.Controls.Add(this.code_meliTextBox);
            this.panel1.Controls.Add(familyLabel);
            this.panel1.Controls.Add(this.familyTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(codeLabel);
            this.panel1.Controls.Add(this.codeTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 182);
            this.panel1.TabIndex = 30;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(53, 78);
            this.mobileTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(142, 26);
            this.mobileTextBox.TabIndex = 41;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(51, 26);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(142, 26);
            this.phoneTextBox.TabIndex = 40;
            // 
            // code_meliTextBox
            // 
            this.code_meliTextBox.Location = new System.Drawing.Point(623, 61);
            this.code_meliTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.code_meliTextBox.Name = "code_meliTextBox";
            this.code_meliTextBox.Size = new System.Drawing.Size(142, 26);
            this.code_meliTextBox.TabIndex = 38;
            // 
            // familyTextBox
            // 
            this.familyTextBox.Location = new System.Drawing.Point(311, 69);
            this.familyTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(142, 26);
            this.familyTextBox.TabIndex = 36;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(311, 22);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 26);
            this.nameTextBox.TabIndex = 34;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(623, 22);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(142, 26);
            this.codeTextBox.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbl_customerDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 313);
            this.panel2.TabIndex = 31;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(388, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(135, 26);
            this.searchTextBox.TabIndex = 26;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(541, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "جستجو با کد ملی";
            // 
            // tbl_customerDataGridView
            // 
            this.tbl_customerDataGridView.AutoGenerateColumns = false;
            this.tbl_customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tbl_customerDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.tbl_customerDataGridView.DataSource = this.tbl_customerBindingSource;
            this.tbl_customerDataGridView.Location = new System.Drawing.Point(15, 60);
            this.tbl_customerDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbl_customerDataGridView.Name = "tbl_customerDataGridView";
            this.tbl_customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_customerDataGridView.Size = new System.Drawing.Size(834, 228);
            this.tbl_customerDataGridView.TabIndex = 24;
            this.tbl_customerDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.tbl_customerDataGridView_UserDeletingRow);
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "کد";
            this.code.Name = "code";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "family";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام خانوادگی";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "code_meli";
            this.dataGridViewTextBoxColumn4.HeaderText = "کد ملی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "تلفن";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "mobile";
            this.dataGridViewTextBoxColumn6.HeaderText = "موبایل";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشاطلاعاتToolStripMenuItem,
            this.حذفاطلاعاتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // ویرایشاطلاعاتToolStripMenuItem
            // 
            this.ویرایشاطلاعاتToolStripMenuItem.Name = "ویرایشاطلاعاتToolStripMenuItem";
            this.ویرایشاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ویرایشاطلاعاتToolStripMenuItem.Text = "ویرایش اطلاعات";
            this.ویرایشاطلاعاتToolStripMenuItem.Click += new System.EventHandler(this.ویرایشاطلاعاتToolStripMenuItem_Click);
            // 
            // حذفاطلاعاتToolStripMenuItem
            // 
            this.حذفاطلاعاتToolStripMenuItem.Name = "حذفاطلاعاتToolStripMenuItem";
            this.حذفاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.حذفاطلاعاتToolStripMenuItem.Text = "حذف اطلاعات";
            this.حذفاطلاعاتToolStripMenuItem.Click += new System.EventHandler(this.حذفاطلاعاتToolStripMenuItem_Click);
            // 
            // formCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_customerBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ثبت اطلاعات مشتریان";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.formCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingNavigator)).EndInit();
            this.tbl_customerBindingNavigator.ResumeLayout(false);
            this.tbl_customerBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tbl_customerBindingSource;
        private hotelDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private hotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_customerBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox code_meliTextBox;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbl_customerDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}