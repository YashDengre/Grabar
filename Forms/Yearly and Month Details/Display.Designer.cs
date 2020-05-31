namespace Grabar.Forms.Yearly_and_Month_Details
{
    partial class Display
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
            this.NumUpDownSalaryAmount = new System.Windows.Forms.NumericUpDown();
            this.LabelAddSalary = new System.Windows.Forms.Label();
            this.BtnAddSalary = new System.Windows.Forms.Button();
            this.LabelHiddenMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSalaryAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUpDownSalaryAmount
            // 
            this.NumUpDownSalaryAmount.Location = new System.Drawing.Point(39, 45);
            this.NumUpDownSalaryAmount.Name = "NumUpDownSalaryAmount";
            this.NumUpDownSalaryAmount.Size = new System.Drawing.Size(120, 20);
            this.NumUpDownSalaryAmount.TabIndex = 0;
            // 
            // LabelAddSalary
            // 
            this.LabelAddSalary.AutoSize = true;
            this.LabelAddSalary.Location = new System.Drawing.Point(39, 26);
            this.LabelAddSalary.Name = "LabelAddSalary";
            this.LabelAddSalary.Size = new System.Drawing.Size(151, 13);
            this.LabelAddSalary.TabIndex = 1;
            this.LabelAddSalary.Text = "Salary Credit for Current Month";
            // 
            // BtnAddSalary
            // 
            this.BtnAddSalary.Location = new System.Drawing.Point(39, 72);
            this.BtnAddSalary.Name = "BtnAddSalary";
            this.BtnAddSalary.Size = new System.Drawing.Size(75, 23);
            this.BtnAddSalary.TabIndex = 2;
            this.BtnAddSalary.Text = "Add Salary";
            this.BtnAddSalary.UseVisualStyleBackColor = true;
            this.BtnAddSalary.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelHiddenMsg
            // 
            this.LabelHiddenMsg.AutoSize = true;
            this.LabelHiddenMsg.Location = new System.Drawing.Point(39, 102);
            this.LabelHiddenMsg.Name = "LabelHiddenMsg";
            this.LabelHiddenMsg.Size = new System.Drawing.Size(0, 13);
            this.LabelHiddenMsg.TabIndex = 3;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 404);
            this.Controls.Add(this.LabelHiddenMsg);
            this.Controls.Add(this.BtnAddSalary);
            this.Controls.Add(this.LabelAddSalary);
            this.Controls.Add(this.NumUpDownSalaryAmount);
            this.Name = "Display";
            this.Text = "Display";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownSalaryAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUpDownSalaryAmount;
        private System.Windows.Forms.Label LabelAddSalary;
        private System.Windows.Forms.Button BtnAddSalary;
        private System.Windows.Forms.Label LabelHiddenMsg;
    }
}