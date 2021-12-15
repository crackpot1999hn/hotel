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
    public partial class formUpdateRoom : Form
    {
        public formUpdateRoom(string code)
        {
            InitializeComponent();
            //  گرفتن کد و قرار دادن در تکس باکس 
            codeTextBox.Text = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formUpdateRoom_Load(object sender, EventArgs e)
        {
            this.tbl_roomTableAdapter.Fill(this.hotelDataSet.tbl_room);

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // flagroom = 1 اتاق خالی است   
            string flagroom = "2";

            if (checkBox1.Checked == true)
                flagroom = "1";

            try
            {
                tbl_roomTableAdapter.UpdateQuery(int.Parse(number_flatTextBox.Text), int.Parse(areaTextBox.Text), decimal.Parse(priceTextBox.Text), emkanatTextBox.Text, descTextBox.Text, flagroom, codeTextBox.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
    }
}
