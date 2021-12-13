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
        public formReserve(string codeCustomer)
        {
            InitializeComponent();
            CustomerComboBox.Text = codeCustomer;
        }

        private void tbl_reserveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_reserveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void formReserve_Load(object sender, EventArgs e)
        {
            //  This line of code loads data into the 'hotelDataSet.tbl_room' table.
            this.tbl_roomTableAdapter.FillByFlag(this.hotelDataSet.tbl_room);
            //  This line of code loads data into the 'hotelDataSet.tbl_customer' table
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            //  This line of code loads data into the 'hotelDataSet.tbl_reserve' table
            this.tbl_reserveTableAdapter.Fill(this.hotelDataSet.tbl_reserve);

            codeTextBox.Text = tbl_reserveTableAdapter.getMaxCode().ToString();


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            tbl_reserveTableAdapter.InsertQuery(codeTextBox.Text, faDatePicker1.Text, faDatePicker2.Text, RoomComboBox.Text, CustomerComboBox.Text, madrakTextBox.Text, 0, 0, 0);
            // tbl_reserveTableAdapter.FillByCode(hotelDataSet.tbl_reserve, codeTextBox.Text);

            tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);

            tbl_roomTableAdapter.UpdateFlag(CustomerComboBox.Text, codeTextBox.Text);

            MessageBox.Show("رزرو انجام شد.لطفا پرداختی های مشتری را از طریق همین فرم ثبت کنید", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            codeTextBox.Text = tbl_reserveTableAdapter.getMaxCode().ToString();

            madrakTextBox.Text="";
            faDatePicker1.Text = "" ;
            faDatePicker2.Text = "";
            RoomComboBox.Text = "";
            CustomerComboBox.Text = "";
            madrakTextBox.Text = "";
            CustomerComboBox.Focus();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
             int date = int.Parse(tbl_reserveTableAdapter.getDateDiff(codeRezerveTextBox.Text).ToString());

            decimal total = date * decimal.Parse(lblPrice.Text);

            lblTotal.Text = total.ToString();

            baghiMandehTextBox.Text = tbl_reserveTableAdapter.getBaghiMandeh(codeRezerveTextBox.Text).ToString();
        }


        private void applyBtn_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbl_reserveTableAdapter.UpdatePayments(0, decimal.Parse(paymentTextBox.Text), codeRezerveTextBox.Text);
                MessageBox.Show("پرداخت انجام شد");
                tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
                baghiMandehTextBox.Text = tbl_reserveTableAdapter.getBaghiMandeh(codeRezerveTextBox.Text).ToString();

            }
            else
            {
                tbl_reserveTableAdapter.UpdatePayments(decimal.Parse(lblTotal.Text), decimal.Parse(paymentTextBox.Text), codeRezerveTextBox.Text);
                MessageBox.Show("پرداخت انجام شد");
                tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
                baghiMandehTextBox.Text = tbl_reserveTableAdapter.getBaghiMandeh(codeRezerveTextBox.Text).ToString();


            }
        }


        private void خالیکردناتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl_roomTableAdapter.UpdateFlag("1", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("اتاق خالی شد");
            tbl_roomTableAdapter.FillByFlag(hotelDataSet.tbl_room);
            
        }


        private void formReserve_Activated(object sender, EventArgs e)
        {
            tbl_customerTableAdapter.Fill(hotelDataSet.tbl_customer);
            tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
        }

        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                tbl_reserveTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                tbl_reserveTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            
        }

        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formUpdateReserve(dataGridView1.CurrentRow.Cells["code"].Value.ToString()).ShowDialog();
        }

     
       

    }
}
