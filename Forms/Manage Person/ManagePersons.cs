using Grabar.Forms.Manage_Person;
using System;
using System.Windows.Forms;

namespace Grabar.Forms
{
    public partial class ManagePersons : Form
    {
        private Form activeForm = null;

        public ManagePersons()
        {
            InitializeComponent();
            panelSide.AutoScroll = true;

        }

        private void OpenChildFormInContainer(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            OpenChildFormInContainer(new AddPersons());
        }

        private void BtnViewPerson_Click(object sender, EventArgs e)
        {
            OpenChildFormInContainer(new VIewPersons());

        }
    }
}
