namespace hotel
{
    partial class formUpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpdateCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.textMobile = new System.Windows.Forms.TextBox();
            this.tbl_customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFamily = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textCodemeli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingNavigator)).BeginInit();
            this.tbl_customerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.textMobile);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textFamily);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Controls.Add(this.textCodemeli);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 303);
            this.panel1.TabIndex = 0;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.Control;
            this.editBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(123, 245);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(152, 38);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "ویرایش";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // textMobile
            // 
            this.textMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_customerBindingSource, "mobile", true));
            this.textMobile.Location = new System.Drawing.Point(38, 79);
            this.textMobile.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textMobile.Name = "textMobile";
            this.textMobile.Size = new System.Drawing.Size(123, 23);
            this.textMobile.TabIndex = 12;
            // 
            // tbl_customerBindingSource
            // 
            this.tbl_customerBindingSource.DataMember = "tbl_customer";
            this.tbl_customerBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "تلفن :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "موبایل :";
            // 
            // textPhone
            // 
            this.textPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_customerBindingSource, "phone", true));
            this.textPhone.Location = new System.Drawing.Point(38, 22);
            this.textPhone.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(123, 23);
            this.textPhone.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "نام :";
            // 
            // textFamily
            // 
            this.textFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_customerBindingSource, "family", true));
            this.textFamily.Location = new System.Drawing.Point(271, 199);
            this.textFamily.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textFamily.Name = "textFamily";
            this.textFamily.Size = new System.Drawing.Size(155, 23);
            this.textFamily.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "نام خانوادگی :";
            // 
            // textName
            // 
            this.textName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_customerBindingSource, "name", true));
            this.textName.Location = new System.Drawing.Point(271, 140);
            this.textName.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(155, 23);
            this.textName.TabIndex = 8;
            // 
            // textCode
            // 
            this.textCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_customerBindingSource, "code", true));
            this.textCode.Enabled = false;
            this.textCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textCode.Location = new System.Drawing.Point(271, 21);
            this.textCode.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(155, 23);
            this.textCode.TabIndex = 2;
            // 
            // textCodemeli
            // 
            this.textCodemeli.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_customerBindingSource, "code_meli", true));
            this.textCodemeli.Location = new System.Drawing.Point(271, 80);
            this.textCodemeli.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textCodemeli.Name = "textCodemeli";
            this.textCodemeli.Size = new System.Drawing.Size(155, 23);
            this.textCodemeli.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "کد ملی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "کد مشتری :";
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
            this.tbl_customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_customerBindingNavigator.Size = new System.Drawing.Size(804, 27);
            this.tbl_customerBindingNavigator.TabIndex = 1;
            this.tbl_customerBindingNavigator.Text = "bindingNavigator1";
            this.tbl_customerBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbl_customerBindingNavigatorSaveItem
            // 
            this.tbl_customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_customerBindingNavigatorSaveItem.Image")));
            this.tbl_customerBindingNavigatorSaveItem.Name = "tbl_customerBindingNavigatorSaveItem";
            this.tbl_customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.tbl_customerBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_customerBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "بستن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(583, 350);
            this.Controls.Add(this.tbl_customerBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formUpdateCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUpdateCustomer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.formUpdateCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_customerBindingNavigator)).EndInit();
            this.tbl_customerBindingNavigator.ResumeLayout(false);
            this.tbl_customerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textCodemeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Button editBtn;
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
        private System.Windows.Forms.Button button1;
    }
}