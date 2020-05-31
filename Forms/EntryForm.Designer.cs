namespace Grabar.Forms
{
    partial class EntryForm
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
            this.CurrentDateBox = new System.Windows.Forms.TextBox();
            this.DateLabelOne = new System.Windows.Forms.Label();
            this.DataGridInput = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPlus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.OldEntryAskBtn = new System.Windows.Forms.RadioButton();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInput)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentDateBox
            // 
            this.CurrentDateBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.CurrentDateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentDateBox.Enabled = false;
            this.CurrentDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDateBox.ForeColor = System.Drawing.Color.White;
            this.CurrentDateBox.Location = new System.Drawing.Point(278, 33);
            this.CurrentDateBox.Multiline = true;
            this.CurrentDateBox.Name = "CurrentDateBox";
            this.CurrentDateBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentDateBox.TabIndex = 0;
            this.CurrentDateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentDateBox.TextChanged += new System.EventHandler(this.CurrentDateBox_TextChanged);
            // 
            // DateLabelOne
            // 
            this.DateLabelOne.AutoSize = true;
            this.DateLabelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabelOne.ForeColor = System.Drawing.SystemColors.Control;
            this.DateLabelOne.Location = new System.Drawing.Point(182, 36);
            this.DateLabelOne.Name = "DateLabelOne";
            this.DateLabelOne.Size = new System.Drawing.Size(79, 13);
            this.DateLabelOne.TabIndex = 1;
            this.DateLabelOne.Text = "Current Date";
            // 
            // DataGridInput
            // 
            this.DataGridInput.AllowUserToOrderColumns = true;
            this.DataGridInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridInput.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DataGridInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemAmount,
            this.ItemDescription,
            this.AmountPlus});
            this.DataGridInput.Location = new System.Drawing.Point(50, 78);
            this.DataGridInput.Name = "DataGridInput";
            this.DataGridInput.Size = new System.Drawing.Size(442, 210);
            this.DataGridInput.TabIndex = 2;
            this.DataGridInput.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridInput_DefaultValuesNeeded);
            this.DataGridInput.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridInput_EditingControlShowing);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ToolTipText = "Name of Item/Thiing/Reason";
            // 
            // ItemAmount
            // 
            this.ItemAmount.HeaderText = "Amount";
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.ToolTipText = "Amount Spend";
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ToolTipText = "Full Description";
            this.ItemDescription.Width = 85;
            // 
            // AmountPlus
            // 
            this.AmountPlus.HeaderText = "Amount +";
            this.AmountPlus.Name = "AmountPlus";
            this.AmountPlus.ToolTipText = "Amount Borrowed/Received";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitBtn.BackColor = System.Drawing.Color.Black;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.SubmitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitBtn.Location = new System.Drawing.Point(417, 294);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // OldEntryAskBtn
            // 
            this.OldEntryAskBtn.AutoSize = true;
            this.OldEntryAskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OldEntryAskBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.OldEntryAskBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OldEntryAskBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OldEntryAskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OldEntryAskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldEntryAskBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.OldEntryAskBtn.Location = new System.Drawing.Point(64, 34);
            this.OldEntryAskBtn.Name = "OldEntryAskBtn";
            this.OldEntryAskBtn.Size = new System.Drawing.Size(83, 17);
            this.OldEntryAskBtn.TabIndex = 4;
            this.OldEntryAskBtn.TabStop = true;
            this.OldEntryAskBtn.Text = "Old Entry?";
            this.OldEntryAskBtn.UseVisualStyleBackColor = false;
            this.OldEntryAskBtn.CheckedChanged += new System.EventHandler(this.OldEntryAskBtn_CheckedChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClose.Location = new System.Drawing.Point(433, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(568, 347);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.OldEntryAskBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DataGridInput);
            this.Controls.Add(this.DateLabelOne);
            this.Controls.Add(this.CurrentDateBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentDateBox;
        private System.Windows.Forms.Label DateLabelOne;
        private System.Windows.Forms.DataGridView DataGridInput;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.RadioButton OldEntryAskBtn;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPlus;
    }
}