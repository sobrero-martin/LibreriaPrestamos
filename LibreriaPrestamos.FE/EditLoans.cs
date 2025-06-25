using DataAccess;
using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibreriaPrestamos.FE
{
    public partial class EditLoans : Form
    {
        public EditLoans()
        {
            InitializeComponent();
            dgvLoans.DataSource = LoanDB.LoadDGV();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string error = Business.InsertLoan(DateTime.Today, dtpReturnDate.Value, false, txtReaderDNI.Text, txtBookISBN.Text);

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvLoans.DataSource = Business.GetLoans();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            LoanDB.Delete(Convert.ToInt32(txtCode.Text));
            dgvLoans.DataSource = LoanDB.LoadDGV();
        }

        private void btTruncate_Click(object sender, EventArgs e)
        {
            LoanDB.Truncate();
            dgvLoans.DataSource = LoanDB.LoadDGV();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            Loan loan = new Loan(Convert.ToInt32(txtCode.Text), DateTime.Today, dtpReturnDate.Value, chkReturned.Checked, 0, "");
            LoanDB.Update(loan);

            dgvLoans.DataSource = LoanDB.LoadDGV();
        }

        private void chkReturned_CheckedChanged(object sender, EventArgs e)
        {
            Loan loan = new Loan(Convert.ToInt32(txtCode.Text), DateTime.Today, dtpReturnDate.Value, chkReturned.Checked, 0, "");
            LoanDB.UpdateReturned(loan);

            dgvLoans.DataSource = LoanDB.LoadDGV();
        }

    }
}
