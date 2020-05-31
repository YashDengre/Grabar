namespace Grabar.Forms.Manage_Person
{
    partial class VIewPersons
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
            this.DataGridViewPersons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPersons
            // 
            this.DataGridViewPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPersons.Location = new System.Drawing.Point(12, 42);
            this.DataGridViewPersons.MaximumSize = new System.Drawing.Size(600, 300);
            this.DataGridViewPersons.MinimumSize = new System.Drawing.Size(444, 250);
            this.DataGridViewPersons.Name = "DataGridViewPersons";
            this.DataGridViewPersons.ReadOnly = true;
            this.DataGridViewPersons.Size = new System.Drawing.Size(444, 250);
            this.DataGridViewPersons.TabIndex = 0;
            // 
            // VIewPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 343);
            this.Controls.Add(this.DataGridViewPersons);
            this.Name = "VIewPersons";
            this.Text = "View Persons";
            this.Load += new System.EventHandler(this.VIewPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPersons;
    }
}