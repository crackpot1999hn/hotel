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

        private void clearTextBox()
        {
            madrakTextBox.Text = "";
            faDatePicker1.Text = "";
            faDatePicker2.Text = "";
            RoomComboBox.Text = "";
            CustomerComboBox.Text = "";
            madrakTextBox.Text = "";
        }

        private void formReserve_Load(object sender, EventArgs e)
        {
            // load tbl room     فقط اتاق هایی که خالی هستن نمایش داده میشن 
            this.tbl_roomTableAdapter.FillByFlag(this.hotelDataSet.tbl_room);
            //  This line of code loads data into the 'hotelDataSet.tbl_customer' table
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            //  This line of code loads data into the 'hotelDataSet.tbl_reserve' table
            this.tbl_reserveTableAdapter.Fill(this.hotelDataSet.tbl_reserve);

            codeTextBox.Text = tbl_reserveTableAdapter.getMaxCode().ToString();


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           
                if (codeTextBox.Text != "" && faDatePicker1.Text != "" && faDatePicker2.Text != "" && RoomComboBox.Text != "" && CustomerComboBox.Text != "" && madrakTextBox.Text != "")
                {
                    tbl_reserveTableAdapter.InsertQuery(codeTextBox.Text, faDatePicker1.Text, faDatePicker2.Text, RoomComboBox.Text, CustomerComboBox.Text, madrakTextBox.Text, 0, 0, 0);
                    tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);

                    // بروز رسانی اتاق های خالی یا پر
                    tbl_roomTableAdapter.UpdateFlag(CustomerComboBox.Text, codeTextBox.Text);
                    MessageBox.Show("رزرو انجام شد.لطفا پرداختی های مشتری را از طریق همین فرم ثبت کنید", "انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /// اضافه شدن خودکار کد
                    codeTextBox.Text = tbl_reserveTableAdapter.getMaxCode().ToString();
                    clearTextBox();
                    CustomerComboBox.Focus();
                }
                else
                {
                    MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
           
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            try{
            // محاسبه اختلاف  تاریخ شروع رزرو تا پایان رزرو اتاق
             int date = int.Parse(tbl_reserveTableAdapter.getDateDiff(codeRezerveTextBox.Text).ToString());

            // محاسبه جمع کل حساب 
            decimal total = date * decimal.Parse(lblPrice.Text);

            // نمایش جمع کل حساب
            lblTotal.Text = total.ToString();

            // نمایش باقی مانده حساب
            baghiMandehTextBox.Text = tbl_reserveTableAdapter.getBaghiMandeh(codeRezerveTextBox.Text).ToString();

        }catch{
          MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        }


        private void applyBtn_Click_1(object sender, EventArgs e)
        {
           try{
               // انجام پرداختی ها و سپس بروز رسانی آن
                tbl_reserveTableAdapter.UpdatePayments(decimal.Parse(lblTotal.Text), decimal.Parse(paymentTextBox.Text), codeRezerveTextBox.Text);
                MessageBox.Show("پرداخت انجام شد");
                tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
               
               // نمایش باقی مانده حساب کل و بروز رسانی آن بعد پرداخت
                baghiMandehTextBox.Text = tbl_reserveTableAdapter.getBaghiMandeh(codeRezerveTextBox.Text).ToString();
           }
           catch
           {
               MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
        }

        //زمانی که کلیک راست شود رو ایتم 
        private void خالیکردناتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // flag = 1 اتاق خالی است 
                tbl_roomTableAdapter.UpdateFlag("1", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("اتاق خالی شد");
                tbl_roomTableAdapter.FillByFlag(hotelDataSet.tbl_room);
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        // refrash form
        private void formReserve_Activated(object sender, EventArgs e)
        {
            tbl_customerTableAdapter.Fill(hotelDataSet.tbl_customer);
            tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
        }


        //زمانی که کلیک راست شود رو ایتم 
        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    tbl_reserveTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //delete by key Delete keyboard         زمانی که کلید دلیت کیبورد زده شود
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    tbl_reserveTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);

            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //زمانی که کلیک راست شود رو ایتم 
        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formUpdateReserve(dataGridView1.CurrentRow.Cells["code"].Value.ToString()).ShowDialog();
        }
    }
}
