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
    public partial class formPersonel : Form
    {
        public formPersonel()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            familyTextBox.Clear();
            field_workTextBox.Clear();
            mobileTextBox.Clear();
            nameTextBox.Clear();
            passwordTextBox.Clear();
            phoneTextBox.Clear();
            user_nameTextBox.Clear();
            addressTextBox.Clear();
            codeTextBox.Clear();
        }

        private void formPersonel_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'hotelDataSet1.tbl_personel' table
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);
            clearTextBox();
            // radio btn 1
            rd1.Checked = true;
            tbl_personelDataGridView.AllowUserToDeleteRows = false;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // تعیین سطح دسترسی هر کاربر
            int pre = 0;
            if (rd1.Checked == true)
            {
                pre = 1;
            }
            if (rd2.Checked == true)
            {
                pre = 2;
            }
            if (rd3.Checked == true)
            {
                pre = 3;
            }

            if(codeTextBox.Text !="" && nameTextBox.Text !="" && familyTextBox.Text !="" && phoneTextBox.Text !="" && addressTextBox.Text !="" && mobileTextBox.Text !="" && field_workTextBox.Text !="" && user_nameTextBox.Text !="" && passwordTextBox.Text !=""){
                tbl_personelTableAdapter.InsertQuery(codeTextBox.Text, nameTextBox.Text, familyTextBox.Text, phoneTextBox.Text, addressTextBox.Text, mobileTextBox.Text, field_workTextBox.Text, user_nameTextBox.Text, passwordTextBox.Text, pre);
                tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
                MessageBox.Show("این کاربر ثبت شد");
                clearTextBox();
            }
            else
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            int per = 0;
            if (rd1.Checked == true)
            {
                per = 1;
            }
            if (rd2.Checked == true)
            {
                per = 2;
            }
            if (rd3.Checked == true)
            {
                per = 3;
            }

            try
            {
                tbl_personelTableAdapter.UpdateQuery(nameTextBox.Text, familyTextBox.Text, phoneTextBox.Text, addressTextBox.Text, mobileTextBox.Text, field_workTextBox.Text, user_nameTextBox.Text, passwordTextBox.Text, per, codeTextBox.Text);
                tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }


        //زمانی که کلیک راست شود رو ایتم 
        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tbl_personelTableAdapter.DeleteQuery(tbl_personelDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
                }
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //delete by key Delete keyboard         زمانی که کلید دلیت کیبورد زده شود
        private void tbl_personelDataGridView_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tbl_personelTableAdapter.DeleteQuery(tbl_personelDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
                }
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // reload form
        private void formPersonel_Activated(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);

        }

        private void tbl_personelDataGridView_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
        }

        

    }
}