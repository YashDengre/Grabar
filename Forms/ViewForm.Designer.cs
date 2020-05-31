namespace Grabar.Forms
{
    partial class ViewForm
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
            this.DataGridOutput = new System.Windows.Forms.DataGridView();
            this.ViewSubmitButton = new System.Windows.Forms.Button();
            this.radioButtonFromToPeriod = new System.Windows.Forms.RadioButton();
            this.radioButtonALL = new System.Windows.Forms.RadioButton();
            this.radioButtonTopPeriod = new System.Windows.Forms.RadioButton();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.txtBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.txtBoxTotalAmountPlus = new System.Windows.Forms.TextBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTotalAmountPlus = new System.Windows.Forms.Label();
            this.BtnTotalAmountPlus = new System.Windows.Forms.Button();
            this.BtnTotalAmount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridOutput
            // 
            this.DataGridOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridOutput.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DataGridOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOutput.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridOutput.Location = new System.Drawing.Point(26, 94);
            this.DataGridOutput.Name = "DataGridOutput";
            this.DataGridOutput.Size = new System.Drawing.Size(518, 183);
            this.DataGridOutput.TabIndex = 0;
            // 
            // ViewSubmitButton
            // 
            this.ViewSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewSubmitButton.FlatAppearance.BorderSize = 0;
            this.ViewSubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ViewSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSubmitButton.ForeColor = System.Drawing.Color.LightGray;
            this.ViewSubmitButton.Location = new System.Drawing.Point(469, 283);
            this.ViewSubmitButton.Name = "ViewSubmitButton";
            this.ViewSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.ViewSubmitButton.TabIndex = 1;
            this.ViewSubmitButton.Text = "View";
            this.ViewSubmitButton.UseVisualStyleBackColor = true;
            this.ViewSubmitButton.Click += new System.EventHandler(this.ViewSubmitButton_Click);
            // 
            // radioButtonFromToPeriod
            // 
            this.radioButtonFromToPeriod.AutoSize = true;
            this.radioButtonFromToPeriod.FlatAppearance.BorderSize = 0;
            this.radioButtonFromToPeriod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonFromToPeriod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonFromToPeriod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonFromToPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonFromToPeriod.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromToPeriod.Location = new System.Drawing.Point(44, 16);
            this.radioButtonFromToPeriod.Name = "radioButtonFromToPeriod";
            this.radioButtonFromToPeriod.Size = new System.Drawing.Size(121, 20);
            this.radioButtonFromToPeriod.TabIndex = 2;
            this.radioButtonFromToPeriod.TabStop = true;
            this.radioButtonFromToPeriod.Text = "FROM - TO DATE";
            this.radioButtonFromToPeriod.UseVisualStyleBackColor = true;
            // 
            // radioButtonALL
            // 
            this.radioButtonALL.AutoSize = true;
            this.radioButtonALL.FlatAppearance.BorderSize = 0;
            this.radioButtonALL.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonALL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonALL.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonALL.Location = new System.Drawing.Point(44, 39);
            this.radioButtonALL.Name = "radioButtonALL";
            this.radioButtonALL.Size = new System.Drawing.Size(73, 20);
            this.radioButtonALL.TabIndex = 3;
            this.radioButtonALL.TabStop = true;
            this.radioButtonALL.Text = "Complete";
            this.radioButtonALL.UseVisualStyleBackColor = true;
            // 
            // radioButtonTopPeriod
            // 
            this.radioButtonTopPeriod.AutoSize = true;
            this.radioButtonTopPeriod.FlatAppearance.BorderSize = 0;
            this.radioButtonTopPeriod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonTopPeriod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonTopPeriod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButtonTopPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonTopPeriod.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonTopPeriod.Location = new System.Drawing.Point(44, 62);
            this.radioButtonTopPeriod.Name = "radioButtonTopPeriod";
            this.radioButtonTopPeriod.Size = new System.Drawing.Size(101, 20);
            this.radioButtonTopPeriod.TabIndex = 4;
            this.radioButtonTopPeriod.TabStop = true;
            this.radioButtonTopPeriod.Text = "Last 10 Details";
            this.radioButtonTopPeriod.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(218, 16);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFromDate.TabIndex = 5;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerToDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateTimePickerToDate.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.dateTimePickerToDate.CalendarTitleForeColor = System.Drawing.Color.Chocolate;
            this.dateTimePickerToDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dateTimePickerToDate.Location = new System.Drawing.Point(218, 39);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerToDate.TabIndex = 6;
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(181, 18);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(30, 13);
            this.labelFromDate.TabIndex = 7;
            this.labelFromDate.Text = "From";
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(181, 40);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 8;
            this.labelToDate.Text = "To";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClose.Location = new System.Drawing.Point(469, 16);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtBoxTotalAmount
            // 
            this.txtBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxTotalAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTotalAmount.Enabled = false;
            this.txtBoxTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTotalAmount.Location = new System.Drawing.Point(138, 283);
            this.txtBoxTotalAmount.Multiline = true;
            this.txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            this.txtBoxTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotalAmount.TabIndex = 10;
            this.txtBoxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTotalAmountPlus
            // 
            this.txtBoxTotalAmountPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxTotalAmountPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxTotalAmountPlus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTotalAmountPlus.Enabled = false;
            this.txtBoxTotalAmountPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalAmountPlus.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTotalAmountPlus.Location = new System.Drawing.Point(138, 309);
            this.txtBoxTotalAmountPlus.Multiline = true;
            this.txtBoxTotalAmountPlus.Name = "txtBoxTotalAmountPlus";
            this.txtBoxTotalAmountPlus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotalAmountPlus.TabIndex = 11;
            this.txtBoxTotalAmountPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotalAmount.Location = new System.Drawing.Point(41, 286);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(91, 15);
            this.labelTotalAmount.TabIndex = 12;
            this.labelTotalAmount.Text = "Total Amount";
            // 
            // labelTotalAmountPlus
            // 
            this.labelTotalAmountPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalAmountPlus.AutoSize = true;
            this.labelTotalAmountPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmountPlus.Location = new System.Drawing.Point(9, 307);
            this.labelTotalAmountPlus.Name = "labelTotalAmountPlus";
            this.labelTotalAmountPlus.Size = new System.Drawing.Size(123, 15);
            this.labelTotalAmountPlus.TabIndex = 13;
            this.labelTotalAmountPlus.Text = "Total Amount Plus";
            // 
            // BtnTotalAmountPlus
            // 
            this.BtnTotalAmountPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTotalAmountPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnTotalAmountPlus.FlatAppearance.BorderSize = 0;
            this.BtnTotalAmountPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnTotalAmountPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTotalAmountPlus.ForeColor = System.Drawing.Color.LightGray;
            this.BtnTotalAmountPlus.Location = new System.Drawing.Point(244, 309);
            this.BtnTotalAmountPlus.Name = "BtnTotalAmountPlus";
            this.BtnTotalAmountPlus.Size = new System.Drawing.Size(75, 20);
            this.BtnTotalAmountPlus.TabIndex = 14;
            this.BtnTotalAmountPlus.Text = "Calculate";
            this.BtnTotalAmountPlus.UseVisualStyleBackColor = false;
            this.BtnTotalAmountPlus.Click += new System.EventHandler(this.BtnTotalAmountPlus_Click);
            // 
            // BtnTotalAmount
            // 
            this.BtnTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnTotalAmount.FlatAppearance.BorderSize = 0;
            this.BtnTotalAmount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnTotalAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTotalAmount.ForeColor = System.Drawing.Color.LightGray;
            this.BtnTotalAmount.Location = new System.Drawing.Point(244, 284);
            this.BtnTotalAmount.Name = "BtnTotalAmount";
            this.BtnTotalAmount.Size = new System.Drawing.Size(75, 20);
            this.BtnTotalAmount.TabIndex = 15;
            this.BtnTotalAmount.Text = "Calculate";
            this.BtnTotalAmount.UseVisualStyleBackColor = false;
            this.BtnTotalAmount.Click += new System.EventHandler(this.BtnTotalAmount_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(568, 343);
            this.Controls.Add(this.BtnTotalAmount);
            this.Controls.Add(this.BtnTotalAmountPlus);
            this.Controls.Add(this.labelTotalAmountPlus);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.txtBoxTotalAmountPlus);
            this.Controls.Add(this.txtBoxTotalAmount);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.radioButtonTopPeriod);
            this.Controls.Add(this.radioButtonALL);
            this.Controls.Add(this.radioButtonFromToPeriod);
            this.Controls.Add(this.ViewSubmitButton);
            this.Controls.Add(this.DataGridOutput);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridOutput;
        private System.Windows.Forms.Button ViewSubmitButton;
        private System.Windows.Forms.RadioButton radioButtonFromToPeriod;
        private System.Windows.Forms.RadioButton radioButtonALL;
        private System.Windows.Forms.RadioButton radioButtonTopPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox txtBoxTotalAmount;
        private System.Windows.Forms.TextBox txtBoxTotalAmountPlus;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTotalAmountPlus;
        private System.Windows.Forms.Button BtnTotalAmountPlus;
        private System.Windows.Forms.Button BtnTotalAmount;
    }
}