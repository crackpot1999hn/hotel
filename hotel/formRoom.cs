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
    public partial class formRoom : Form
    {
        public formRoom()
        {
            InitializeComponent();
        }

        

        private void tbl_roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void formRoom_Load(object sender, EventArgs e)
        {
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            codeTextBox.Text = tbl_roomTableAdapter.getMaxCode().ToString();
            number_flatTextBox.Focus();
        }

        private void clearTextBox()
        {
            emkanatTextBox.Clear();
            priceTextBox.Clear();
            areaTextBox.Clear();
            number_flatTextBox.Clear();
            descTextBox.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //  flag = 1 اتاق خالی است
                tbl_roomTableAdapter.InsertQuery(codeTextBox.Text, int.Parse(number_flatTextBox.Text), int.Parse(areaTextBox.Text), decimal.Parse(priceTextBox.Text), emkanatTextBox.Text, descTextBox.Text, "1");
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
                MessageBox.Show("اطلاعات اتاق ثبت شد و میتوانید رزرو را انجام دهید");

                /// اضافه شدن خودکار کد
                codeTextBox.Text = tbl_roomTableAdapter.getMaxCode().ToString();
                clearTextBox();
                number_flatTextBox.Focus();
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void searchCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchCodeTextBox.Text == "")
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            
            else
                tbl_roomTableAdapter.FillByCode(hotelDataSet.tbl_room, searchCodeTextBox.Text);

        }

        private void searchPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchPriceTextBox.Text == "")
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);

            else
                tbl_roomTableAdapter.FillByPrice(hotelDataSet.tbl_room, decimal.Parse( searchPriceTextBox.Text));
        }

        private void searchFlatTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchFlatTextBox.Text == "")
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);

            else
                tbl_roomTableAdapter.FillByFlat(hotelDataSet.tbl_room, int.Parse(searchFlatTextBox.Text));
        }

      

        // reload form when item Deleted
        private void formRoom_Activated(object sender, EventArgs e)
        {
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);

        }

        //زمانی که کلیک راست شود رو ایتم 
        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tbl_roomTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
                }
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
                {
                    tbl_roomTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
                }
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //زمانی که کلیک راست شود رو ایتم 
        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new formUpdateRoom(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //زمانی که کلیک راست شود رو ایتم 
        private void خالیکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // خالی کردن اتاق 
            // flag = 1 اتاق خالی است    
            try
            {
            tbl_roomTableAdapter.UpdateFlag("1", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          

        }

      

       

      
    }
}
