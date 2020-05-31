namespace Grabar.Forms
{
    partial class ManagePersons
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelSide = new System.Windows.Forms.Panel();
            this.BtnDeletePerson = new System.Windows.Forms.Button();
            this.BtnEditPerson = new System.Windows.Forms.Button();
            this.BtnViewPerson = new System.Windows.Forms.Button();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.BtnAddPersons = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.BtnDeletePerson);
            this.panelSide.Controls.Add(this.BtnEditPerson);
            this.panelSide.Controls.Add(this.BtnViewPerson);
            this.panelSide.Controls.Add(this.BtnAddPerson);
            this.panelSide.Controls.Add(this.BtnAddPersons);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(100, 380);
            this.panelSide.TabIndex = 3;
            // 
            // BtnDeletePerson
            // 
            this.BtnDeletePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.BtnDeletePerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeletePerson.FlatAppearance.BorderSize = 0;
            this.BtnDeletePerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnDeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDeletePerson.Location = new System.Drawing.Point(0, 285);
            this.BtnDeletePerson.Name = "BtnDeletePerson";
            this.BtnDeletePerson.Size = new System.Drawing.Size(100, 95);
            this.BtnDeletePerson.TabIndex = 4;
            this.BtnDeletePerson.Text = "Delete Person";
            this.BtnDeletePerson.UseVisualStyleBackColor = false;
            // 
            // BtnEditPerson
            // 
            this.BtnEditPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.BtnEditPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditPerson.FlatAppearance.BorderSize = 0;
            this.BtnEditPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEditPerson.Location = new System.Drawing.Point(0, 190);
            this.BtnEditPerson.Name = "BtnEditPerson";
            this.BtnEditPerson.Size = new System.Drawing.Size(100, 95);
            this.BtnEditPerson.TabIndex = 3;
            this.BtnEditPerson.Text = "Edit Persons";
            this.BtnEditPerson.UseVisualStyleBackColor = false;
            // 
            // BtnViewPerson
            // 
            this.BtnViewPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.BtnViewPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnViewPerson.FlatAppearance.BorderSize = 0;
            this.BtnViewPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnViewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnViewPerson.Location = new System.Drawing.Point(0, 95);
            this.BtnViewPerson.Name = "BtnViewPerson";
            this.BtnViewPerson.Size = new System.Drawing.Size(100, 95);
            this.BtnViewPerson.TabIndex = 2;
            this.BtnViewPerson.Text = "View Persons";
            this.BtnViewPerson.UseVisualStyleBackColor = false;
            this.BtnViewPerson.Click += new System.EventHandler(this.BtnViewPerson_Click);
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(83)))), ((int)(((byte)(96)))));
            this.BtnAddPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddPerson.FlatAppearance.BorderSize = 0;
            this.BtnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAddPerson.Location = new System.Drawing.Point(0, 0);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(100, 95);
            this.BtnAddPerson.TabIndex = 1;
            this.BtnAddPerson.Text = "Add Persons";
            this.BtnAddPerson.UseVisualStyleBackColor = false;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // BtnAddPersons
            // 
            this.BtnAddPersons.Location = new System.Drawing.Point(0, 0);
            this.BtnAddPersons.Name = "BtnAddPersons";
            this.BtnAddPersons.Size = new System.Drawing.Size(100, 76);
            this.BtnAddPersons.TabIndex = 0;
            this.BtnAddPersons.Text = "button1";
            this.BtnAddPersons.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(100, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(522, 380);
            this.panelContainer.TabIndex = 4;
            // 
            // ManagePersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(622, 380);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSide);
            this.Name = "ManagePersons";
            this.Text = "Manage Persons";
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button BtnEditPerson;
        private System.Windows.Forms.Button BtnViewPerson;
        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.Button BtnAddPersons;
        private System.Windows.Forms.Button BtnDeletePerson;
        private System.Windows.Forms.Panel panelContainer;
    }
}