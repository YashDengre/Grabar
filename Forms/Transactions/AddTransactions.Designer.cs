namespace Grabar.Forms.Transactions
{
    partial class AddTransactions
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
            this.ComboBoxPersons = new System.Windows.Forms.ComboBox();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxAmount = new System.Windows.Forms.TextBox();
            this.RadioBtnBorrow = new System.Windows.Forms.RadioButton();
            this.RadioBtnPaid = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.DateTimeTrxn = new System.Windows.Forms.DateTimePicker();
            this.LabelDate = new System.Windows.Forms.Label();
            this.RichTxtBoxDesc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ComboBoxPersons
            // 
            this.ComboBoxPersons.FormattingEnabled = true;
            this.ComboBoxPersons.Location = new System.Drawing.Point(216, 77);
            this.ComboBoxPersons.Name = "ComboBoxPersons";
            this.ComboBoxPersons.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPersons.TabIndex = 0;
            this.ComboBoxPersons.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPersons_SelectedIndexChanged);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Enabled = false;
            this.TxtBoxName.Location = new System.Drawing.Point(216, 164);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxName.TabIndex = 1;
            // 
            // TxtBoxAmount
            // 
            this.TxtBoxAmount.Location = new System.Drawing.Point(216, 205);
            this.TxtBoxAmount.Name = "TxtBoxAmount";
            this.TxtBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxAmount.TabIndex = 2;
            this.TxtBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxAmount_KeyPress);
            // 
            // RadioBtnBorrow
            // 
            this.RadioBtnBorrow.AutoSize = true;
            this.RadioBtnBorrow.Checked = true;
            this.RadioBtnBorrow.Location = new System.Drawing.Point(216, 241);
            this.RadioBtnBorrow.Name = "RadioBtnBorrow";
            this.RadioBtnBorrow.Size = new System.Drawing.Size(58, 17);
            this.RadioBtnBorrow.TabIndex = 3;
            this.RadioBtnBorrow.TabStop = true;
            this.RadioBtnBorrow.Text = "Borrow";
            this.RadioBtnBorrow.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPaid
            // 
            this.RadioBtnPaid.AutoSize = true;
            this.RadioBtnPaid.Location = new System.Drawing.Point(216, 265);
            this.RadioBtnPaid.Name = "RadioBtnPaid";
            this.RadioBtnPaid.Size = new System.Drawing.Size(46, 17);
            this.RadioBtnPaid.TabIndex = 4;
            this.RadioBtnPaid.TabStop = true;
            this.RadioBtnPaid.Text = "Paid";
            this.RadioBtnPaid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "To/From : Name of the Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transaction Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select Person";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(371, 361);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 11;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // DateTimeTrxn
            // 
            this.DateTimeTrxn.Location = new System.Drawing.Point(216, 123);
            this.DateTimeTrxn.Name = "DateTimeTrxn";
            this.DateTimeTrxn.Size = new System.Drawing.Size(200, 20);
            this.DateTimeTrxn.TabIndex = 12;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(93, 123);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(89, 13);
            this.LabelDate.TabIndex = 13;
            this.LabelDate.Text = "Transaction Date";
            // 
            // RichTxtBoxDesc
            // 
            this.RichTxtBoxDesc.Location = new System.Drawing.Point(216, 304);
            this.RichTxtBoxDesc.Name = "RichTxtBoxDesc";
            this.RichTxtBoxDesc.Size = new System.Drawing.Size(230, 51);
            this.RichTxtBoxDesc.TabIndex = 14;
            this.RichTxtBoxDesc.Text = "";
            // 
            // AddTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.RichTxtBoxDesc);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.DateTimeTrxn);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioBtnPaid);
            this.Controls.Add(this.RadioBtnBorrow);
            this.Controls.Add(this.TxtBoxAmount);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.ComboBoxPersons);
            this.Name = "AddTransactions";
            this.Text = "AddTransactions";
            this.Load += new System.EventHandler(this.AddTransactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxPersons;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TxtBoxAmount;
        private System.Windows.Forms.RadioButton RadioBtnBorrow;
        private System.Windows.Forms.RadioButton RadioBtnPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.DateTimePicker DateTimeTrxn;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.RichTextBox RichTxtBoxDesc;
    }
}