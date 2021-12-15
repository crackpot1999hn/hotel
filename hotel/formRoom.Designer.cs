namespace hotel
{
    partial class formRoom
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label emkanatLabel;
            System.Windows.Forms.Label descLabel;
            System.Windows.Forms.Label number_flatLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.number_flatTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.emkanatTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
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
            this.tbl_roomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خالیکردنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.searchFlatTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCodeTextBox = new System.Windows.Forms.TextBox();
            this.tbl_roomTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_roomTableAdapter();
            this.tableAdapterManager = new hotel.hotelDataSetTableAdapters.TableAdapterManager();
            codeLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            emkanatLabel = new System.Windows.Forms.Label();
            descLabel = new System.Windows.Forms.Label();
            number_flatLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingNavigator)).BeginInit();
            this.tbl_roomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            codeLabel.Location = new System.Drawing.Point(758, 29);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 22);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد اتاق :";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            areaLabel.Location = new System.Drawing.Point(444, 26);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(68, 22);
            areaLabel.TabIndex = 4;
            areaLabel.Text = "مساحت :";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            priceLabel.Location = new System.Drawing.Point(452, 80);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(53, 22);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "قیمت :";
            // 
            // emkanatLabel
            // 
            emkanatLabel.AutoSize = true;
            emkanatLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            emkanatLabel.Location = new System.Drawing.Point(757, 125);
            emkanatLabel.Name = "emkanatLabel";
            emkanatLabel.Size = new System.Drawing.Size(69, 22);
            emkanatLabel.TabIndex = 8;
            emkanatLabel.Text = "امکانات :";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            descLabel.Location = new System.Drawing.Point(189, 29);
            descLabel.Name = "descLabel";
            descLabel.Size = new System.Drawing.Size(82, 22);
            descLabel.TabIndex = 10;
            descLabel.Text = "توضیحات :";
            // 
            // number_flatLabel1
            // 
            number_flatLabel1.AutoSize = true;
            number_flatLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            number_flatLabel1.Location = new System.Drawing.Point(753, 77);
            number_flatLabel1.Name = "number_flatLabel1";
            number_flatLabel1.Size = new System.Drawing.Size(76, 22);
            number_flatLabel1.TabIndex = 13;
            number_flatLabel1.Text = "چند تخت :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(number_flatLabel1);
            this.panel1.Controls.Add(this.number_flatTextBox);
            this.panel1.Controls.Add(descLabel);
            this.panel1.Controls.Add(this.descTextBox);
            this.panel1.Controls.Add(emkanatLabel);
            this.panel1.Controls.Add(this.emkanatTextBox);
            this.panel1.Controls.Add(priceLabel);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(areaLabel);
            this.panel1.Controls.Add(this.areaTextBox);
            this.panel1.Controls.Add(codeLabel);
            this.panel1.Controls.Add(this.codeTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 195);
            this.panel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(43, 135);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(140, 31);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "ثبت";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // number_flatTextBox
            // 
            this.number_flatTextBox.Location = new System.Drawing.Point(600, 74);
            this.number_flatTextBox.Name = "number_flatTextBox";
            this.number_flatTextBox.Size = new System.Drawing.Size(142, 26);
            this.number_flatTextBox.TabIndex = 14;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(13, 20);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(170, 82);
            this.descTextBox.TabIndex = 11;
            // 
            // emkanatTextBox
            // 
            this.emkanatTextBox.Location = new System.Drawing.Point(294, 122);
            this.emkanatTextBox.Name = "emkanatTextBox";
            this.emkanatTextBox.Size = new System.Drawing.Size(448, 26);
            this.emkanatTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(294, 77);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(142, 26);
            this.priceTextBox.TabIndex = 7;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(294, 22);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(142, 26);
            this.areaTextBox.TabIndex = 5;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(600, 26);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(142, 26);
            this.codeTextBox.TabIndex = 1;
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
            this.tbl_roomBindingNavigator.Size = new System.Drawing.Size(912, 25);
            this.tbl_roomBindingNavigator.TabIndex = 1;
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
            // tbl_roomDataGridView
            // 
            this.tbl_roomDataGridView.AutoGenerateColumns = false;
            this.tbl_roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tbl_roomDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.tbl_roomDataGridView.DataSource = this.tbl_roomBindingSource;
            this.tbl_roomDataGridView.Location = new System.Drawing.Point(27, 80);
            this.tbl_roomDataGridView.Name = "tbl_roomDataGridView";
            this.tbl_roomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_roomDataGridView.Size = new System.Drawing.Size(810, 220);
            this.tbl_roomDataGridView.TabIndex = 0;
            this.tbl_roomDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.tbl_roomDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "code";
            this.dataGridViewTextBoxColumn1.HeaderText = "کد";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "number_flat";
            this.dataGridViewTextBoxColumn2.HeaderText = "تعداد تخت";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "area";
            this.dataGridViewTextBoxColumn3.HeaderText = "مساحت";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "قیمت";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "emkanat";
            this.dataGridViewTextBoxColumn5.HeaderText = "امکانات";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "desc";
            this.dataGridViewTextBoxColumn6.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "flag";
            this.dataGridViewTextBoxColumn7.HeaderText = "وضعیت";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشاطلاعاتToolStripMenuItem,
            this.حذفاطلاعاتToolStripMenuItem,
            this.خالیکردنToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
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
            // خالیکردنToolStripMenuItem
            // 
            this.خالیکردنToolStripMenuItem.Name = "خالیکردنToolStripMenuItem";
            this.خالیکردنToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.خالیکردنToolStripMenuItem.Text = "خالی کردن اتاق";
            this.خالیکردنToolStripMenuItem.Click += new System.EventHandler(this.خالیکردنToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.searchFlatTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.searchPriceTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchCodeTextBox);
            this.panel2.Controls.Add(this.tbl_roomDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 311);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(179, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "جستجو با تعداد تخت ";
            // 
            // searchFlatTextBox
            // 
            this.searchFlatTextBox.Location = new System.Drawing.Point(44, 19);
            this.searchFlatTextBox.Name = "searchFlatTextBox";
            this.searchFlatTextBox.Size = new System.Drawing.Size(112, 26);
            this.searchFlatTextBox.TabIndex = 5;
            this.searchFlatTextBox.TextChanged += new System.EventHandler(this.searchFlatTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(468, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "جستجو با قیمت";
            // 
            // searchPriceTextBox
            // 
            this.searchPriceTextBox.Location = new System.Drawing.Point(333, 19);
            this.searchPriceTextBox.Name = "searchPriceTextBox";
            this.searchPriceTextBox.Size = new System.Drawing.Size(112, 26);
            this.searchPriceTextBox.TabIndex = 3;
            this.searchPriceTextBox.TextChanged += new System.EventHandler(this.searchPriceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(723, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "جستجو با کد اتاق";
            // 
            // searchCodeTextBox
            // 
            this.searchCodeTextBox.Location = new System.Drawing.Point(588, 19);
            this.searchCodeTextBox.Name = "searchCodeTextBox";
            this.searchCodeTextBox.Size = new System.Drawing.Size(112, 26);
            this.searchCodeTextBox.TabIndex = 1;
            this.searchCodeTextBox.TextChanged += new System.EventHandler(this.searchCodeTextBox_TextChanged);
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
            // formRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_roomBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ثبت اطلاعات اتاق ها";
            this.Activated += new System.EventHandler(this.formRoom_Activated);
            this.Load += new System.EventHandler(this.formRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingNavigator)).EndInit();
            this.tbl_roomBindingNavigator.ResumeLayout(false);
            this.tbl_roomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridView tbl_roomDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox emkanatTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox number_flatTextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchFlatTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchPriceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خالیکردنToolStripMenuItem;
    }
}