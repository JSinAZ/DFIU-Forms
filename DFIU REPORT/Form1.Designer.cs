namespace DFIU_REPORT
{
    partial class Form1
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
            this.mainTabPage = new System.Windows.Forms.TabControl();
            this.caseInformationTabPage = new System.Windows.Forms.TabPage();
            this.deviceCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            this.mainTabPage.SuspendLayout();
            this.caseInformationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.caseInformationTabPage);
            this.mainTabPage.Location = new System.Drawing.Point(4, 5);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.SelectedIndex = 0;
            this.mainTabPage.Size = new System.Drawing.Size(1300, 557);
            this.mainTabPage.TabIndex = 0;
            // 
            // caseInformationTabPage
            // 
            this.caseInformationTabPage.Controls.Add(this.debugTextBox);
            this.caseInformationTabPage.Controls.Add(this.deviceCountNumericUpDown);
            this.caseInformationTabPage.Location = new System.Drawing.Point(4, 22);
            this.caseInformationTabPage.Name = "caseInformationTabPage";
            this.caseInformationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.caseInformationTabPage.Size = new System.Drawing.Size(1292, 531);
            this.caseInformationTabPage.TabIndex = 0;
            this.caseInformationTabPage.Text = "Case Information";
            this.caseInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // deviceCountNumericUpDown
            // 
            this.deviceCountNumericUpDown.Location = new System.Drawing.Point(266, 141);
            this.deviceCountNumericUpDown.Name = "deviceCountNumericUpDown";
            this.deviceCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.deviceCountNumericUpDown.TabIndex = 0;
            this.deviceCountNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // debugTextBox
            // 
            this.debugTextBox.Location = new System.Drawing.Point(529, 349);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(522, 20);
            this.debugTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 574);
            this.Controls.Add(this.mainTabPage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabPage.ResumeLayout(false);
            this.caseInformationTabPage.ResumeLayout(false);
            this.caseInformationTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabPage;
        private System.Windows.Forms.TabPage caseInformationTabPage;
        private System.Windows.Forms.NumericUpDown deviceCountNumericUpDown;
        private System.Windows.Forms.TextBox debugTextBox;
    }
}