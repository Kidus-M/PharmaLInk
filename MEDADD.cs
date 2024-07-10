using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma__link
{
    public partial class MEDADD : UserControl
    {
        public MEDADD()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WELCOME_PAGE wels = new WELCOME_PAGE();
            wels.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            dataGridView1.DataSource = t1.getMeds().Tables["Meds"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            Medication m=new Medication();

            m.MedName=tbName.Text;
            m.Manufacturing_Company = tbCompany.Text;
            m.Dosage=tbDosage.Text;
            m.Cost=double.Parse(tbPrice.Text);
            m.Description=tbDescription.Text;
            m.Amount=int.Parse(tbAmount.Text);
            m.Expiry_Date=tbExpireDate.Text;
            m.Perscription=tbPerscription.Text;

            t1.Addmeds(m);
        }
    }
}
