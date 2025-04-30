using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        { 
                string id = UserIdBox.Text;
                string password = PassBox.Text;
                if (id == "marwan" && password == "el yassini")
                {
                    Form1 f = new Form1();
                    f.Show();
                    f.Hide();
                    this.Hide();
                     MessageBox.Show("Login successful");
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Impossible to login");
                    
                    
                }
        }
            

        

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UserIdBox.ResetText();
            PassBox.ResetText();
            
        }
    }
}
