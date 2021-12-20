namespace hotel
{
    partial class formUpdateRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.number_flatTextBox = new System.Windows.Forms.TextBox();
            this.tblroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.emkanatTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.tbl_roomTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_roomTableAdapter();
            codeLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            emkanatLabel = new System.Windows.Forms.Label();
            descLabel = new System.Windows.Forms.Label();
            number_flatLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            codeLabel.Location = new System.Drawing.Point(481, 19);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 22);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد اتاق :";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            areaLabel.Location = new System.Drawing.Point(160, 16);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(68, 22);
            areaLabel.TabIndex = 4;
            areaLabel.Text = "مساحت :";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            priceLabel.Location = new System.Drawing.Point(168, 70);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(53, 22);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "قیمت :";
            // 
            // emkanatLabel
            // 
            emkanatLabel.AutoSize = true;
            emkanatLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            emkanatLabel.Location = new System.Drawing.Point(480, 115);
            emkanatLabel.Name = "emkanatLabel";
            emkanatLabel.Size = new System.Drawing.Size(69, 22);
            emkanatLabel.TabIndex = 8;
            emkanatLabel.Text = "امکانات :";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            descLabel.Location = new System.Drawing.Point(473, 163);
            descLabel.Name = "descLabel";
            descLabel.Size = new System.Drawing.Size(82, 22);
            descLabel.TabIndex = 10;
            descLabel.Text = "توضیحات :";
            // 
            // number_flatLabel1
            // 
            number_flatLabel1.AutoSize = true;
            number_flatLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            number_flatLabel1.Location = new System.Drawing.Point(476, 67);
            number_flatLabel1.Name = "number_flatLabel1";
            number_flatLabel1.Size = new System.Drawing.Size(76, 22);
            number_flatLabel1.TabIndex = 13;
            number_flatLabel1.Text = "چند تخت :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.editBtn);
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
            this.panel1.Location = new System.Drawing.Point(38, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 282);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(458, 205);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(108, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "اتاق خالی است";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "بستن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.editBtn.Location = new System.Drawing.Point(168, 222);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(140, 31);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "ویرایش";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // number_flatTextBox
            // 
            this.number_flatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "number_flat", true));
            this.number_flatTextBox.Location = new System.Drawing.Point(349, 67);
            this.number_flatTextBox.Name = "number_flatTextBox";
            this.number_flatTextBox.Size = new System.Drawing.Size(114, 23);
            this.number_flatTextBox.TabIndex = 14;
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
            // descTextBox
            // 
            this.descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "desc", true));
            this.descTextBox.Location = new System.Drawing.Point(10, 163);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(448, 23);
            this.descTextBox.TabIndex = 11;
            // 
            // emkanatTextBox
            // 
            this.emkanatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "emkanat", true));
            this.emkanatTextBox.Location = new System.Drawing.Point(10, 115);
            this.emkanatTextBox.Name = "emkanatTextBox";
            this.emkanatTextBox.Size = new System.Drawing.Size(448, 23);
            this.emkanatTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(43, 70);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(114, 23);
            this.priceTextBox.TabIndex = 7;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "area", true));
            this.areaTextBox.Location = new System.Drawing.Point(43, 15);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(114, 23);
            this.areaTextBox.TabIndex = 5;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "code", true));
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Location = new System.Drawing.Point(349, 19);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(114, 23);
            this.codeTextBox.TabIndex = 1;
            // 
            // tbl_roomTableAdapter
            // 
            this.tbl_roomTableAdapter.ClearBeforeFill = true;
            // 
            // formUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(633, 354);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formUpdateRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUpdateRoom";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.formUpdateRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox number_flatTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox emkanatTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button button1;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tblroomBindingSource;
        private hotelDataSetTableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}