using GrabarBacked;
using System;
using System.Windows.Forms;

namespace Grabar.Forms.Manage_Person
{
    public partial class VIewPersons : Form
    {
        IGrabarDBCaller _GrabarDBCaller;
        public VIewPersons()
        {
            InitializeComponent();
            _GrabarDBCaller = new GrabarDBCaller();
        }

        private void VIewPersons_Load(object sender, EventArgs e)
        {
            View_Persons();
        }

        private void View_Persons()
        {
            var response = _GrabarDBCaller.ViewPersons();
            if (response?.Response.Code == 0)
            {
                if (response.Persons.Count > 0)
                {
                    DataGridViewPersons.DataSource = response.Persons;
                    DataGridViewPersons.Columns["Name"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No User is found!");
                }
            }
            else
            {
                MessageBox.Show("Due to some issue, we can not fulfill your request as of now!\n We will get back to you soon!");

            }
        }
    }
}
