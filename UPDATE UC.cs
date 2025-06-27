using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharma__link
{
    public partial class tbName : UserControl
    {
        public tbName()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WELCOME_PAGE wels = new WELCOME_PAGE();
            wels.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            dgrid.DataSource = t1.getClients().Tables["Client"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            Client c = new Client();
            Medication m = new Medication();
            c.patientID=int.Parse(tbid.Text);
            c.Patient_Name = tbNameup.Text;
            c.Patient_Age = int.Parse(tbAge.Text);
            m.MedName = tbMedName.Text;
            m.Dosage = tbDosage.Text;
            t1.UpdateClient(c, m);
        }

        private void tbName_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void tbNameup_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
