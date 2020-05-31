using GrabarBacked;
using Reposis.Grabar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grabar.Forms.Manage_Person
{
    public partial class AddPersons : Form
    {
        #region Properties    
        AddPersonsRequest addPersonRequest;
        Reposis.Grabar.AddPersons addPerson;
        IGrabarDBCaller _GrabarCaller;
        int _rowCount = 0;
        #endregion
        public AddPersons()
        {
            InitializeComponent();
            _GrabarCaller = new GrabarDBCaller();
            TxtBoxDate.Text = DateTime.Now.ToShortDateString();
            TxtBoxDate.Enabled = false;
        }

        private void DataGridAddPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddPersonSubmit_Click(object sender, EventArgs e)
        {
            AddPersonsCall();
        }

        private void AddPersonsCall()
        {
            addPersonRequest = new AddPersonsRequest()
            {
                Persons = new List<Reposis.Grabar.AddPersons>()
            };

            if (DateTime.TryParse(TxtBoxDate.Text, out DateTime date))
            {
                foreach (DataGridViewRow row in DataGridAddPersons.Rows)
                {
                    if ((DataGridAddPersons.Rows.Count - 1) == _rowCount)
                    {
                        _rowCount = 0;
                        break;
                    }
                    ++_rowCount;

                    addPerson = new Reposis.Grabar.AddPersons()
                    {
                        First_Name = Convert.ToString(row.Cells["FirstName"].Value).ToUpper(),
                        Last_Name = Convert.ToString(row.Cells["LastName"].Value).ToUpper(),
                        Date_Of_Add = date,
                        Total_Due_Amount = 0,
                        Total_Owe_Amount = 0
                    };
                    addPersonRequest.Persons.Add(addPerson);
                }
            }
            if (addPersonRequest?.Persons?.Count > 0)
            {
                var response = _GrabarCaller.AddPerson(addPersonRequest);
                MessageBox.Show("Message: " + response.Response.Message);
            }
        }
    }
}


