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
    public partial class formCustomer : Form
    {
        public formCustomer()
        {
            InitializeComponent();
        }

        private void tbl_customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void formCustomer_Load(object sender, EventArgs e)
        {
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            codeTextBox.Text = tbl_customerTableAdapter.getMaxCode().ToString();
            code_meliTextBox.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            tbl_customerTableAdapter.InsertQuery(codeTextBox.Text, nameTextBox.Text, familyTextBox.Text, code_meliTextBox.Text, phoneTextBox.Text, mobileTextBox.Text);
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            MessageBox.Show("اطلاعات این مشتری با موفقیت ثبت شد", "ثبت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            codeTextBox.Text = tbl_customerTableAdapter.getMaxCode().ToString();
            code_meliTextBox.Clear();
            nameTextBox.Clear();
            familyTextBox.Clear();
            phoneTextBox.Clear();
            mobileTextBox.Clear();
            code_meliTextBox.Focus();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
                this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);

            else
                tbl_customerTableAdapter.FillCodemeli(hotelDataSet.tbl_customer, searchTextBox.Text);  
        }

        private void ویرایشاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formUpdateCustomer(tbl_customerDataGridView.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();

        }

        private void حذفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_customerTableAdapter.DeleteQuery(tbl_customerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            }
        }

        private void tbl_customerDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("این ستون حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_customerTableAdapter.DeleteQuery(tbl_customerDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            this.tbl_customerTableAdapter.Fill(this.hotelDataSet.tbl_customer);

        }

      

    }
}
