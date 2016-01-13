namespace Manage_App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.projectBt = new System.Windows.Forms.Button();
            this.financeBt = new System.Windows.Forms.Button();
            this.customerBt = new System.Windows.Forms.Button();
            this.employeeBt = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.topControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topControl
            // 
            this.topControl.Controls.Add(this.tabPage1);
            this.topControl.Controls.Add(this.tabPage2);
            this.topControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topControl.Location = new System.Drawing.Point(0, 0);
            this.topControl.Name = "topControl";
            this.topControl.SelectedIndex = 0;
            this.topControl.Size = new System.Drawing.Size(784, 92);
            this.topControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.projectBt);
            this.tabPage1.Controls.Add(this.financeBt);
            this.tabPage1.Controls.Add(this.customerBt);
            this.tabPage1.Controls.Add(this.employeeBt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 66);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // projectBt
            // 
            this.projectBt.Location = new System.Drawing.Point(327, 22);
            this.projectBt.Name = "projectBt";
            this.projectBt.Size = new System.Drawing.Size(120, 23);
            this.projectBt.TabIndex = 3;
            this.projectBt.Text = "Project && Services";
            this.projectBt.UseVisualStyleBackColor = true;
            this.projectBt.Click += new System.EventHandler(this.projectBt_Click);
            // 
            // financeBt
            // 
            this.financeBt.Location = new System.Drawing.Point(201, 22);
            this.financeBt.Name = "financeBt";
            this.financeBt.Size = new System.Drawing.Size(120, 23);
            this.financeBt.TabIndex = 2;
            this.financeBt.Text = "Finance";
            this.financeBt.UseVisualStyleBackColor = true;
            this.financeBt.Click += new System.EventHandler(this.financeBt_Click);
            // 
            // customerBt
            // 
            this.customerBt.Location = new System.Drawing.Point(453, 22);
            this.customerBt.Name = "customerBt";
            this.customerBt.Size = new System.Drawing.Size(120, 23);
            this.customerBt.TabIndex = 1;
            this.customerBt.Text = "Customer";
            this.customerBt.UseVisualStyleBackColor = true;
            this.customerBt.Click += new System.EventHandler(this.customerBt_Click);
            // 
            // employeeBt
            // 
            this.employeeBt.Location = new System.Drawing.Point(75, 22);
            this.employeeBt.Name = "employeeBt";
            this.employeeBt.Size = new System.Drawing.Size(120, 23);
            this.employeeBt.TabIndex = 0;
            this.employeeBt.Text = "Employee";
            this.employeeBt.UseVisualStyleBackColor = true;
            this.employeeBt.Click += new System.EventHandler(this.employeeBt_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 66);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.topControl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.topControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl topControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button customerBt;
        private System.Windows.Forms.Button employeeBt;
        private System.Windows.Forms.Button projectBt;
        private System.Windows.Forms.Button financeBt;
    }
}