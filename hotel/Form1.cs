using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;

    /**
     * مسعود حبیب نژاد
     * 
     * */

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1(string us, string per)
        {
            InitializeComponent();
            lblPer.Text = per;
            lblUsLogin.Text = us;
        }

        private void اطلاعاتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formCustomer().ShowDialog();
        }

        private void ثبتاتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            new formRoom().Show();          
        }

        private void رزرواتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formReserve("").ShowDialog();
        }

        private void اطلاعاتکارکنانToolStripMenuItem_Click(object sender, EventArgs e)
        {
             new formPersonel().Show();
     
        }

      

        private void tbl_roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'hotelDataSet.tbl_personel' table
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);
            // This line of code loads data into the 'hotelDataSet.tbl_reserve' table
            this.tbl_reserveTableAdapter.Fill(this.hotelDataSet.tbl_reserve);
            // This line of code loads data into the 'hotelDataSet.tbl_room' table
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);

            // سطح دسترسی برای منو 
            if (lblPer.Text == "2")
            {
                اطلاعاتکارکنانToolStripMenuItem.Visible = false;
            }
            else if (lblPer.Text == "3")
            {
                اطلاعاتکارکنانToolStripMenuItem.Visible = false;
                هزینهToolStripMenuItem.Visible = false;
                گزارشToolStripMenuItem.Visible = false;
            }

        }

        private void اتاقهایخالیToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // tbl_roomTableAdapter.FillByFlag(hotelDataSet.tbl_room);
          
            formReport fr = new formReport();
            fr.Owner = this;
            fr.Show();
        }

    
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new formLogin().Show();
        }

        private void هزینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formHazineh().ShowDialog();

        }

        // refrash form
        private void Form1_Activated(object sender, EventArgs e)
        {
            tbl_reserveTableAdapter.Fill(hotelDataSet.tbl_reserve);
        }


    }
}
