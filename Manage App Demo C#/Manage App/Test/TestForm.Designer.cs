namespace Manage_App
{
    partial class TestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBt = new System.Windows.Forms.Button();
            this.changeInfoBt = new System.Windows.Forms.Button();
            this.salaryCalcBt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.salaryCalcBt);
            this.panel1.Controls.Add(this.changeInfoBt);
            this.panel1.Controls.Add(this.addBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(546, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 461);
            this.panel1.TabIndex = 0;
            // 
            // addBt
            // 
            this.addBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addBt.Location = new System.Drawing.Point(15, 13);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(111, 23);
            this.addBt.TabIndex = 0;
            this.addBt.Text = "Add Employee...";
            this.addBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBt.UseVisualStyleBackColor = false;
            // 
            // changeInfoBt
            // 
            this.changeInfoBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeInfoBt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.changeInfoBt.Location = new System.Drawing.Point(15, 42);
            this.changeInfoBt.Name = "changeInfoBt";
            this.changeInfoBt.Size = new System.Drawing.Size(111, 23);
            this.changeInfoBt.TabIndex = 1;
            this.changeInfoBt.Text = "Change  Info...";
            this.changeInfoBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeInfoBt.UseVisualStyleBackColor = false;
            // 
            // salaryCalcBt
            // 
            this.salaryCalcBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryCalcBt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.salaryCalcBt.Location = new System.Drawing.Point(15, 71);
            this.salaryCalcBt.Name = "salaryCalcBt";
            this.salaryCalcBt.Size = new System.Drawing.Size(111, 23);
            this.salaryCalcBt.TabIndex = 2;
            this.salaryCalcBt.Text = "Calculate Salary...";
            this.salaryCalcBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salaryCalcBt.UseVisualStyleBackColor = false;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button salaryCalcBt;
        private System.Windows.Forms.Button changeInfoBt;
        private System.Windows.Forms.Button addBt;

    }
}