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
    public partial class CLIENT_FORM : Form
    {
        public CLIENT_FORM()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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
            dgridAddpage.DataSource = t1.getClients().Tables["Client"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            Client c = new Client();
            Medication m = new Medication();
            c.Patient_Name = tbName.Text;
            c.Patient_Age = int.Parse(tbAge.Text);
            m.MedName = tbMedName.Text;
            m.Dosage = tbDosage.Text;
            t1.AddClient(c, m);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        { }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
