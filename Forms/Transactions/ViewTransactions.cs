using GrabarBacked;
using Reposis.Grabar;
using Reposis.Grabar.Enums;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Grabar.Forms.Transactions
{
    public partial class ViewTransactions : Form
    {
        IGrabarDBCaller _GrabarDBCaller;
        static ViewPersonsResponse staticPersons;
        ViewTransactionsRequest _ViewTransactionsRequest;
        public ViewTransactions()
        {
            InitializeComponent();
            _GrabarDBCaller = new GrabarDBCaller();
        }

        private void ViewTransactions_Load(object sender, EventArgs e)
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
                    ComboBoxPersons.Items.Add("ALL");
                    ComboBoxPersons.AutoCompleteMode = AutoCompleteMode.Append;


                }
            }

        }

        private void checkedListBoxCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSubmitViewTrxn_Click(object sender, EventArgs e)
        {
            View_Transactions();
        }

        private void View_Transactions()
        {
            _ViewTransactionsRequest = new ViewTransactionsRequest();
            {
                if (RadioBtnALL.Enabled == true)
                    _ViewTransactionsRequest.TrxnComboType = ViewTrxnComboType.ALL;
                else if (RadioBtnFROMTO.Enabled == true)
                    _ViewTransactionsRequest.TrxnComboType = ViewTrxnComboType.FROMTO;
                else if (RadioBtnTo.Enabled == true)
                    _ViewTransactionsRequest.TrxnComboType = ViewTrxnComboType.DATE;
            }
            {
                if (ComboBoxPersons.Text.Equals(string.Empty) || ComboBoxPersons.Text.Equals("ALL"))
                    _ViewTransactionsRequest.PersonId = 0;
                else
                    _ViewTransactionsRequest.PersonId = staticPersons.Persons.FirstOrDefault(x => x.Name.Equals(ComboBoxPersons.Text.Trim())).PersonsId;
            }
            {
                _ViewTransactionsRequest.FromDate = DateTime.Parse(DateTime.Parse(DateTimePickerFromTo.Text).ToShortDateString());
                _ViewTransactionsRequest.ToDate = DateTime.Parse(DateTime.Parse(DateTimePickerTo.Text).ToShortDateString());
            }
            var response = _GrabarDBCaller.ViewTransactions(_ViewTransactionsRequest);
            if (response.Response.Code == 0)
            {
                foreach (var trxn in response.Transactions)
                {
                    trxn.Name = staticPersons.Persons.FirstOrDefault(x => x.PersonsId == trxn.PersonId).Name;
                }
                DataGridTransactions.DataSource = response.Transactions;
                DataGridTransactions.Columns["TransactionId"].Visible = false;
                DataGridTransactions.Columns["TrxnFlag"].Visible = false;

            }

            else
            {
                MessageBox.Show(response.Response.Code + ":" + response.Response.Message);
            }
        }
    }
}
