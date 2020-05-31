namespace Grabar.Forms.Manage_Person
{
    partial class AddPersons
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
            this.BtnAddPersonSubmit = new System.Windows.Forms.Button();
            this.DataGridAddPersons = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBoxDate = new System.Windows.Forms.TextBox();
            this.PanelContainerAddUser = new System.Windows.Forms.Panel();
            this.LabelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAddPersons)).BeginInit();
            this.PanelContainerAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddPersonSubmit
            // 
            this.BtnAddPersonSubmit.Location = new System.Drawing.Point(260, 251);
            this.BtnAddPersonSubmit.Name = "BtnAddPersonSubmit";
            this.BtnAddPersonSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnAddPersonSubmit.TabIndex = 3;
            this.BtnAddPersonSubmit.Text = "Add Persons";
            this.BtnAddPersonSubmit.UseVisualStyleBackColor = true;
            this.BtnAddPersonSubmit.Click += new System.EventHandler(this.BtnAddPersonSubmit_Click);
            // 
            // DataGridAddPersons
            // 
            this.DataGridAddPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAddPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName});
            this.DataGridAddPersons.Location = new System.Drawing.Point(89, 83);
            this.DataGridAddPersons.Name = "DataGridAddPersons";
            this.DataGridAddPersons.Size = new System.Drawing.Size(246, 162);
            this.DataGridAddPersons.TabIndex = 2;
            this.DataGridAddPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAddPersons_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // TxtBoxDate
            // 
            this.TxtBoxDate.Location = new System.Drawing.Point(235, 46);
            this.TxtBoxDate.Name = "TxtBoxDate";
            this.TxtBoxDate.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxDate.TabIndex = 0;
            // 
            // PanelContainerAddUser
            // 
            this.PanelContainerAddUser.Controls.Add(this.BtnAddPersonSubmit);
            this.PanelContainerAddUser.Controls.Add(this.DataGridAddPersons);
            this.PanelContainerAddUser.Controls.Add(this.TxtBoxDate);
            this.PanelContainerAddUser.Controls.Add(this.LabelDate);
            this.PanelContainerAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainerAddUser.Location = new System.Drawing.Point(0, 0);
            this.PanelContainerAddUser.Name = "PanelContainerAddUser";
            this.PanelContainerAddUser.Size = new System.Drawing.Size(465, 343);
            this.PanelContainerAddUser.TabIndex = 5;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(180, 46);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(30, 13);
            this.LabelDate.TabIndex = 1;
            this.LabelDate.Text = "Date";
            // 
            // AddPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 343);
            this.Controls.Add(this.PanelContainerAddUser);
            this.Name = "AddPersons";
            this.Text = "Add Persons";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAddPersons)).EndInit();
            this.PanelContainerAddUser.ResumeLayout(false);
            this.PanelContainerAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddPersonSubmit;
        private System.Windows.Forms.DataGridView DataGridAddPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.TextBox TxtBoxDate;
        private System.Windows.Forms.Panel PanelContainerAddUser;
        private System.Windows.Forms.Label LabelDate;
    }
}