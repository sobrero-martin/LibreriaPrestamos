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
using Logic;

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
            string error = Business.InsertReader(txtDNI.Text, txtName.Text, txtSurname.Text, txtContact.Text);

            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvReaders.DataSource = Business.GetReaders();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
           string error = Business.DeleteReader(txtDNI.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvReaders.DataSource = Business.GetReaders();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string error = Business.UpdateReader(txtDNI.Text, txtName.Text, txtSurname.Text, txtContact.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvReaders.DataSource = Business.GetReaders();
        }
    }
}
