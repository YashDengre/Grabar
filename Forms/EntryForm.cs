using GrabarBacked;
using Reposis.Grabar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grabar.Forms
{
    public partial class EntryForm : Form
    {
        #region Properties
        List<RecordEntryRequest> recordEntries;
        RecordEntryRequest recordEntry;
        int rowCount = 0;
        //int rowIter = 0;
        GrabarDBCaller _grabarDbCaller;
        bool isCurrentDate = true;
        #endregion
        public EntryForm()
        {
            InitializeComponent();
            _grabarDbCaller = new GrabarDBCaller();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            this.CurrentDateBox.Text = DateTime.Now.ToShortDateString();


        }

        private void CurrentDateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            recordEntries = new List<RecordEntryRequest>();
            #region Commented -  For Loop for adding values in reuest
            //rowCount = DataGridInput?.Rows?.Count > 1 ? DataGridInput.Rows.Count - 1 : 0;
            //for (rowIter = 0; rowIter < rowCount; rowIter++)
            //{
            //    recordEntry = new RecordEntryRequest();
            //    recordEntry.ItemName = Convert.ToString(DataGridInput.Rows[0].Cells["ItemName"].Value);
            //    recordEntry.Amount = Convert.ToInt64(DataGridInput.Rows[rowIter].Cells["ItemAmount"].Value);
            //    recordEntry.Description = Convert.ToString(DataGridInput.Rows[rowIter].Cells["ItemDescription"].Value);
            //    recordEntry.AmountPlus = Convert.ToInt64(DataGridInput.Rows[rowIter].Cells["AmountPlus"].Value);
            //    recordEntries.Add(recordEntry);
            //}
            #endregion
            if (DateTime.TryParse(CurrentDateBox.Text, out DateTime date))
            {
                foreach (DataGridViewRow row in DataGridInput.Rows)
                {
                    if ((DataGridInput.Rows.Count - 1) == rowCount)
                    {
                        rowCount = 0;
                        break;
                    }
                    ++rowCount;
                    recordEntry = new RecordEntryRequest
                    {
                        ItemName = Convert.ToString(row.Cells["ItemName"].Value)
                    };
                    if (Int64.TryParse(Convert.ToString(row.Cells["ItemAmount"].Value), out long amount)
                        && Int64.TryParse(Convert.ToString(row.Cells["AmountPlus"].Value), out long amountPlus))
                    {
                        recordEntry.Amount = amount;
                        recordEntry.AmountPlus = amountPlus;
                    }
                    else
                    {
                        MessageBox.Show("Amount and Amount plus should be in digits only.");
                        break;
                    }
                    recordEntry.Amount = Convert.ToInt64(row.Cells["ItemAmount"].Value);
                    recordEntry.Description = Convert.ToString(row.Cells["ItemDescription"].Value);
                    recordEntry.Date = date;
                    recordEntries.Add(recordEntry);
                }
                if (recordEntries?.Count > 0)
                {
                    var response = _grabarDbCaller.PostRecords(recordEntries, isCurrentDate);
                    MessageBox.Show(response?.Response?.Message);
                }
            }
            else
            {
                MessageBox.Show("Amount and Amount plus should be in digits only.");

            }

        }

        private void OldEntryAskBtn_CheckedChanged(object sender, EventArgs e)
        {
            CurrentDateBox.Enabled = true;
            isCurrentDate = false;
        }

        private void DataGridInput_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(AmountColumn_KeyPress);
            if (DataGridInput.CurrentCell.ColumnIndex == 1 || DataGridInput.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                if (e.Control is TextBox tbox)
                {
                    tbox.KeyPress += new KeyPressEventHandler(AmountColumn_KeyPress);
                }
            }
        }
        private void AmountColumn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridInput_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ItemAmount"].Value = 0;
            e.Row.Cells["AmountPlus"].Value = 0;
        }
    }
}
