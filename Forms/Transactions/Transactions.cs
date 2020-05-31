using System.Windows.Forms;

namespace Grabar.Forms.Transactions
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void BtnAddTrxn_Click(object sender, System.EventArgs e)
        {
            AddTransactions AddTrxn = new AddTransactions();
            AddTrxn.Show();
        }

        private void BtnViewTrxn_Click(object sender, System.EventArgs e)
        {
            ViewTransactions ViewTrxn = new ViewTransactions();
            ViewTrxn.Show();
        }

        private void BtnEditTrxn_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnDeleteTrxn_Click(object sender, System.EventArgs e)
        {

        }
    }
}
