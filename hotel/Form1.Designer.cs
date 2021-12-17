namespace hotel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتاتاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتکارکنانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتمشتریانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رزرواتاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.هزینهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اتاقهایخالیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl_roomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
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
            this.tbl_roomBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_roomTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_roomTableAdapter();
            this.tableAdapterManager = new hotel.hotelDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbl_reserveDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_reserveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_reserveTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_reserveTableAdapter();
            this.tbl_personelTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_personelTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingNavigator)).BeginInit();
            this.tbl_roomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.اطلاعاتمشتریانToolStripMenuItem,
            this.رزرواتاقToolStripMenuItem,
            this.هزینهToolStripMenuItem,
            this.گزارشToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتاتاقToolStripMenuItem,
            this.اطلاعاتکارکنانToolStripMenuItem});
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // ثبتاتاقToolStripMenuItem
            // 
            this.ثبتاتاقToolStripMenuItem.Name = "ثبتاتاقToolStripMenuItem";
            this.ثبتاتاقToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ثبتاتاقToolStripMenuItem.Text = "ثبت اتاق";
            this.ثبتاتاقToolStripMenuItem.Click += new System.EventHandler(this.ثبتاتاقToolStripMenuItem_Click);
            // 
            // اطلاعاتکارکنانToolStripMenuItem
            // 
            this.اطلاعاتکارکنانToolStripMenuItem.Name = "اطلاعاتکارکنانToolStripMenuItem";
            this.اطلاعاتکارکنانToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.اطلاعاتکارکنانToolStripMenuItem.Text = "اطلاعات کارکنان";
            this.اطلاعاتکارکنانToolStripMenuItem.Click += new System.EventHandler(this.اطلاعاتکارکنانToolStripMenuItem_Click);
            // 
            // اطلاعاتمشتریانToolStripMenuItem
            // 
            this.اطلاعاتمشتریانToolStripMenuItem.Name = "اطلاعاتمشتریانToolStripMenuItem";
            this.اطلاعاتمشتریانToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.اطلاعاتمشتریانToolStripMenuItem.Text = "اطلاعات مشتریان";
            this.اطلاعاتمشتریانToolStripMenuItem.Click += new System.EventHandler(this.اطلاعاتمشتریانToolStripMenuItem_Click);
            // 
            // رزرواتاقToolStripMenuItem
            // 
            this.رزرواتاقToolStripMenuItem.Name = "رزرواتاقToolStripMenuItem";
            this.رزرواتاقToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.رزرواتاقToolStripMenuItem.Text = "رزرو اتاق";
            this.رزرواتاقToolStripMenuItem.Click += new System.EventHandler(this.رزرواتاقToolStripMenuItem_Click);
            // 
            // هزینهToolStripMenuItem
            // 
            this.هزینهToolStripMenuItem.Name = "هزینهToolStripMenuItem";
            this.هزینهToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.هزینهToolStripMenuItem.Text = "هزینه ها";
            this.هزینهToolStripMenuItem.Click += new System.EventHandler(this.هزینهToolStripMenuItem_Click);
            // 
            // گزارشToolStripMenuItem
            // 
            this.گزارشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اتاقهایخالیToolStripMenuItem});
            this.گزارشToolStripMenuItem.Name = "گزارشToolStripMenuItem";
            this.گزارشToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.گزارشToolStripMenuItem.Text = "گزارشات";
            // 
            // اتاقهایخالیToolStripMenuItem
            // 
            this.اتاقهایخالیToolStripMenuItem.Name = "اتاقهایخالیToolStripMenuItem";
            this.اتاقهایخالیToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.اتاقهایخالیToolStripMenuItem.Text = "اتاق های خالی";
            this.اتاقهایخالیToolStripMenuItem.Click += new System.EventHandler(this.اتاقهایخالیToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // tbl_roomBindingNavigator
            // 
            this.tbl_roomBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_roomBindingNavigator.BindingSource = this.tbl_roomBindingSource;
            this.tbl_roomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_roomBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_roomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_roomBindingNavigatorSaveItem});
            this.tbl_roomBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_roomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_roomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_roomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_roomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_roomBindingNavigator.Name = "tbl_roomBindingNavigator";
            this.tbl_roomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_roomBindingNavigator.Size = new System.Drawing.Size(930, 25);
            this.tbl_roomBindingNavigator.TabIndex = 3;
            this.tbl_roomBindingNavigator.Text = "bindingNavigator1";
            this.tbl_roomBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbl_roomBindingSource
            // 
            this.tbl_roomBindingSource.DataMember = "tbl_room";
            this.tbl_roomBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbl_roomBindingNavigatorSaveItem
            // 
            this.tbl_roomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_roomBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_roomBindingNavigatorSaveItem.Image")));
            this.tbl_roomBindingNavigatorSaveItem.Name = "tbl_roomBindingNavigatorSaveItem";
            this.tbl_roomBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_roomBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_roomBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_roomBindingNavigatorSaveItem_Click);
            // 
            // tbl_roomTableAdapter
            // 
            this.tbl_roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_customerTableAdapter = null;
            this.tableAdapterManager.tbl_hazinehTableAdapter = null;
            this.tableAdapterManager.tbl_personelTableAdapter = null;
            this.tableAdapterManager.tbl_reserveTableAdapter = null;
            this.tableAdapterManager.tbl_roomTableAdapter = this.tbl_roomTableAdapter;
            this.tableAdapterManager.UpdateOrder = hotel.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblUsLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(671, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 419);
            this.panel1.TabIndex = 11;
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(114, 90);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(0, 18);
            this.lblPer.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "سطح دسترسی :";
            // 
            // lblUsLogin
            // 
            this.lblUsLogin.AutoSize = true;
            this.lblUsLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsLogin.Location = new System.Drawing.Point(53, 27);
            this.lblUsLogin.Name = "lblUsLogin";
            this.lblUsLogin.Size = new System.Drawing.Size(0, 18);
            this.lblUsLogin.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "کاربر وارد شده :";
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.hotelDataSet;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbl_reserveDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 419);
            this.panel2.TabIndex = 0;
            // 
            // tbl_reserveDataGridView
            // 
            this.tbl_reserveDataGridView.AutoGenerateColumns = false;
            this.tbl_reserveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_reserveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tbl_reserveDataGridView.DataSource = this.tbl_reserveBindingSource;
            this.tbl_reserveDataGridView.Location = new System.Drawing.Point(12, 27);
            this.tbl_reserveDataGridView.Name = "tbl_reserveDataGridView";
            this.tbl_reserveDataGridView.Size = new System.Drawing.Size(613, 372);
            this.tbl_reserveDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn1.HeaderText = "code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_start";
            this.dataGridViewTextBoxColumn2.HeaderText = "از تاریخ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date_end";
            this.dataGridViewTextBoxColumn3.HeaderText = "تا تاریخ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "code_room";
            this.dataGridViewTextBoxColumn4.HeaderText = "در اتاق";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "code_customer";
            this.dataGridViewTextBoxColumn5.HeaderText = "مشتری";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "madrak";
            this.dataGridViewTextBoxColumn6.HeaderText = "مدرک";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn7.HeaderText = "جمع کل حساب";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "takhfif";
            this.dataGridViewTextBoxColumn8.HeaderText = "takhfif";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "payments";
            this.dataGridViewTextBoxColumn9.HeaderText = "پرداختی";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // tbl_reserveBindingSource
            // 
            this.tbl_reserveBindingSource.DataMember = "tbl_reserve";
            this.tbl_reserveBindingSource.DataSource = this.hotelDataSet;
            // 
            // tbl_reserveTableAdapter
            // 
            this.tbl_reserveTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(930, 504);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbl_roomBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت هتل";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingNavigator)).EndInit();
            this.tbl_roomBindingNavigator.ResumeLayout(false);
            this.tbl_roomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتاتاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتکارکنانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتمشتریانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رزرواتاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اتاقهایخالیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem هزینهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tbl_roomBindingSource;
        private hotelDataSetTableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter;
        private hotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_roomBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_roomBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tbl_reserveBindingSource;
        private hotelDataSetTableAdapters.tbl_reserveTableAdapter tbl_reserveTableAdapter;
        private System.Windows.Forms.DataGridView tbl_reserveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private hotelDataSetTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
    }
}

