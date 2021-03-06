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
    public partial class formUpdateCustomer : Form
    {
        public formUpdateCustomer(string code)
        {
            InitializeComponent();
            textCode.Text = code;
        }

        private void tbl_customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }
        private void formUpdateCustomer_Load(object sender, EventArgs e)
        {
            
            this.tbl_customerTableAdapter.FillByCode(this.hotelDataSet.tbl_customer,textCode.Text);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

         if ( textName.Text != "" && textFamily.Text != "" && textCodemeli.Text != "" && textPhone.Text != "" && textMobile.Text != "" && textCode.Text !="")
         {
                tbl_customerTableAdapter.UpdateQuery(textName.Text, textFamily.Text, textCodemeli.Text, textPhone.Text, textMobile.Text, textCode.Text);
                this.Close();

            }else{
                MessageBox.Show("مشکلی پیش آمده مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

         }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       

     
    }
}
