using GrabarBacked;
using System;
using System.Windows.Forms;

namespace Grabar.Forms.Yearly_and_Month_Details
{

    public partial class Display : Form
    {
        public GrabarDBCaller _GrabarDBCaller;
        public Display()
        {
            InitializeComponent();
            _GrabarDBCaller = new GrabarDBCaller();
            IsSalaryAdded();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void IsSalaryAdded()
        {
            var response = _GrabarDBCaller.ViewMonthDetails();
            if (response.Response.Code == 0)
            {
                var CurrentMonth = DateTime.Now.Month;
                var isCurrentMonthSalaryExists = response.MonthDetails.Exists(x => x.MonthCode == CurrentMonth && !string.IsNullOrEmpty(Convert.ToString(x.SalaryAMount)));
                if (isCurrentMonthSalaryExists)
                {
                    BtnAddSalary.Enabled = false;
                    NumUpDownSalaryAmount.Enabled = false;
                    LabelHiddenMsg.Text = "Salary is already added for Current Month";
                    LabelHiddenMsg.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }

}
