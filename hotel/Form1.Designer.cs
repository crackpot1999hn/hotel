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
            this.یToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اتاقهایخالیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتمشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblPer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingNavigator)).BeginInit();
            this.tbl_roomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.اطلاعاتمشتریانToolStripMenuItem,
            this.رزرواتاقToolStripMenuItem,
            this.یToolStripMenuItem,
            this.تنظیماتToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
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
            // یToolStripMenuItem
            // 
            this.یToolStripMenuItem.Name = "یToolStripMenuItem";
            this.یToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.یToolStripMenuItem.Text = "هزینه ها";
            this.یToolStripMenuItem.Click += new System.EventHandler(this.یToolStripMenuItem_Click);
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اتاقهایخالیToolStripMenuItem,
            this.اطلاعاتمشتریToolStripMenuItem});
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.تنظیماتToolStripMenuItem.Text = "گزارشات";
            // 
            // اتاقهایخالیToolStripMenuItem
            // 
            this.اتاقهایخالیToolStripMenuItem.Name = "اتاقهایخالیToolStripMenuItem";
            this.اتاقهایخالیToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.اتاقهایخالیToolStripMenuItem.Text = "اتاق های خالی";
            this.اتاقهایخالیToolStripMenuItem.Click += new System.EventHandler(this.اتاقهایخالیToolStripMenuItem_Click);
            // 
            // اطلاعاتمشتریToolStripMenuItem
            // 
            this.اطلاعاتمشتریToolStripMenuItem.Name = "اطلاعاتمشتریToolStripMenuItem";
            this.اطلاعاتمشتریToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.اطلاعاتمشتریToolStripMenuItem.Text = "لیست صورت وضعیت";
            this.اطلاعاتمشتریToolStripMenuItem.Click += new System.EventHandler(this.اطلاعاتمشتریToolStripMenuItem_Click);
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
            this.tbl_roomBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.tbl_roomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_roomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_roomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_roomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_roomBindingNavigator.Name = "tbl_roomBindingNavigator";
            this.tbl_roomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_roomBindingNavigator.Size = new System.Drawing.Size(941, 25);
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
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(765, 171);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(0, 18);
            this.lblPer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(832, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "سطح دسترسی :";
            // 
            // lblUsLogin
            // 
            this.lblUsLogin.AutoSize = true;
            this.lblUsLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsLogin.Location = new System.Drawing.Point(765, 109);
            this.lblUsLogin.Name = "lblUsLogin";
            this.lblUsLogin.Size = new System.Drawing.Size(0, 18);
            this.lblUsLogin.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(828, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "کاربر وارد شده :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(941, 547);
            this.ControlBox = false;
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbl_roomBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت هتل";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingNavigator)).EndInit();
            this.tbl_roomBindingNavigator.ResumeLayout(false);
            this.tbl_roomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اتاقهایخالیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتمشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem یToolStripMenuItem;
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
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsLogin;
        private System.Windows.Forms.Label label1;
    }
}

