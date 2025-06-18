using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace LibreriaPrestamos.FE
{
    public partial class EditReaders : Form
    {
        public EditReaders()
        {
            InitializeComponent();
     
            dgvReaders.DataSource = ReaderDB.LoadDGV(); 
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader(Convert.ToInt32(txtDNI.Text), txtName.Text, txtSurname.Text, txtContact.Text);
            ReaderDB.Insert(reader);
            dgvReaders.DataSource = ReaderDB.LoadDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            ReaderDB.Delete(Convert.ToInt32(txtDNI.Text));
            dgvReaders.DataSource = ReaderDB.LoadDGV();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader(Convert.ToInt32(txtDNI.Text), txtName.Text, txtSurname.Text, txtContact.Text);
            ReaderDB.Update(reader);
            dgvReaders.DataSource = ReaderDB.LoadDGV();
        }
    }
}
