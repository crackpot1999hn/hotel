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
    public partial class formReserve : Form
    {
        public formReserve()
        {
            InitializeComponent();
        }

        private void tbl_reserveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_reserveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void formReserve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_customer' table. You can move, or remove it, as needed.
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_reserve' table. You can move, or remove it, as needed.
            this.tbl_reserveTableAdapter.Fill(this.hotelDataSet.tbl_reserve);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            tbl_reserveTableAdapter.InsertQuery(codeTextBox.Text, faDatePicker1.Text, faDatePicker2.Text, RoomComboBox.Text, CustomerComboBox.Text, madrakTextBox.Text, 0, 0, 0);
            // tbl_reserveTableAdapter.FillBycode(hotelDataSet.tbl_reserve, txtcode.Text);

            tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
            MessageBox.Show("رزرو انجام شد.لطفا پرداختی های مشتری را از طریق همین فرم ثبت کنید","انجام شد",MessageBoxButtons.OK,MessageBoxIcon.Information);

            codeTextBox.Text = tbl_reserveTableAdapter.getMaxCode().ToString();
           
            madrakTextBox.Clear();
            CustomerComboBox.Focus();
        }

        private void calBtn_Click_1(object sender, EventArgs e)
        {
            int date = int.Parse(tbl_reserveTableAdapter.getDateDiff(codeRezerveTextBox.Text).ToString());

            decimal total = date * decimal.Parse(lblPrice.Text);

            lblTotal.Text = total.ToString();

            baghiMandehTextBox.Text = tbl_reserveTableAdapter.getBaghiMandeh(codeRezerveTextBox.Text).ToString();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbl_reserveTableAdapter.UpdatePayment(0, decimal.Parse(paymentTextBox.Text), codeRezerveTextBox.Text);
                MessageBox.Show("پرداخت انجام شد");
                tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
                baghiMandehTextBox.Text = tbl_reserveTableAdapter.getBaghiMandeh(codeRezerveTextBox.Text).ToString();

            }
            else
            {
                tbl_reserveTableAdapter.UpdatePayment(decimal.Parse(lblTotal.Text), decimal.Parse(paymentTextBox.Text), codeRezerveTextBox.Text);
                MessageBox.Show("پرداخت انجام شد");
                tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);

            }
        }


     

     
    
    }
}
