namespace Grabar
{
    partial class GrabarControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrabarControl));
            this.panelSide = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.subPanelOther = new System.Windows.Forms.Panel();
            this.Button3 = new System.Windows.Forms.Button();
            this.BtnTransactions = new System.Windows.Forms.Button();
            this.BtnManagePersons = new System.Windows.Forms.Button();
            this.BtnOther = new System.Windows.Forms.Button();
            this.subPanelDetails = new System.Windows.Forms.Panel();
            this.SubBtnDetailsDelete = new System.Windows.Forms.Button();
            this.SubBtnDetailsView = new System.Windows.Forms.Button();
            this.SubBtnDetailsAdd = new System.Windows.Forms.Button();
            this.BtnDaily = new System.Windows.Forms.Button();
            this.panelSideTop = new System.Windows.Forms.Panel();
            this.labelSubTitle = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSide.SuspendLayout();
            this.subPanelOther.SuspendLayout();
            this.subPanelDetails.SuspendLayout();
            this.panelSideTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.Black;
            this.panelSide.Controls.Add(this.BtnHelp);
            this.panelSide.Controls.Add(this.subPanelOther);
            this.panelSide.Controls.Add(this.BtnOther);
            this.panelSide.Controls.Add(this.subPanelDetails);
            this.panelSide.Controls.Add(this.BtnDaily);
            this.panelSide.Controls.Add(this.panelSideTop);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 462);
            this.panelSide.TabIndex = 0;
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.ForeColor = System.Drawing.Color.LightGray;
            this.BtnHelp.Location = new System.Drawing.Point(0, 346);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnHelp.Size = new System.Drawing.Size(200, 36);
            this.BtnHelp.TabIndex = 5;
            this.BtnHelp.Text = "Help!";
            this.BtnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // subPanelOther
            // 
            this.subPanelOther.Controls.Add(this.Button3);
            this.subPanelOther.Controls.Add(this.BtnTransactions);
            this.subPanelOther.Controls.Add(this.BtnManagePersons);
            this.subPanelOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelOther.Location = new System.Drawing.Point(0, 246);
            this.subPanelOther.Name = "subPanelOther";
            this.subPanelOther.Size = new System.Drawing.Size(200, 100);
            this.subPanelOther.TabIndex = 4;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Black;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.Button3.Location = new System.Drawing.Point(0, 66);
            this.Button3.Name = "Button3";
            this.Button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Button3.Size = new System.Drawing.Size(200, 33);
            this.Button3.TabIndex = 6;
            this.Button3.Text = "button3";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // BtnTransactions
            // 
            this.BtnTransactions.BackColor = System.Drawing.Color.Black;
            this.BtnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransactions.FlatAppearance.BorderSize = 0;
            this.BtnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransactions.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransactions.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnTransactions.Location = new System.Drawing.Point(0, 33);
            this.BtnTransactions.Name = "BtnTransactions";
            this.BtnTransactions.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnTransactions.Size = new System.Drawing.Size(200, 33);
            this.BtnTransactions.TabIndex = 5;
            this.BtnTransactions.Text = "Transactions";
            this.BtnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransactions.UseVisualStyleBackColor = false;
            this.BtnTransactions.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnManagePersons
            // 
            this.BtnManagePersons.BackColor = System.Drawing.Color.Black;
            this.BtnManagePersons.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManagePersons.FlatAppearance.BorderSize = 0;
            this.BtnManagePersons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnManagePersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagePersons.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManagePersons.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnManagePersons.Location = new System.Drawing.Point(0, 0);
            this.BtnManagePersons.Name = "BtnManagePersons";
            this.BtnManagePersons.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnManagePersons.Size = new System.Drawing.Size(200, 33);
            this.BtnManagePersons.TabIndex = 4;
            this.BtnManagePersons.Text = "Manage People";
            this.BtnManagePersons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManagePersons.UseVisualStyleBackColor = false;
            this.BtnManagePersons.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnOther
            // 
            this.BtnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOther.FlatAppearance.BorderSize = 0;
            this.BtnOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BtnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOther.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOther.ForeColor = System.Drawing.Color.LightGray;
            this.BtnOther.Location = new System.Drawing.Point(0, 210);
            this.BtnOther.Name = "BtnOther";
            this.BtnOther.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnOther.Size = new System.Drawing.Size(200, 36);
            this.BtnOther.TabIndex = 3;
            this.BtnOther.Text = "Other Options";
            this.BtnOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOther.UseVisualStyleBackColor = false;
            this.BtnOther.Click += new System.EventHandler(this.BtnOther_Click);
            // 
            // subPanelDetails
            // 
            this.subPanelDetails.Controls.Add(this.SubBtnDetailsDelete);
            this.subPanelDetails.Controls.Add(this.SubBtnDetailsView);
            this.subPanelDetails.Controls.Add(this.SubBtnDetailsAdd);
            this.subPanelDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelDetails.Location = new System.Drawing.Point(0, 110);
            this.subPanelDetails.Name = "subPanelDetails";
            this.subPanelDetails.Size = new System.Drawing.Size(200, 100);
            this.subPanelDetails.TabIndex = 2;
            // 
            // SubBtnDetailsDelete
            // 
            this.SubBtnDetailsDelete.BackColor = System.Drawing.Color.Black;
            this.SubBtnDetailsDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnDetailsDelete.FlatAppearance.BorderSize = 0;
            this.SubBtnDetailsDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SubBtnDetailsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnDetailsDelete.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtnDetailsDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.SubBtnDetailsDelete.Location = new System.Drawing.Point(0, 66);
            this.SubBtnDetailsDelete.Name = "SubBtnDetailsDelete";
            this.SubBtnDetailsDelete.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SubBtnDetailsDelete.Size = new System.Drawing.Size(200, 33);
            this.SubBtnDetailsDelete.TabIndex = 3;
            this.SubBtnDetailsDelete.Text = "Delete Details";
            this.SubBtnDetailsDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnDetailsDelete.UseVisualStyleBackColor = false;
            this.SubBtnDetailsDelete.Click += new System.EventHandler(this.SubBtnDetailsDelete_Click);
            // 
            // SubBtnDetailsView
            // 
            this.SubBtnDetailsView.BackColor = System.Drawing.Color.Black;
            this.SubBtnDetailsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnDetailsView.FlatAppearance.BorderSize = 0;
            this.SubBtnDetailsView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SubBtnDetailsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnDetailsView.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtnDetailsView.ForeColor = System.Drawing.Color.Gainsboro;
            this.SubBtnDetailsView.Location = new System.Drawing.Point(0, 33);
            this.SubBtnDetailsView.Name = "SubBtnDetailsView";
            this.SubBtnDetailsView.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SubBtnDetailsView.Size = new System.Drawing.Size(200, 33);
            this.SubBtnDetailsView.TabIndex = 2;
            this.SubBtnDetailsView.Text = "View Details";
            this.SubBtnDetailsView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnDetailsView.UseVisualStyleBackColor = false;
            this.SubBtnDetailsView.Click += new System.EventHandler(this.SubBtnDetailsView_Click);
            // 
            // SubBtnDetailsAdd
            // 
            this.SubBtnDetailsAdd.BackColor = System.Drawing.Color.Black;
            this.SubBtnDetailsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnDetailsAdd.FlatAppearance.BorderSize = 0;
            this.SubBtnDetailsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SubBtnDetailsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnDetailsAdd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubBtnDetailsAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.SubBtnDetailsAdd.Location = new System.Drawing.Point(0, 0);
            this.SubBtnDetailsAdd.Name = "SubBtnDetailsAdd";
            this.SubBtnDetailsAdd.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SubBtnDetailsAdd.Size = new System.Drawing.Size(200, 33);
            this.SubBtnDetailsAdd.TabIndex = 1;
            this.SubBtnDetailsAdd.Text = "Add Details";
            this.SubBtnDetailsAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnDetailsAdd.UseVisualStyleBackColor = false;
            this.SubBtnDetailsAdd.Click += new System.EventHandler(this.SubBtnDetailsAdd_Click);
            // 
            // BtnDaily
            // 
            this.BtnDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDaily.FlatAppearance.BorderSize = 0;
            this.BtnDaily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BtnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDaily.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDaily.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDaily.Location = new System.Drawing.Point(0, 74);
            this.BtnDaily.Name = "BtnDaily";
            this.BtnDaily.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnDaily.Size = new System.Drawing.Size(200, 36);
            this.BtnDaily.TabIndex = 1;
            this.BtnDaily.Text = "Details";
            this.BtnDaily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDaily.UseVisualStyleBackColor = false;
            this.BtnDaily.Click += new System.EventHandler(this.BtnDaily_Click);
            // 
            // panelSideTop
            // 
            this.panelSideTop.Controls.Add(this.labelSubTitle);
            this.panelSideTop.Controls.Add(this.LabelTitle);
            this.panelSideTop.Controls.Add(this.pictureBoxIcon);
            this.panelSideTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideTop.Location = new System.Drawing.Point(0, 0);
            this.panelSideTop.Name = "panelSideTop";
            this.panelSideTop.Size = new System.Drawing.Size(200, 74);
            this.panelSideTop.TabIndex = 0;
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.AutoSize = true;
            this.labelSubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelSubTitle.Location = new System.Drawing.Point(80, 43);
            this.labelSubTitle.Name = "labelSubTitle";
            this.labelSubTitle.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelSubTitle.Size = new System.Drawing.Size(94, 13);
            this.labelSubTitle.TabIndex = 1;
            this.labelSubTitle.Text = "By DexJar";
            this.labelSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitle.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelTitle.Location = new System.Drawing.Point(80, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Padding = new System.Windows.Forms.Padding(10);
            this.LabelTitle.Size = new System.Drawing.Size(91, 43);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Grabar";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(80, 74);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.pictureBoxIcon_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(200, 381);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(584, 81);
            this.panelBottom.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(584, 381);
            this.panelContainer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GrabarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "GrabarControl";
            this.Text = "Grabar";
            this.panelSide.ResumeLayout(false);
            this.subPanelOther.ResumeLayout(false);
            this.subPanelDetails.ResumeLayout(false);
            this.panelSideTop.ResumeLayout(false);
            this.panelSideTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button BtnDaily;
        private System.Windows.Forms.Panel panelSideTop;
        private System.Windows.Forms.Panel subPanelDetails;
        private System.Windows.Forms.Button SubBtnDetailsDelete;
        private System.Windows.Forms.Button SubBtnDetailsView;
        private System.Windows.Forms.Button SubBtnDetailsAdd;
        private System.Windows.Forms.Panel subPanelOther;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button BtnTransactions;
        private System.Windows.Forms.Button BtnManagePersons;
        private System.Windows.Forms.Button BtnOther;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelSubTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}