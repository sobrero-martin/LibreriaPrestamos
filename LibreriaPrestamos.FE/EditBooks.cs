using DataAccess;
using Entities;
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

            if (Convert.ToInt32(txtCopies.Text) > 0)
            {
                Book book = new Book(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, Convert.ToInt32(txtCopies.Text), true);
                BookDB.Insert(book);
            }
            else
            {
                Book book = new Book(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, Convert.ToInt32(txtCopies.Text), false);
                BookDB.Insert(book);
            }

            dgvBooks.DataSource = BookDB.LoadDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            BookDB.Delete(txtISBN.Text);
            dgvBooks.DataSource = BookDB.LoadDGV();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCopies.Text) > 0)
            {
                Book book = new Book(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, Convert.ToInt32(txtCopies.Text), true);
                BookDB.Update(book);
            }
            else
            {
                Book book = new Book(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, Convert.ToInt32(txtCopies.Text), false);
                BookDB.Update(book);
            }

            dgvBooks.DataSource = BookDB.LoadDGV();
        }
    }
}
