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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'hotelDataSet.tbl_personel' table
            this.tbl_personelTableAdapter.Fill(this.hotelDataSet.tbl_personel);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            tbl_personelTableAdapter.Login(hotelDataSet.tbl_personel, usernameCombo.Text, passTextBox.Text);

            if (hotelDataSet.tbl_personel.Rows.Count > 0)
            {

                Form1 fr = new Form1(usernameCombo.Text, lblPermission.Text);
                fr.Show();
            }
            else
            {
                // reload  form
                  formLogin frm = new formLogin();
                  frm.Show();
                  this.Hide();
                MessageBox.Show("نام کاربری یا رمز ورود اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
          
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // نمایش پسورد
            passTextBox.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
