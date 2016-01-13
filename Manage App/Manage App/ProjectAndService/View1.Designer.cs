namespace Manage_App.Employee
{
    partial class View1
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
            this.addEmpBt = new System.Windows.Forms.Button();
            this.changeInfoBt = new System.Windows.Forms.Button();
            this.calculateSlrBt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.calculateSlrBt);
            this.panel1.Controls.Add(this.changeInfoBt);
            this.panel1.Controls.Add(this.addEmpBt);
            this.panel1.Location = new System.Drawing.Point(522, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 437);
            this.panel1.TabIndex = 0;
            // 
            // addEmpBt
            // 
            this.addEmpBt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addEmpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpBt.Location = new System.Drawing.Point(33, 15);
            this.addEmpBt.Name = "addEmpBt";
            this.addEmpBt.Size = new System.Drawing.Size(150, 30);
            this.addEmpBt.TabIndex = 0;
            this.addEmpBt.Text = "Add new employee...";
            this.addEmpBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmpBt.UseVisualStyleBackColor = false;
            // 
            // changeInfoBt
            // 
            this.changeInfoBt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.changeInfoBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeInfoBt.Location = new System.Drawing.Point(33, 72);
            this.changeInfoBt.Name = "changeInfoBt";
            this.changeInfoBt.Size = new System.Drawing.Size(150, 30);
            this.changeInfoBt.TabIndex = 1;
            this.changeInfoBt.Text = "Change Employee Info...";
            this.changeInfoBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeInfoBt.UseVisualStyleBackColor = false;
            // 
            // calculateSlrBt
            // 
            this.calculateSlrBt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.calculateSlrBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateSlrBt.Location = new System.Drawing.Point(33, 130);
            this.calculateSlrBt.Name = "calculateSlrBt";
            this.calculateSlrBt.Size = new System.Drawing.Size(150, 30);
            this.calculateSlrBt.TabIndex = 2;
            this.calculateSlrBt.Text = "Calculate Salary...";
            this.calculateSlrBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculateSlrBt.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.Name = "View";
            this.Text = "View";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculateSlrBt;
        private System.Windows.Forms.Button changeInfoBt;
        private System.Windows.Forms.Button addEmpBt;
    }
}