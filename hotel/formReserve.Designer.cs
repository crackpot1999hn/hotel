namespace hotel
{
    partial class formReserve
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label madrakLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label code_customerLabel;
            System.Windows.Forms.Label code_roomLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label paymentsLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReserve));
            this.tblroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.codeRezerveTextBox = new System.Windows.Forms.TextBox();
            this.tbl_reserveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.calBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.baghiMandehTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_reserveBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_reserveBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_reserveTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_reserveTableAdapter();
            this.tableAdapterManager = new hotel.hotelDataSetTableAdapters.TableAdapterManager();
            this.tbl_customerTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_customerTableAdapter();
            this.tbl_roomTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_roomTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codecustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madrakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takhfifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.خالیکردناتاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.faDatePicker2 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.madrakTextBox = new System.Windows.Forms.TextBox();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            madrakLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            code_customerLabel = new System.Windows.Forms.Label();
            code_roomLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            paymentsLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingNavigator)).BeginInit();
            this.tbl_reserveBindingNavigator.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(99, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 22);
            label3.TabIndex = 47;
            label3.Text = "کرایه :";
            // 
            // madrakLabel
            // 
            madrakLabel.AutoSize = true;
            madrakLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            madrakLabel.Location = new System.Drawing.Point(327, 81);
            madrakLabel.Name = "madrakLabel";
            madrakLabel.Size = new System.Drawing.Size(59, 22);
            madrakLabel.TabIndex = 39;
            madrakLabel.Text = "مدرک :";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            codeLabel.Location = new System.Drawing.Point(879, 27);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 22);
            codeLabel.TabIndex = 35;
            codeLabel.Text = "کد :";
            // 
            // code_customerLabel
            // 
            code_customerLabel.AutoSize = true;
            code_customerLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            code_customerLabel.Location = new System.Drawing.Point(866, 74);
            code_customerLabel.Name = "code_customerLabel";
            code_customerLabel.Size = new System.Drawing.Size(67, 22);
            code_customerLabel.TabIndex = 38;
            code_customerLabel.Text = "مشتری :";
            // 
            // code_roomLabel
            // 
            code_roomLabel.AutoSize = true;
            code_roomLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            code_roomLabel.Location = new System.Drawing.Point(590, 82);
            code_roomLabel.Name = "code_roomLabel";
            code_roomLabel.Size = new System.Drawing.Size(52, 22);
            code_roomLabel.TabIndex = 37;
            code_roomLabel.Text = " اتاق :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(501, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 22);
            label4.TabIndex = 36;
            label4.Text = "جمع کل حساب :";
            // 
            // paymentsLabel
            // 
            paymentsLabel.AutoSize = true;
            paymentsLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            paymentsLabel.Location = new System.Drawing.Point(501, 111);
            paymentsLabel.Name = "paymentsLabel";
            paymentsLabel.Size = new System.Drawing.Size(116, 22);
            paymentsLabel.TabIndex = 24;
            paymentsLabel.Text = "باقیمانده حساب :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            totalLabel.Location = new System.Drawing.Point(822, 108);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(48, 22);
            totalLabel.TabIndex = 20;
            totalLabel.Text = "مبلغ :";
            // 
            // tblroomBindingSource
            // 
            this.tblroomBindingSource.DataMember = "tbl_room";
            this.tblroomBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 275);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.codeRezerveTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.calBtn);
            this.panel2.Controls.Add(this.applyBtn);
            this.panel2.Controls.Add(this.baghiMandehTextBox);
            this.panel2.Controls.Add(paymentsLabel);
            this.panel2.Controls.Add(totalLabel);
            this.panel2.Controls.Add(this.paymentTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 155);
            this.panel2.TabIndex = 27;
            // 
            // codeRezerveTextBox
            // 
            this.codeRezerveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_reserveBindingSource, "code", true));
            this.codeRezerveTextBox.Enabled = false;
            this.codeRezerveTextBox.Location = new System.Drawing.Point(642, 35);
            this.codeRezerveTextBox.Name = "codeRezerveTextBox";
            this.codeRezerveTextBox.Size = new System.Drawing.Size(139, 26);
            this.codeRezerveTextBox.TabIndex = 39;
            // 
            // tbl_reserveBindingSource
            // 
            this.tbl_reserveBindingSource.DataMember = "tbl_reserve";
            this.tbl_reserveBindingSource.DataSource = this.hotelDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(793, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "کد رزرو :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_reserveBindingSource, "total", true));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(412, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 19);
            this.lblTotal.TabIndex = 37;
            // 
            // calBtn
            // 
            this.calBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.calBtn.Location = new System.Drawing.Point(195, 32);
            this.calBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(98, 29);
            this.calBtn.TabIndex = 35;
            this.calBtn.Text = "محاسبه";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(52, 111);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(132, 27);
            this.applyBtn.TabIndex = 26;
            this.applyBtn.Text = "اعمال";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click_1);
            // 
            // baghiMandehTextBox
            // 
            this.baghiMandehTextBox.Location = new System.Drawing.Point(337, 111);
            this.baghiMandehTextBox.Name = "baghiMandehTextBox";
            this.baghiMandehTextBox.Size = new System.Drawing.Size(158, 26);
            this.baghiMandehTextBox.TabIndex = 25;
            this.baghiMandehTextBox.Text = "0";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(659, 107);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(151, 26);
            this.paymentTextBox.TabIndex = 21;
            this.paymentTextBox.Text = "0";
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tbl_customer";
            this.tblcustomerBindingSource.DataSource = this.hotelDataSet;
            // 
            // tbl_reserveBindingNavigator
            // 
            this.tbl_reserveBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_reserveBindingNavigator.BindingSource = this.tbl_reserveBindingSource;
            this.tbl_reserveBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_reserveBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_reserveBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_reserveBindingNavigatorSaveItem});
            this.tbl_reserveBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_reserveBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_reserveBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_reserveBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_reserveBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_reserveBindingNavigator.Name = "tbl_reserveBindingNavigator";
            this.tbl_reserveBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_reserveBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.tbl_reserveBindingNavigator.TabIndex = 2;
            this.tbl_reserveBindingNavigator.Text = "bindingNavigator1";
            this.tbl_reserveBindingNavigator.Visible = false;
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
            // tbl_reserveBindingNavigatorSaveItem
            // 
            this.tbl_reserveBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_reserveBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_reserveBindingNavigatorSaveItem.Image")));
            this.tbl_reserveBindingNavigatorSaveItem.Name = "tbl_reserveBindingNavigatorSaveItem";
            this.tbl_reserveBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_reserveBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_reserveBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_reserveBindingNavigatorSaveItem_Click);
            // 
            // tbl_reserveTableAdapter
            // 
            this.tbl_reserveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_customerTableAdapter = this.tbl_customerTableAdapter;
            this.tableAdapterManager.tbl_hazinehTableAdapter = null;
            this.tableAdapterManager.tbl_personelTableAdapter = null;
            this.tableAdapterManager.tbl_reserveTableAdapter = this.tbl_reserveTableAdapter;
            this.tableAdapterManager.tbl_roomTableAdapter = this.tbl_roomTableAdapter;
            this.tableAdapterManager.UpdateOrder = hotel.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_roomTableAdapter
            // 
            this.tbl_roomTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 290);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.datestartDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.coderoomDataGridViewTextBoxColumn,
            this.codecustomerDataGridViewTextBoxColumn,
            this.madrakDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.takhfifDataGridViewTextBoxColumn,
            this.paymentsDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.tbl_reserveBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "کد";
            this.code.Name = "code";
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "date_end";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "تاریخ پایان";
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            // 
            // coderoomDataGridViewTextBoxColumn
            // 
            this.coderoomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coderoomDataGridViewTextBoxColumn.DataPropertyName = "code_room";
            this.coderoomDataGridViewTextBoxColumn.HeaderText = "کد اتاق";
            this.coderoomDataGridViewTextBoxColumn.Name = "coderoomDataGridViewTextBoxColumn";
            // 
            // codecustomerDataGridViewTextBoxColumn
            // 
            this.codecustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codecustomerDataGridViewTextBoxColumn.DataPropertyName = "code_customer";
            this.codecustomerDataGridViewTextBoxColumn.HeaderText = "کد مشتری";
            this.codecustomerDataGridViewTextBoxColumn.Name = "codecustomerDataGridViewTextBoxColumn";
            // 
            // madrakDataGridViewTextBoxColumn
            // 
            this.madrakDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madrakDataGridViewTextBoxColumn.DataPropertyName = "madrak";
            this.madrakDataGridViewTextBoxColumn.HeaderText = "مدرک";
            this.madrakDataGridViewTextBoxColumn.Name = "madrakDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "جمع کل";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // takhfifDataGridViewTextBoxColumn
            // 
            this.takhfifDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.takhfifDataGridViewTextBoxColumn.DataPropertyName = "takhfif";
            this.takhfifDataGridViewTextBoxColumn.HeaderText = "takhfif";
            this.takhfifDataGridViewTextBoxColumn.Name = "takhfifDataGridViewTextBoxColumn";
            this.takhfifDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymentsDataGridViewTextBoxColumn
            // 
            this.paymentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentsDataGridViewTextBoxColumn.DataPropertyName = "payments";
            this.paymentsDataGridViewTextBoxColumn.HeaderText = "پرداختی";
            this.paymentsDataGridViewTextBoxColumn.Name = "paymentsDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خالیکردناتاقToolStripMenuItem,
            this.ویرایشاطلاعاتToolStripMenuItem,
            this.حذفاطلاعاتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            // 
            // خالیکردناتاقToolStripMenuItem
            // 
            this.خالیکردناتاقToolStripMenuItem.Name = "خالیکردناتاقToolStripMenuItem";
            this.خالیکردناتاقToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.خالیکردناتاقToolStripMenuItem.Text = "خالی کردن اتاق";
            this.خالیکردناتاقToolStripMenuItem.Click += new System.EventHandler(this.خالیکردناتاقToolStripMenuItem_Click);
            // 
            // ویرایشاطلاعاتToolStripMenuItem
            // 
            this.ویرایشاطلاعاتToolStripMenuItem.Name = "ویرایشاطلاعاتToolStripMenuItem";
            this.ویرایشاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ویرایشاطلاعاتToolStripMenuItem.Text = "ویرایش اطلاعات";
            this.ویرایشاطلاعاتToolStripMenuItem.Click += new System.EventHandler(this.ویرایشاطلاعاتToolStripMenuItem_Click);
            // 
            // حذفاطلاعاتToolStripMenuItem
            // 
            this.حذفاطلاعاتToolStripMenuItem.Name = "حذفاطلاعاتToolStripMenuItem";
            this.حذفاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.حذفاطلاعاتToolStripMenuItem.Text = "حذف اطلاعات";
            this.حذفاطلاعاتToolStripMenuItem.Click += new System.EventHandler(this.حذفاطلاعاتToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(label3);
            this.panel4.Controls.Add(this.RoomComboBox);
            this.panel4.Controls.Add(this.CustomerComboBox);
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.faDatePicker2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(madrakLabel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.madrakTextBox);
            this.panel4.Controls.Add(this.faDatePicker1);
            this.panel4.Controls.Add(this.codeTextBox);
            this.panel4.Controls.Add(codeLabel);
            this.panel4.Controls.Add(code_customerLabel);
            this.panel4.Controls.Add(code_roomLabel);
            this.panel4.Location = new System.Drawing.Point(12, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(946, 134);
            this.panel4.TabIndex = 35;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "price", true));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(31, 35);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 19);
            this.lblPrice.TabIndex = 48;
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.DataSource = this.tblroomBindingSource;
            this.RoomComboBox.DisplayMember = "code";
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(428, 82);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(142, 27);
            this.RoomComboBox.TabIndex = 46;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.DataSource = this.tblroomBindingSource;
            this.CustomerComboBox.DisplayMember = "code";
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(707, 75);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(141, 27);
            this.CustomerComboBox.TabIndex = 45;
            this.CustomerComboBox.ValueMember = "code";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(15, 83);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(98, 29);
            this.saveBtn.TabIndex = 44;
            this.saveBtn.Text = "ثبت";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // faDatePicker2
            // 
            this.faDatePicker2.Location = new System.Drawing.Point(172, 31);
            this.faDatePicker2.Name = "faDatePicker2";
            this.faDatePicker2.Size = new System.Drawing.Size(142, 26);
            this.faDatePicker2.TabIndex = 43;
            this.faDatePicker2.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(327, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(590, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "از تاریخ :";
            // 
            // madrakTextBox
            // 
            this.madrakTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_reserveBindingSource, "madrak", true));
            this.madrakTextBox.Location = new System.Drawing.Point(172, 81);
            this.madrakTextBox.Name = "madrakTextBox";
            this.madrakTextBox.Size = new System.Drawing.Size(142, 26);
            this.madrakTextBox.TabIndex = 40;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(428, 31);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(142, 26);
            this.faDatePicker1.TabIndex = 34;
            this.faDatePicker1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_reserveBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(707, 29);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(142, 26);
            this.codeTextBox.TabIndex = 36;
            // 
            // formReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(991, 631);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_reserveBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formReserve";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم رزرو اتاق";
            this.Activated += new System.EventHandler(this.formReserve_Activated);
            this.Load += new System.EventHandler(this.formReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingNavigator)).EndInit();
            this.tbl_reserveBindingNavigator.ResumeLayout(false);
            this.tbl_reserveBindingNavigator.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tbl_reserveBindingSource;
        private hotelDataSetTableAdapters.tbl_reserveTableAdapter tbl_reserveTableAdapter;
        private hotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_reserveBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_reserveBindingNavigatorSaveItem;
        private hotelDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private hotelDataSetTableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter;
        private System.Windows.Forms.BindingSource tblroomBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Button saveBtn;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox madrakTextBox;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خالیکردناتاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox codeRezerveTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.TextBox baghiMandehTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madrakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takhfifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentsDataGridViewTextBoxColumn;
    }
}