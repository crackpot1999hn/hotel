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
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.tbl_room' table. You can move, or remove it, as needed.
            this.tbl_roomTableAdapter.FillByFlag(this.hotelDataSet.tbl_room);

            this.reportViewer1.RefreshReport();
        }
    }
}
