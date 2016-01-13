using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Manage_App
{
    public partial class MainForm : Form
    {

        private Size mainPanelSize;
        private Form mainPanel;
        private ArrayList workPanelList;
        public MainForm()
        {
            InitializeComponent();

  
            mainPanelSize.Height = this.Height - topControl.Size.Height-10;
            mainPanelSize.Width = this.Width - 10;
            mainPanel = null;
            InitializeChildPanelList();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }

   

        public Size getMainPanelSize()
        {
            return mainPanelSize;
        }


        private void InitializeChildPanelList(){
            workPanelList = new ArrayList(4);
            workPanelList.Add(new Employee.View(this));
            workPanelList.Add(new Finance.View(this));
            workPanelList.Add(new Project.View(this));
            workPanelList.Add(new Customer.View(this));
            mainPanel = (Form)workPanelList[0];
            //((Form)workPanelList[1]).Dock = DockStyle.Fill;
            mainPanel.Show();
        }

        private void employeeBt_Click(object sender, EventArgs e)
        {
            mainPanel.Hide();
            mainPanel = (Form)workPanelList[0];
            mainPanel.Show();
        }

        private void customerBt_Click(object sender, EventArgs e)
        {
            mainPanel.Hide();
            mainPanel = (Form)workPanelList[3];
            mainPanel.Show();
        }

        private void financeBt_Click(object sender, EventArgs e)
        {
            mainPanel.Hide();
            mainPanel = (Form)workPanelList[1];
            mainPanel.Show();
        }

        private void projectBt_Click(object sender, EventArgs e)
        {
            mainPanel.Hide();
            mainPanel = (Form)workPanelList[2];
            mainPanel.Show();
        }

       
    }

   
}
