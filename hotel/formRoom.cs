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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //  flag = 1 اتاق خالی است
            tbl_roomTableAdapter.InsertQuery(codeTextBox.Text, int.Parse(number_flatTextBox.Text), int.Parse(areaTextBox.Text), decimal.Parse(priceTextBox.Text), emkanatTextBox.Text, descTextBox.Text, "1");
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            MessageBox.Show("اطلاعات اتاق ثبت شد و میتوانید رزرو را انجام دهید");
            codeTextBox.Text = tbl_roomTableAdapter.getMaxCode().ToString();
            emkanatTextBox.Clear();
            priceTextBox.Clear();
            areaTextBox.Clear();
            number_flatTextBox.Clear();
            descTextBox.Clear();
            number_flatTextBox.Focus();
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

        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_roomTableAdapter.DeleteQuery(tbl_roomDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            }
        }

        //delete by key Delete keyboard
        private void tbl_roomDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_roomTableAdapter.DeleteQuery(tbl_roomDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);
            }
        }

        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formUpdateRoom(tbl_roomDataGridView.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();

        }

        private void اتاقخالینیستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbl_roomTableAdapter.UpdateFlag("1", tbl_roomDataGridView.SelectedRows[0].Cells[0].Value.ToString());
        }

      
    }
}
