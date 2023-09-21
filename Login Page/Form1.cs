using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text==""|| this.textBox2.Text == ""|| this.textBox3.Text == "")
            {
                MessageBox.Show("Please Fill in the Necessary Fields before Continuing!!");
                return;
            }
            if (this.textBox2.Text != this.textBox3.Text)
            {
                MessageBox.Show("The Passwords Entered are Miss matching");
                this.textBox2.ResetText();
                this.textBox3.ResetText();
            }
            else
            {
                MessageBox.Show("Login Successful");
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox2.ResetText();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login Page Loading!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Would You like to Cancel?","Alert",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                MessageBox.Show("Thanks for Using your Log outs");
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox3.ResetText();
            }
            else
            {
                MessageBox.Show("All your Initial Entries are going to be cleare!");
                this.textBox1.ResetText();
                this.textBox2.ResetText();
                this.textBox3.ResetText();
            }
        }
    }
}
