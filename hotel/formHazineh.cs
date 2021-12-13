﻿using System;
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
    public partial class formHazineh : Form
    {
        public formHazineh()
        {
            InitializeComponent();
        }

        private void tbl_hazinehBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_hazinehBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void clearTextBox()
        {
            codeTextBox.Text = "";
            code_factorTextBox.Text= "";
            codePersonelComboBox.Text = "";
            azforoshandehTextBox.Text= "";
            codeTextBox.Text = "";
            codeTextBox.Text = "";
            sharhTextBox.Text = "";
            descTextBox.Text = "";
            paymentsTextBox.Text = "";
            priceTextBox.Text = "";
            lblPayments.Text = "";
            lblTotal.Text = "";
           

        }

        private void formHazineh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_hazineh' table. You can move, or remove it, as needed.
            this.tbl_hazinehTableAdapter.Fill(this.hotelDataSet.tbl_hazineh);
            lblTotal.Text = tbl_hazinehTableAdapter.getTotal().ToString();
            lblPayments.Text = tbl_hazinehTableAdapter.getPayments().ToString();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*
             string flagRd;

            if (rdKharid.Checked)
                flagRd = "خرید";

            if(rdKhedmat.Checked)
                flagRd = "خدمت"; */

             tbl_hazinehTableAdapter.InsertQuery(codeTextBox.Text, code_factorTextBox.Text, codePersonelComboBox.Text, sharhTextBox.Text, azforoshandehTextBox.Text, decimal.Parse(priceTextBox.Text), "", decimal.Parse(paymentsTextBox.Text), descTextBox.Text);
             tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
             MessageBox.Show(" هزینه مورد نظر بروز شد");
             clearTextBox();
        }

        private void tbl_hazinehDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("ایا از حذف مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbl_hazinehTableAdapter.DeleteQuery(tbl_hazinehDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
        }

        private void FacSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FacSearchTextBox.Text=="")
            {
                tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
            else
            {
                tbl_hazinehTableAdapter.FillByCodeFactor(hotelDataSet.tbl_hazineh, FacSearchTextBox.Text);
            }
        }

        private void azForoSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (azForoSearchTextBox.Text== "")
            {
                tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
            else
            {
                tbl_hazinehTableAdapter.FillByForoshandeh(hotelDataSet.tbl_hazineh, azForoSearchTextBox.Text);
            }
           
        }

        private void personelSearchComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (personelSearchComboBox.Text=="")
            {
                tbl_hazinehTableAdapter.Fill(hotelDataSet.tbl_hazineh);
            }
            else
            {
                tbl_hazinehTableAdapter.FillByCodePersonel(hotelDataSet.tbl_hazineh, personelSearchComboBox.Text);
            }
        }
     
    }
}
