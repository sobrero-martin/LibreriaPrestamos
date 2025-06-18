using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaPrestamos.FE
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btReaders_Click(object sender, EventArgs e)
        {
            EditReaders editReaders = new EditReaders();
            editReaders.MdiParent = this.MdiParent;
            editReaders.Dock = DockStyle.Fill;
            editReaders.Show();
        }

        private void btBooks_Click(object sender, EventArgs e)
        {
            EditBooks editBooks = new EditBooks();
            editBooks.MdiParent = this.MdiParent;
            editBooks.Dock = DockStyle.Fill;
            editBooks.Show();
        }

        private void btLoans_Click(object sender, EventArgs e)
        {
            EditLoans editLoans = new EditLoans();
            editLoans.MdiParent = this.MdiParent;
            editLoans.Dock = DockStyle.Fill;
            editLoans.Show();
        }
    }
}
