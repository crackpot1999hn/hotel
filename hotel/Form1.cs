using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void اطلاعاتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formCustomer().ShowDialog();
        }

        private void ثبتاتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formRoom().ShowDialog();
        }

        private void رزرواتاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formReserve().ShowDialog();
        }

    
      
    }
}
