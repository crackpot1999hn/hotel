namespace hotel
{
    partial class formUpdateReserve
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label madrakLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label code_customerLabel;
            System.Windows.Forms.Label code_roomLabel;
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.tblreserveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.tblroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.madrakTextBox = new System.Windows.Forms.TextBox();
            this.tblreserveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateEndTextBox = new System.Windows.Forms.TextBox();
            this.dateStartTextBox = new System.Windows.Forms.TextBox();
            this.tbl_reserveTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_reserveTableAdapter();
            this.tbl_customerTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_customerTableAdapter();
            this.tbl_roomTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_roomTableAdapter();
            label4 = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            madrakLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            code_customerLabel = new System.Windows.Forms.Label();
            code_roomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblreserveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreserveBindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(158, 127);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 22);
            label4.TabIndex = 55;
            label4.Text = "جمع کل حساب :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            totalLabel.Location = new System.Drawing.Point(163, 181);
            totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(103, 22);
            totalLabel.TabIndex = 50;
            totalLabel.Text = "مبلغ پرداختی :";
            // 
            // madrakLabel
            // 
            madrakLabel.AutoSize = true;
            madrakLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            madrakLabel.Location = new System.Drawing.Point(491, 174);
            madrakLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            madrakLabel.Name = "madrakLabel";
            madrakLabel.Size = new System.Drawing.Size(59, 22);
            madrakLabel.TabIndex = 39;
            madrakLabel.Text = "مدرک :";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            codeLabel.Location = new System.Drawing.Point(502, 12);
            codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 22);
            codeLabel.TabIndex = 35;
            codeLabel.Text = "کد :";
            // 
            // code_customerLabel
            // 
            code_customerLabel.AutoSize = true;
            code_customerLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            code_customerLabel.Location = new System.Drawing.Point(487, 66);
            code_customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            code_customerLabel.Name = "code_customerLabel";
            code_customerLabel.Size = new System.Drawing.Size(67, 22);
            code_customerLabel.TabIndex = 38;
            code_customerLabel.Text = "مشتری :";
            // 
            // code_roomLabel
            // 
            code_roomLabel.AutoSize = true;
            code_roomLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            code_roomLabel.Location = new System.Drawing.Point(494, 120);
            code_roomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            code_roomLabel.Name = "code_roomLabel";
            code_roomLabel.Size = new System.Drawing.Size(52, 22);
            code_roomLabel.TabIndex = 37;
            code_roomLabel.Text = " اتاق :";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblreserveBindingSource, "total", true));
            this.TotaltextBox.Location = new System.Drawing.Point(27, 125);
            this.TotaltextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(123, 21);
            this.TotaltextBox.TabIndex = 56;
            // 
            // tblreserveBindingSource
            // 
            this.tblreserveBindingSource.DataMember = "tbl_reserve";
            this.tblreserveBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblreserveBindingSource, "payments", true));
            this.paymentTextBox.Location = new System.Drawing.Point(27, 179);
            this.paymentTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(123, 21);
            this.paymentTextBox.TabIndex = 51;
            this.paymentTextBox.Text = "0";
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "code", true));
            this.RoomComboBox.DataSource = this.tblroomBindingSource;
            this.RoomComboBox.DisplayMember = "code";
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(345, 122);
            this.RoomComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(123, 23);
            this.RoomComboBox.TabIndex = 46;
            this.RoomComboBox.ValueMember = "code";
            // 
            // tblroomBindingSource
            // 
            this.tblroomBindingSource.DataMember = "tbl_room";
            this.tblroomBindingSource.DataSource = this.hotelDataSet;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.DataSource = this.tblcustomerBindingSource;
            this.CustomerComboBox.DisplayMember = "code";
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(345, 67);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(123, 23);
            this.CustomerComboBox.TabIndex = 45;
            this.CustomerComboBox.ValueMember = "code";
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tbl_customer";
            this.tblcustomerBindingSource.DataSource = this.hotelDataSet;
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.editBtn.Location = new System.Drawing.Point(113, 240);
            this.editBtn.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(179, 33);
            this.editBtn.TabIndex = 44;
            this.editBtn.Text = "ویرایش";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(180, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(178, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "از تاریخ :";
            // 
            // madrakTextBox
            // 
            this.madrakTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblreserveBindingSource1, "madrak", true));
            this.madrakTextBox.Location = new System.Drawing.Point(345, 177);
            this.madrakTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.madrakTextBox.Name = "madrakTextBox";
            this.madrakTextBox.Size = new System.Drawing.Size(123, 21);
            this.madrakTextBox.TabIndex = 40;
            // 
            // tblreserveBindingSource1
            // 
            this.tblreserveBindingSource1.DataMember = "tbl_reserve";
            this.tblreserveBindingSource1.DataSource = this.hotelDataSet;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblreserveBindingSource1, "code", true));
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Location = new System.Drawing.Point(345, 14);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(123, 21);
            this.codeTextBox.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.dateEndTextBox);
            this.panel4.Controls.Add(this.dateStartTextBox);
            this.panel4.Controls.Add(this.TotaltextBox);
            this.panel4.Controls.Add(label4);
            this.panel4.Controls.Add(totalLabel);
            this.panel4.Controls.Add(this.paymentTextBox);
            this.panel4.Controls.Add(this.RoomComboBox);
            this.panel4.Controls.Add(this.CustomerComboBox);
            this.panel4.Controls.Add(this.editBtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(madrakLabel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.madrakTextBox);
            this.panel4.Controls.Add(this.codeTextBox);
            this.panel4.Controls.Add(codeLabel);
            this.panel4.Controls.Add(code_customerLabel);
            this.panel4.Controls.Add(code_roomLabel);
            this.panel4.Location = new System.Drawing.Point(5, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 292);
            this.panel4.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 31);
            this.button1.TabIndex = 59;
            this.button1.Text = "بستن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateEndTextBox
            // 
            this.dateEndTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblreserveBindingSource, "date_end", true));
            this.dateEndTextBox.Location = new System.Drawing.Point(27, 74);
            this.dateEndTextBox.Name = "dateEndTextBox";
            this.dateEndTextBox.Size = new System.Drawing.Size(123, 21);
            this.dateEndTextBox.TabIndex = 58;
            // 
            // dateStartTextBox
            // 
            this.dateStartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblreserveBindingSource, "date_start", true));
            this.dateStartTextBox.Location = new System.Drawing.Point(27, 21);
            this.dateStartTextBox.Name = "dateStartTextBox";
            this.dateStartTextBox.Size = new System.Drawing.Size(123, 21);
            this.dateStartTextBox.TabIndex = 57;
            // 
            // tbl_reserveTableAdapter
            // 
            this.tbl_reserveTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_roomTableAdapter
            // 
            this.tbl_roomTableAdapter.ClearBeforeFill = true;
            // 
            // formUpdateReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(607, 319);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formUpdateReserve";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUpdateReserve";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.formUpdateReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblreserveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreserveBindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox madrakTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Panel panel4;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tblreserveBindingSource;
        private hotelDataSetTableAdapters.tbl_reserveTableAdapter tbl_reserveTableAdapter;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private hotelDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private System.Windows.Forms.BindingSource tblroomBindingSource;
        private hotelDataSetTableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter;
        private System.Windows.Forms.BindingSource tblreserveBindingSource1;
        private System.Windows.Forms.TextBox dateEndTextBox;
        private System.Windows.Forms.TextBox dateStartTextBox;
        private System.Windows.Forms.Button button1;
    }
}