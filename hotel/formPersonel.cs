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
        }

        private void formPersonel_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'hotelDataSet1.tbl_personel' table.
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);
            clearTextBox();
            rd1.Checked = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
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

            tbl_personelTableAdapter.InsertQuery(codeTextBox.Text, nameTextBox.Text, familyTextBox.Text, phoneTextBox.Text, addressTextBox.Text, mobileTextBox.Text, field_workTextBox.Text, user_nameTextBox.Text, passwordTextBox.Text, pre);
            tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
            MessageBox.Show("این کاربر ثبت شد");
            clearTextBox();
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


            tbl_personelTableAdapter.UpdateQuery(nameTextBox.Text, familyTextBox.Text, phoneTextBox.Text, addressTextBox.Text, mobileTextBox.Text, field_workTextBox.Text, user_nameTextBox.Text, passwordTextBox.Text, per, codeTextBox.Text);
            tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void tbl_personelDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_personelTableAdapter.DeleteQuery(tbl_personelDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                this.tbl_personelTableAdapter.Fill(hotelDataSet.tbl_personel);
            }
        }

        
    }
}