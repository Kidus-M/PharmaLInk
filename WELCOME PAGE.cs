using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma__link
{
    public partial class WELCOME_PAGE : UserControl
    {
        public WELCOME_PAGE()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                CLIENT_FORM CF = new CLIENT_FORM();
                CF.Show();

            }
            else if (radioButton2.Checked)
            {


                tbName upd = new tbName();
                addUserControl(upd);
                Controls.Add(upd);
                upd.Dock = DockStyle.Fill;
                upd.BringToFront();
            }
            else
            {

                DELETE_UC del = new DELETE_UC();
                addUserControl(del);
                Controls.Add(del);
                del.Dock = DockStyle.Fill;
                del.BringToFront();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MEDADD Medadd = new MEDADD();
            addUserControl(Medadd);
            Controls.Add(Medadd);
            Medadd.Dock = DockStyle.Fill;
            Medadd.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form logform = this.FindForm();
            if (logform is Login form1)
            {
                form1.ShowHomepage();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SHOP shop = new SHOP();
            addUserControl(shop);
            Controls.Add(shop);
            shop.Dock = DockStyle.Fill;
            shop.BringToFront();
        }
    }
}
