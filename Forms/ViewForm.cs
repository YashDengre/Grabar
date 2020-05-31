using GrabarBacked;
using Reposis.Grabar;
using Reposis.Grabar.Enums;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Grabar.Forms
{
    public partial class ViewForm : Form
    {
        #region Properties
        DateTime FromDate;
        DateTime ToDate;
        GrabarDBCaller _grabarDBCaller;
        long _TotalAmount = 0;
        long _TotalAmountPlus = 0;
        #endregion
        public ViewForm()
        {
            InitializeComponent();
            _grabarDBCaller = new GrabarDBCaller();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // DataGridOutput.Enabled = false;

        }


        private void ViewSubmitButton_Click(object sender, EventArgs e)
        {
            ViewRecordsRequest reqeust = new ViewRecordsRequest
            {
                DateFrom = new DateTime(2020, 01, 01),
                DateTo = new DateTime(2020, 01, 01)
            };
            if (radioButtonFromToPeriod.Checked)
            {
                if (DateTime.TryParse(dateTimePickerFromDate.Text, out FromDate) &&
                     DateTime.TryParse(dateTimePickerToDate.Text, out ToDate))
                {
                    reqeust.DateFrom = DateTime.Parse(FromDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    reqeust.DateTo = DateTime.Parse(ToDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                }
                reqeust.Period = PeriodType.FROMDATE;
            }
            else if (radioButtonALL.Checked)
            {
                reqeust.Period = PeriodType.ALL;

            }
            else if (radioButtonTopPeriod.Checked)
            {
                reqeust.Period = PeriodType.TOP;
            }
            else
            {
                reqeust.Period = PeriodType.ALL;
            }

            ViewDetails(reqeust);
        }
        private void ViewDetails(ViewRecordsRequest request)
        {
            var response = _grabarDBCaller.ViewRecords(request);
            DataGridOutput.ForeColor = System.Drawing.Color.Black;
            DataGridOutput.DataSource = response.Records;
            DataGridOutput.Columns["ID"].Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTotalAmount_Click(object sender, EventArgs e)
        {
            _TotalAmount = 0;
            foreach (DataGridViewRow row in DataGridOutput.Rows)
            {
                _TotalAmount += Convert.ToInt64(row.Cells["AMOUNT"].Value);
            }
            txtBoxTotalAmount.Text = Convert.ToString(_TotalAmount);
        }

        private void BtnTotalAmountPlus_Click(object sender, EventArgs e)
        {
            _TotalAmountPlus = 0;
            foreach (DataGridViewRow row in DataGridOutput.Rows)
            {
                _TotalAmountPlus += Convert.ToInt64(row.Cells["AMOUNT_PLUS"].Value);
            }
            txtBoxTotalAmountPlus.Text = Convert.ToString(_TotalAmountPlus);
        }
    }
}
