using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            frmAuthors auth=new frmAuthors();
            auth.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee empl = new frmEmployee();
            empl.Show();
            this.Hide();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            frmTitle tite = new frmTitle();
            tite.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
