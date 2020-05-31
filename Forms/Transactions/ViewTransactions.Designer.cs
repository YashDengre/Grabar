namespace Grabar.Forms.Transactions
{
    partial class ViewTransactions
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
            this.PanelSide = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmitViewTrxn = new System.Windows.Forms.Button();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.DateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerFromTo = new System.Windows.Forms.DateTimePicker();
            this.labelPeople = new System.Windows.Forms.Label();
            this.ComboBoxPersons = new System.Windows.Forms.ComboBox();
            this.DataGridTransactions = new System.Windows.Forms.DataGridView();
            this.RadioBtnFROMTO = new System.Windows.Forms.RadioButton();
            this.RadioBtnTo = new System.Windows.Forms.RadioButton();
            this.RadioBtnALL = new System.Windows.Forms.RadioButton();
            this.PanelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSide
            // 
            this.PanelSide.Controls.Add(this.RadioBtnALL);
            this.PanelSide.Controls.Add(this.RadioBtnTo);
            this.PanelSide.Controls.Add(this.RadioBtnFROMTO);
            this.PanelSide.Controls.Add(this.label2);
            this.PanelSide.Controls.Add(this.label1);
            this.PanelSide.Controls.Add(this.BtnSubmitViewTrxn);
            this.PanelSide.Controls.Add(this.labelDateTo);
            this.PanelSide.Controls.Add(this.labelDateFrom);
            this.PanelSide.Controls.Add(this.DateTimePickerTo);
            this.PanelSide.Controls.Add(this.DateTimePickerFromTo);
            this.PanelSide.Controls.Add(this.labelPeople);
            this.PanelSide.Controls.Add(this.ComboBoxPersons);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSide.Location = new System.Drawing.Point(0, 0);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(240, 486);
            this.PanelSide.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Combinations";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "For particular date please select \"Date\" \r\nand select your date in \"From\" option." +
    "\r\nAnd if you don\'t select any name then by \r\ndefault we will consider it as ALL." +
    "";
            // 
            // BtnSubmitViewTrxn
            // 
            this.BtnSubmitViewTrxn.Location = new System.Drawing.Point(18, 343);
            this.BtnSubmitViewTrxn.Name = "BtnSubmitViewTrxn";
            this.BtnSubmitViewTrxn.Size = new System.Drawing.Size(160, 23);
            this.BtnSubmitViewTrxn.TabIndex = 6;
            this.BtnSubmitViewTrxn.Text = "View Transactions";
            this.BtnSubmitViewTrxn.UseVisualStyleBackColor = true;
            this.BtnSubmitViewTrxn.Click += new System.EventHandler(this.BtnSubmitViewTrxn_Click);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(18, 131);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(20, 13);
            this.labelDateTo.TabIndex = 5;
            this.labelDateTo.Text = "To";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(20, 82);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(30, 13);
            this.labelDateFrom.TabIndex = 4;
            this.labelDateFrom.Text = "From";
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Location = new System.Drawing.Point(18, 147);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(177, 20);
            this.DateTimePickerTo.TabIndex = 3;
            // 
            // DateTimePickerFromTo
            // 
            this.DateTimePickerFromTo.Location = new System.Drawing.Point(18, 98);
            this.DateTimePickerFromTo.Name = "DateTimePickerFromTo";
            this.DateTimePickerFromTo.Size = new System.Drawing.Size(180, 20);
            this.DateTimePickerFromTo.TabIndex = 2;
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Location = new System.Drawing.Point(18, 27);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(40, 13);
            this.labelPeople.TabIndex = 1;
            this.labelPeople.Text = "People";
            // 
            // ComboBoxPersons
            // 
            this.ComboBoxPersons.FormattingEnabled = true;
            this.ComboBoxPersons.Location = new System.Drawing.Point(18, 43);
            this.ComboBoxPersons.Name = "ComboBoxPersons";
            this.ComboBoxPersons.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPersons.TabIndex = 0;
            // 
            // DataGridTransactions
            // 
            this.DataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTransactions.Location = new System.Drawing.Point(246, 43);
            this.DataGridTransactions.Name = "DataGridTransactions";
            this.DataGridTransactions.Size = new System.Drawing.Size(546, 279);
            this.DataGridTransactions.TabIndex = 1;
            this.DataGridTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RadioBtnFROMTO
            // 
            this.RadioBtnFROMTO.AutoSize = true;
            this.RadioBtnFROMTO.Location = new System.Drawing.Point(21, 195);
            this.RadioBtnFROMTO.Name = "RadioBtnFROMTO";
            this.RadioBtnFROMTO.Size = new System.Drawing.Size(80, 17);
            this.RadioBtnFROMTO.TabIndex = 9;
            this.RadioBtnFROMTO.TabStop = true;
            this.RadioBtnFROMTO.Text = "FROM - TO";
            this.RadioBtnFROMTO.UseVisualStyleBackColor = true;
            // 
            // RadioBtnTo
            // 
            this.RadioBtnTo.AutoSize = true;
            this.RadioBtnTo.Location = new System.Drawing.Point(21, 218);
            this.RadioBtnTo.Name = "RadioBtnTo";
            this.RadioBtnTo.Size = new System.Drawing.Size(48, 17);
            this.RadioBtnTo.TabIndex = 10;
            this.RadioBtnTo.TabStop = true;
            this.RadioBtnTo.Text = "Date";
            this.RadioBtnTo.UseVisualStyleBackColor = true;
            // 
            // RadioBtnALL
            // 
            this.RadioBtnALL.AutoSize = true;
            this.RadioBtnALL.Location = new System.Drawing.Point(21, 239);
            this.RadioBtnALL.Name = "RadioBtnALL";
            this.RadioBtnALL.Size = new System.Drawing.Size(44, 17);
            this.RadioBtnALL.TabIndex = 11;
            this.RadioBtnALL.TabStop = true;
            this.RadioBtnALL.Text = "ALL";
            this.RadioBtnALL.UseVisualStyleBackColor = true;
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 486);
            this.Controls.Add(this.DataGridTransactions);
            this.Controls.Add(this.PanelSide);
            this.Name = "ViewTransactions";
            this.Text = "ViewTransactions";
            this.Load += new System.EventHandler(this.ViewTransactions_Load);
            this.PanelSide.ResumeLayout(false);
            this.PanelSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.DateTimePicker DateTimePickerTo;
        private System.Windows.Forms.DateTimePicker DateTimePickerFromTo;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.ComboBox ComboBoxPersons;
        private System.Windows.Forms.Button BtnSubmitViewTrxn;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridTransactions;
        private System.Windows.Forms.RadioButton RadioBtnALL;
        private System.Windows.Forms.RadioButton RadioBtnTo;
        private System.Windows.Forms.RadioButton RadioBtnFROMTO;
    }
}