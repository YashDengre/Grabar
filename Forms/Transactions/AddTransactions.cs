using GrabarBacked;
using Reposis.Grabar;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Grabar.Forms.Transactions
{
    public partial class AddTransactions : Form
    {
        #region Properties
        IGrabarDBCaller _GrabarDBCaller;
        private static ViewPersonsResponse staticPersons;
        AddTransctionRequest AddTransactionRequest;
        #endregion
        public AddTransactions()
        {
            InitializeComponent();
            _GrabarDBCaller = new GrabarDBCaller();
        }

        private void AddTransactions_Load(object sender, System.EventArgs e)
        {
            InitilizeComboBoxAndTextBoxAmount();

        }

        private void InitilizeComboBoxAndTextBoxAmount()
        {
            var response = _GrabarDBCaller.ViewPersons();
            if (response.Response.Code == 0)
            {
                if (response.Persons.Count > 0)
                {
                    staticPersons = response;
                    ComboBoxPersons.Items.AddRange(response.Persons.Select(person => person.First_Name + " " + person.Last_Name).ToArray());
                }
            }
            TxtBoxAmount.Text = 0.ToString();
        }

        private void ComboBoxPersons_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            TxtBoxName.Text = ComboBoxPersons.Text;
        }

        private void TxtBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            SubmitTransaction();
        }

        private void SubmitTransaction()
        {
            AddTransactionRequest = new AddTransctionRequest()
            {
                Transaction = new Transaction()
                {
                    Amount_Borrow = 0,
                    Amount_Paid = 0
                }
            };
            DateTime date;
            if (DateTime.TryParse(DateTimeTrxn.Text, out date))
            {
                AddTransactionRequest.Transaction.Date = DateTime.Parse(date.ToShortDateString());
                AddTransactionRequest.Transaction.Name = TxtBoxName.Text;
                AddTransactionRequest.Transaction.Description = RichTxtBoxDesc.Text;
                AddTransactionRequest.Transaction.PersonId = staticPersons.Persons.FirstOrDefault(prsn => prsn.Name.Equals(TxtBoxName.Text)).PersonsId;
                if (RadioBtnBorrow.Checked)
                {
                    AddTransactionRequest.Transaction.Amount_Borrow = Convert.ToInt64(TxtBoxAmount.Text);
                    AddTransactionRequest.Transaction.TrxnFlag = 0;
                }
                else
                {
                    AddTransactionRequest.Transaction.Amount_Paid = Convert.ToInt64(TxtBoxAmount.Text);
                    AddTransactionRequest.Transaction.TrxnFlag = 1;

                }
                var response = _GrabarDBCaller.AddTransaction(AddTransactionRequest);
                if (response?.Response != null)
                {
                    MessageBox.Show(response.Response.Code + " : " + response.Response.Message);
                }
            }
        }

    }
}
