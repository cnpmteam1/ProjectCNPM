using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          /* DialogResult confirm = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }*/
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            //ChildPanel mainForm = new ChildPanel();
            this.Hide();
            mainForm.Show();
        }
    }
}
