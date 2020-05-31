namespace Grabar
{
    partial class Grabar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grabar));
            this.MainWindowPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.SideMenuBtnOne = new System.Windows.Forms.Panel();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconHeadNameLabel = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.MainWindowPanel.SuspendLayout();
            this.SideMenuPanel.SuspendLayout();
            this.SideMenuBtnOne.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainWindowPanel
            // 
            this.MainWindowPanel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MainWindowPanel.Controls.Add(this.button1);
            this.MainWindowPanel.Controls.Add(this.CloseButton);
            this.MainWindowPanel.Controls.Add(this.SideMenuPanel);
            this.MainWindowPanel.Controls.Add(this.TopLeftPanel);
            this.MainWindowPanel.ForeColor = System.Drawing.Color.Orange;
            this.MainWindowPanel.Location = new System.Drawing.Point(13, 12);
            this.MainWindowPanel.Name = "MainWindowPanel";
            this.MainWindowPanel.Size = new System.Drawing.Size(775, 473);
            this.MainWindowPanel.TabIndex = 0;
            this.MainWindowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindowPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(673, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "\\/";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(699, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.Controls.Add(this.ButtonFour);
            this.SideMenuPanel.Controls.Add(this.ButtonThree);
            this.SideMenuPanel.Controls.Add(this.SideMenuBtnOne);
            this.SideMenuPanel.Location = new System.Drawing.Point(4, 72);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(182, 398);
            this.SideMenuPanel.TabIndex = 1;
            this.SideMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SideMenuPanel_Paint);
            // 
            // ButtonFour
            // 
            this.ButtonFour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFour.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFour.ForeColor = System.Drawing.Color.Gray;
            this.ButtonFour.Location = new System.Drawing.Point(-5, 86);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(187, 39);
            this.ButtonFour.TabIndex = 2;
            this.ButtonFour.Text = "Next Option";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThree.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThree.ForeColor = System.Drawing.Color.Gray;
            this.ButtonThree.Location = new System.Drawing.Point(-5, 56);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(187, 34);
            this.ButtonThree.TabIndex = 4;
            this.ButtonThree.Text = "Next Option";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // SideMenuBtnOne
            // 
            this.SideMenuBtnOne.Controls.Add(this.ButtonOne);
            this.SideMenuBtnOne.Controls.Add(this.ButtonTwo);
            this.SideMenuBtnOne.Location = new System.Drawing.Point(-4, 3);
            this.SideMenuBtnOne.Name = "SideMenuBtnOne";
            this.SideMenuBtnOne.Size = new System.Drawing.Size(212, 58);
            this.SideMenuBtnOne.TabIndex = 2;
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ButtonOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOne.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOne.ForeColor = System.Drawing.Color.Gray;
            this.ButtonOne.Location = new System.Drawing.Point(-1, -3);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(187, 30);
            this.ButtonOne.TabIndex = 0;
            this.ButtonOne.Text = "View Records";
            this.ButtonOne.UseVisualStyleBackColor = false;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTwo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTwo.ForeColor = System.Drawing.Color.Gray;
            this.ButtonTwo.Location = new System.Drawing.Point(-1, 24);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(187, 34);
            this.ButtonTwo.TabIndex = 1;
            this.ButtonTwo.Text = "Add Records";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopLeftPanel.Controls.Add(this.label1);
            this.TopLeftPanel.Controls.Add(this.IconHeadNameLabel);
            this.TopLeftPanel.Controls.Add(this.IconBox);
            this.TopLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Size = new System.Drawing.Size(212, 65);
            this.TopLeftPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record Easily";
            // 
            // IconHeadNameLabel
            // 
            this.IconHeadNameLabel.AutoSize = true;
            this.IconHeadNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconHeadNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IconHeadNameLabel.Location = new System.Drawing.Point(84, 9);
            this.IconHeadNameLabel.Name = "IconHeadNameLabel";
            this.IconHeadNameLabel.Size = new System.Drawing.Size(89, 29);
            this.IconHeadNameLabel.TabIndex = 1;
            this.IconHeadNameLabel.Text = "Grabar";
            this.IconHeadNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IconHeadNameLabel.Click += new System.EventHandler(this.IconHeadName_Click);
            // 
            // IconBox
            // 
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(3, 0);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(75, 62);
            this.IconBox.TabIndex = 0;
            this.IconBox.TabStop = false;
            this.IconBox.UseWaitCursor = true;
            // 
            // Grabar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MainWindowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Grabar";
            this.Text = "Grabar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grabar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grabar_MouseMove);
            this.MainWindowPanel.ResumeLayout(false);
            this.SideMenuPanel.ResumeLayout(false);
            this.SideMenuBtnOne.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            this.TopLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainWindowPanel;
        private System.Windows.Forms.Panel TopLeftPanel;
        private System.Windows.Forms.Label IconHeadNameLabel;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel SideMenuBtnOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
    }
}

