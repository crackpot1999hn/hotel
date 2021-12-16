namespace hotel
{
    partial class formHazineh
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
            System.Windows.Forms.Label code_factorLabel;
            System.Windows.Forms.Label code_personelLabel;
            System.Windows.Forms.Label textLabel;
            System.Windows.Forms.Label foroshandehLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descLabel;
            System.Windows.Forms.Label paymentsLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHazineh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.tbl_hazinehBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
            this.paymentsTextBox = new System.Windows.Forms.TextBox();
            this.codePersonelComboBox = new System.Windows.Forms.ComboBox();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azforoshandehTextBox = new System.Windows.Forms.TextBox();
            this.sharhTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.code_factorTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.tbl_hazinehBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_hazinehBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPayments = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.azForoSearchTextBox = new System.Windows.Forms.TextBox();
            this.FacSearchTextBox = new System.Windows.Forms.TextBox();
            this.tbl_hazinehDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_hazinehTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_hazinehTableAdapter();
            this.tableAdapterManager = new hotel.hotelDataSetTableAdapters.TableAdapterManager();
            this.tbl_personelTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_personelTableAdapter();
            this.personelSearchTextBox = new System.Windows.Forms.TextBox();
            codeLabel = new System.Windows.Forms.Label();
            code_factorLabel = new System.Windows.Forms.Label();
            code_personelLabel = new System.Windows.Forms.Label();
            textLabel = new System.Windows.Forms.Label();
            foroshandehLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descLabel = new System.Windows.Forms.Label();
            paymentsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hazinehBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hazinehBindingNavigator)).BeginInit();
            this.tbl_hazinehBindingNavigator.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hazinehDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codeLabel.Location = new System.Drawing.Point(877, 28);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 22);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد :";
            // 
            // code_factorLabel
            // 
            code_factorLabel.AutoSize = true;
            code_factorLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            code_factorLabel.Location = new System.Drawing.Point(855, 73);
            code_factorLabel.Name = "code_factorLabel";
            code_factorLabel.Size = new System.Drawing.Size(80, 22);
            code_factorLabel.TabIndex = 2;
            code_factorLabel.Text = "کد فاکتور :";
            // 
            // code_personelLabel
            // 
            code_personelLabel.AutoSize = true;
            code_personelLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            code_personelLabel.Location = new System.Drawing.Point(854, 118);
            code_personelLabel.Name = "code_personelLabel";
            code_personelLabel.Size = new System.Drawing.Size(83, 22);
            code_personelLabel.TabIndex = 4;
            code_personelLabel.Text = "کد شخص :";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textLabel.Location = new System.Drawing.Point(586, 28);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(53, 22);
            textLabel.TabIndex = 6;
            textLabel.Text = "شرح :";
            // 
            // foroshandehLabel
            // 
            foroshandehLabel.AutoSize = true;
            foroshandehLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foroshandehLabel.Location = new System.Drawing.Point(566, 72);
            foroshandehLabel.Name = "foroshandehLabel";
            foroshandehLabel.Size = new System.Drawing.Size(93, 22);
            foroshandehLabel.TabIndex = 8;
            foroshandehLabel.Text = "از فروشنده :";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(588, 116);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(49, 22);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "جمع :";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descLabel.Location = new System.Drawing.Point(283, 114);
            descLabel.Name = "descLabel";
            descLabel.Size = new System.Drawing.Size(82, 22);
            descLabel.TabIndex = 6;
            descLabel.Text = "توضیحات :";
            // 
            // paymentsLabel
            // 
            paymentsLabel.AutoSize = true;
            paymentsLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paymentsLabel.Location = new System.Drawing.Point(263, 71);
            paymentsLabel.Name = "paymentsLabel";
            paymentsLabel.Size = new System.Drawing.Size(72, 22);
            paymentsLabel.TabIndex = 12;
            paymentsLabel.Text = "پرداختی :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(810, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 22);
            label1.TabIndex = 4;
            label1.Text = "کد فاکتور :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(610, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 22);
            label2.TabIndex = 6;
            label2.Text = "از :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(361, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 22);
            label3.TabIndex = 8;
            label3.Text = "کد شخص :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.descTextBox);
            this.panel1.Controls.Add(descLabel);
            this.panel1.Controls.Add(paymentsLabel);
            this.panel1.Controls.Add(this.paymentsTextBox);
            this.panel1.Controls.Add(this.codePersonelComboBox);
            this.panel1.Controls.Add(foroshandehLabel);
            this.panel1.Controls.Add(this.azforoshandehTextBox);
            this.panel1.Controls.Add(textLabel);
            this.panel1.Controls.Add(priceLabel);
            this.panel1.Controls.Add(this.sharhTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(code_personelLabel);
            this.panel1.Controls.Add(code_factorLabel);
            this.panel1.Controls.Add(this.code_factorTextBox);
            this.panel1.Controls.Add(codeLabel);
            this.panel1.Controls.Add(this.codeTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 205);
            this.panel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(33, 149);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 38);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "ثبت";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // descTextBox
            // 
            this.descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_hazinehBindingSource, "desc", true));
            this.descTextBox.Location = new System.Drawing.Point(117, 108);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(140, 26);
            this.descTextBox.TabIndex = 7;
            // 
            // tbl_hazinehBindingSource
            // 
            this.tbl_hazinehBindingSource.DataMember = "tbl_hazineh";
            this.tbl_hazinehBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTextBox
            // 
            this.paymentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_hazinehBindingSource, "payments", true));
            this.paymentsTextBox.Location = new System.Drawing.Point(117, 66);
            this.paymentsTextBox.Name = "paymentsTextBox";
            this.paymentsTextBox.Size = new System.Drawing.Size(140, 26);
            this.paymentsTextBox.TabIndex = 13;
            // 
            // codePersonelComboBox
            // 
            this.codePersonelComboBox.DataSource = this.tblpersonelBindingSource;
            this.codePersonelComboBox.DisplayMember = "code";
            this.codePersonelComboBox.FormattingEnabled = true;
            this.codePersonelComboBox.Location = new System.Drawing.Point(701, 113);
            this.codePersonelComboBox.Name = "codePersonelComboBox";
            this.codePersonelComboBox.Size = new System.Drawing.Size(140, 27);
            this.codePersonelComboBox.TabIndex = 10;
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.hotelDataSet;
            // 
            // azforoshandehTextBox
            // 
            this.azforoshandehTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_hazinehBindingSource, "foroshandeh", true));
            this.azforoshandehTextBox.Location = new System.Drawing.Point(406, 65);
            this.azforoshandehTextBox.Name = "azforoshandehTextBox";
            this.azforoshandehTextBox.Size = new System.Drawing.Size(140, 26);
            this.azforoshandehTextBox.TabIndex = 9;
            // 
            // sharhTextBox
            // 
            this.sharhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_hazinehBindingSource, "text", true));
            this.sharhTextBox.Location = new System.Drawing.Point(117, 25);
            this.sharhTextBox.Name = "sharhTextBox";
            this.sharhTextBox.Size = new System.Drawing.Size(429, 26);
            this.sharhTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_hazinehBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(406, 114);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(140, 26);
            this.priceTextBox.TabIndex = 3;
            // 
            // code_factorTextBox
            // 
            this.code_factorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_hazinehBindingSource, "code_factor", true));
            this.code_factorTextBox.Location = new System.Drawing.Point(701, 69);
            this.code_factorTextBox.Name = "code_factorTextBox";
            this.code_factorTextBox.Size = new System.Drawing.Size(140, 26);
            this.code_factorTextBox.TabIndex = 3;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_hazinehBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(701, 25);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(140, 26);
            this.codeTextBox.TabIndex = 1;
            // 
            // tbl_hazinehBindingNavigator
            // 
            this.tbl_hazinehBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_hazinehBindingNavigator.BindingSource = this.tbl_hazinehBindingSource;
            this.tbl_hazinehBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_hazinehBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_hazinehBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_hazinehBindingNavigatorSaveItem});
            this.tbl_hazinehBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_hazinehBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_hazinehBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_hazinehBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_hazinehBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_hazinehBindingNavigator.Name = "tbl_hazinehBindingNavigator";
            this.tbl_hazinehBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_hazinehBindingNavigator.Size = new System.Drawing.Size(1065, 25);
            this.tbl_hazinehBindingNavigator.TabIndex = 1;
            this.tbl_hazinehBindingNavigator.Text = "bindingNavigator1";
            this.tbl_hazinehBindingNavigator.Visible = false;
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
            // tbl_hazinehBindingNavigatorSaveItem
            // 
            this.tbl_hazinehBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_hazinehBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_hazinehBindingNavigatorSaveItem.Image")));
            this.tbl_hazinehBindingNavigatorSaveItem.Name = "tbl_hazinehBindingNavigatorSaveItem";
            this.tbl_hazinehBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_hazinehBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_hazinehBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_hazinehBindingNavigatorSaveItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.personelSearchTextBox);
            this.panel2.Controls.Add(this.lblPayments);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.azForoSearchTextBox);
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(this.FacSearchTextBox);
            this.panel2.Controls.Add(this.tbl_hazinehDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 366);
            this.panel2.TabIndex = 6;
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(84, 329);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(0, 19);
            this.lblPayments.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "پرداختی :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(257, 328);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 22);
            this.lblTotal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "جمع کل :";
            // 
            // azForoSearchTextBox
            // 
            this.azForoSearchTextBox.Location = new System.Drawing.Point(490, 18);
            this.azForoSearchTextBox.Name = "azForoSearchTextBox";
            this.azForoSearchTextBox.Size = new System.Drawing.Size(106, 26);
            this.azForoSearchTextBox.TabIndex = 7;
            this.azForoSearchTextBox.TextChanged += new System.EventHandler(this.azForoSearchTextBox_TextChanged);
            // 
            // FacSearchTextBox
            // 
            this.FacSearchTextBox.Location = new System.Drawing.Point(690, 19);
            this.FacSearchTextBox.Name = "FacSearchTextBox";
            this.FacSearchTextBox.Size = new System.Drawing.Size(106, 26);
            this.FacSearchTextBox.TabIndex = 5;
            this.FacSearchTextBox.TextChanged += new System.EventHandler(this.FacSearchTextBox_TextChanged);
            // 
            // tbl_hazinehDataGridView
            // 
            this.tbl_hazinehDataGridView.AutoGenerateColumns = false;
            this.tbl_hazinehDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_hazinehDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tbl_hazinehDataGridView.DataSource = this.tbl_hazinehBindingSource;
            this.tbl_hazinehDataGridView.Location = new System.Drawing.Point(3, 66);
            this.tbl_hazinehDataGridView.Name = "tbl_hazinehDataGridView";
            this.tbl_hazinehDataGridView.Size = new System.Drawing.Size(947, 246);
            this.tbl_hazinehDataGridView.TabIndex = 0;
            this.tbl_hazinehDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.tbl_hazinehDataGridView_UserDeletingRow);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "code_factor";
            this.dataGridViewTextBoxColumn2.HeaderText = "کد فاکتور";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "code_personel";
            this.dataGridViewTextBoxColumn3.HeaderText = "کد شخص";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "text";
            this.dataGridViewTextBoxColumn4.HeaderText = "شرح";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "foroshandeh";
            this.dataGridViewTextBoxColumn5.HeaderText = "از";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "جمع";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "flag";
            this.dataGridViewTextBoxColumn7.HeaderText = "نوع";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "payments";
            this.dataGridViewTextBoxColumn8.HeaderText = "پرداختی";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "desc";
            this.dataGridViewTextBoxColumn9.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // tbl_hazinehTableAdapter
            // 
            this.tbl_hazinehTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_customerTableAdapter = null;
            this.tableAdapterManager.tbl_hazinehTableAdapter = this.tbl_hazinehTableAdapter;
            this.tableAdapterManager.tbl_personelTableAdapter = null;
            this.tableAdapterManager.tbl_reserveTableAdapter = null;
            this.tableAdapterManager.tbl_roomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hotel.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelSearchTextBox
            // 
            this.personelSearchTextBox.Location = new System.Drawing.Point(239, 20);
            this.personelSearchTextBox.Name = "personelSearchTextBox";
            this.personelSearchTextBox.Size = new System.Drawing.Size(106, 26);
            this.personelSearchTextBox.TabIndex = 16;
            // 
            // formHazineh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbl_hazinehBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formHazineh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ثبت هزینه ها";
            this.Activated += new System.EventHandler(this.formHazineh_Activated);
            this.Load += new System.EventHandler(this.formHazineh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hazinehBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hazinehBindingNavigator)).EndInit();
            this.tbl_hazinehBindingNavigator.ResumeLayout(false);
            this.tbl_hazinehBindingNavigator.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hazinehDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tbl_hazinehBindingSource;
        private hotelDataSetTableAdapters.tbl_hazinehTableAdapter tbl_hazinehTableAdapter;
        private hotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_hazinehBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_hazinehBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox code_factorTextBox;
        private System.Windows.Forms.TextBox azforoshandehTextBox;
        private System.Windows.Forms.TextBox sharhTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox paymentsTextBox;
        private System.Windows.Forms.ComboBox codePersonelComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox azForoSearchTextBox;
        private System.Windows.Forms.TextBox FacSearchTextBox;
        private System.Windows.Forms.DataGridView tbl_hazinehDataGridView;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.TextBox personelSearchTextBox;
    }
}