using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Pharma__link
{
    public partial class Sign_up_form : UserControl
    {
        public Sign_up_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxPASSWORD2.PasswordChar = (textBoxPASSWORD2.PasswordChar == '\0') ? '*' : '\0';
            ;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(textBoxPASSWORD2.Text) || string.IsNullOrEmpty(textboxPASSWORD3.Text) || string.IsNullOrEmpty(tbspec.Text))
            {
                MessageBox.Show("ALL FIELDS MUST BE FILLED", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string pass1 = textBoxPASSWORD2.Text;
                string pass2 = textboxPASSWORD3.Text;
                if (pass1 == pass2)
                {
                    ThirdLayer t1= new ThirdLayer();
                    Doctor d= new Doctor();
                    d.Doctor_Name= tbName.Text;
                    d.Doctor_Password=textBoxPASSWORD2.Text;
                    d.Doctor_Username= tbUserName.Text;
                    d.Specialization=tbspec.Text;
                    t1.SignUp(d);

                    Form logform = this.FindForm();
                    if (logform is Login form1)
                    {
                        form1.ShowHomepage();
                    }
                }
                else
                {
                    MessageBox.Show("PASSWORDS DO NOT MATCH!", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private void textboxPASSWORD2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPASSWORD2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textboxPASSWORD3.PasswordChar = (textboxPASSWORD3.PasswordChar == '\0') ? '*' : '\0';
            ;
        }
    }
}
