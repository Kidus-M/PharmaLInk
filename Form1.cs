namespace Pharma__link
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void ShowHomepage()
        {
            Login home1 = new Login();
            home1.Show();
            this.Hide();

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPASSWORD.PasswordChar = (textBoxPASSWORD.PasswordChar == '\0') ? '*' : '\0';
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(textBoxPASSWORD.Text))
            {
                MessageBox.Show(" ALL FIELDS MUST BE FILLED ", "empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ThirdLayer t1 = new ThirdLayer();
                Doctor d = new Doctor();
                d.Doctor_Username = tbUsername.Text;
                d.Doctor_Password = textBoxPASSWORD.Text;
                if (t1.login(d)) {
                    WELCOME_PAGE wel = new WELCOME_PAGE();
                    addUserControl(wel);
                    Controls.Add(wel);
                    wel.Dock = DockStyle.Fill;
                    wel.BringToFront();
                }
                else
                {
                    MessageBox.Show(" WRONG USERNAME OR PASSWORD TRY AGAIN ", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbUsername.Text = "";
                    textBoxPASSWORD.Text = "";
                }

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sign_up_form su = new Sign_up_form();
            addUserControl(su);
            Controls.Add(su);
            su.Dock = DockStyle.Fill;
            su.BringToFront();

        }
    }
}