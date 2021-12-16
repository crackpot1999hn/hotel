using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class formUpdateReserve : Form
    {
        public formUpdateReserve(string code)
        {
            InitializeComponent();
            codeTextBox.Text = code;

        }

        private void formUpdateReserve_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'hotelDataSet.tbl_room' table
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            // This line of code loads data into the 'hotelDataSet.tbl_customer' table.
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);

            // load tbl room     فقط اتاق هایی که خالی هستن نمایش داده میشن 
            this.tbl_roomTableAdapter.FillByFlag(this.hotelDataSet.tbl_room);
            // load by code
            this.tbl_reserveTableAdapter.FillByCode(this.hotelDataSet.tbl_reserve,codeTextBox.Text);

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(dateStartTextBox.Text !="" && dateEndTextBox.Text !="" && RoomComboBox.Text !="" && CustomerComboBox.Text !="" && madrakTextBox.Text !="" && TotaltextBox.Text !="" && paymentTextBox.Text !=""){
                tbl_reserveTableAdapter.UpdateQuery(dateStartTextBox.Text, dateEndTextBox.Text, RoomComboBox.Text, CustomerComboBox.Text, madrakTextBox.Text, decimal.Parse(TotaltextBox.Text), 0, decimal.Parse(paymentTextBox.Text), codeTextBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
