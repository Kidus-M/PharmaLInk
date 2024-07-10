namespace Pharma__link
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            tbUsername = new TextBox();
            textBoxPASSWORD = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(633, 55);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(138, 194, 194);
            label2.Location = new Point(633, 602);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(138, 194, 194);
            label3.Location = new Point(633, 695);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 37);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(138, 194, 194);
            panel1.Location = new Point(826, 629);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 11);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(138, 194, 194);
            panel2.Location = new Point(826, 723);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 11);
            panel2.TabIndex = 4;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(18, 53, 91);
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbUsername.ForeColor = Color.FromArgb(16, 128, 128);
            tbUsername.Location = new Point(826, 593);
            tbUsername.Margin = new Padding(6);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(371, 37);
            tbUsername.TabIndex = 5;
            tbUsername.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPASSWORD
            // 
            textBoxPASSWORD.BackColor = Color.FromArgb(18, 53, 91);
            textBoxPASSWORD.BorderStyle = BorderStyle.None;
            textBoxPASSWORD.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPASSWORD.ForeColor = Color.FromArgb(16, 128, 128);
            textBoxPASSWORD.Location = new Point(826, 689);
            textBoxPASSWORD.Margin = new Padding(6);
            textBoxPASSWORD.Name = "textBoxPASSWORD";
            textBoxPASSWORD.PasswordChar = '*';
            textBoxPASSWORD.Size = new Size(371, 36);
            textBoxPASSWORD.TabIndex = 5;
            textBoxPASSWORD.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(576, 593);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(576, 695);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(46, 53);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(16, 128, 128);
            button2.Location = new Point(633, 960);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(121, 53);
            button2.TabIndex = 8;
            button2.Text = "LOG IN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(16, 128, 128);
            button3.Location = new Point(877, 960);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(130, 53);
            button3.TabIndex = 9;
            button3.Text = "SIGN UP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.IndianRed;
            button4.Location = new Point(1131, 960);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(121, 53);
            button4.TabIndex = 10;
            button4.Text = "EXIT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(852, 1013);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 11;
            label1.Text = "Not Signed Up?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 53, 91);
            ClientSize = new Size(1827, 1090);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxPASSWORD);
            Controls.Add(tbUsername);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(6);
            Name = "Login";
            Text = "a";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private TextBox tbUsername;
        private TextBox textBoxPASSWORD;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}