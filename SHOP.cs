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
    public partial class SHOP : UserControl
    {
        public SHOP()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = t1.getMedsClients().Tables["Patient and meds"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            Client c = new Client();
            Medication m = new Medication();

            c.patientID = int.Parse(tbPatient.Text);
            m.MedName = tbMedName.Text;
            m.Dosage = tbDosage.Text;
            m.Amount = int.Parse(tbAmount.Text);

            t1.CheckPerscription(c, m);
            double total = m.Cost * m.Amount;
            tbTotal.Text=total.ToString();
            
        }
    }
}
