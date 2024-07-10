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
    public partial class DELETE_UC : UserControl
    {
        public DELETE_UC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WELCOME_PAGE wels = new WELCOME_PAGE();
            wels.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            dataGridView1.DataSource = t1.getClients().Tables["Client"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThirdLayer t1 = new ThirdLayer();
            Client client = new Client();
            client.patientID = int.Parse(tbId.Text);
            t1.DeleteClient(client);
        }
    }
}
