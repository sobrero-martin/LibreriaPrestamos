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
    public partial class EditBooks : Form
    {
        public EditBooks()
        {
            InitializeComponent();
            dgvBooks.DataSource = BookDB.LoadDGV();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {     
            string error = Business.InsertBook(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, txtCopies.Text);

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvBooks.DataSource = Business.GetBooks();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string error = Business.DeleteBook(txtISBN.Text);

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvBooks.DataSource = Business.GetBooks();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string error = Business.UpdateBook(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, txtCopies.Text);

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvBooks.DataSource = Business.GetBooks();
        }
    }
}
