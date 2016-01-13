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
    public partial class ChildPanel : Form
    {
        private MainForm parentForm;
        public ChildPanel()
        {
        }
        public ChildPanel(MainForm parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            configPanel();
        }

        private void configPanel()
        {
            this.MdiParent = parentForm;
            //this.Size = parentForm.getMainPanelSize();
            //this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Normal;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.TopLevel = false;
        }

    }
}