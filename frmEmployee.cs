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
    public partial class frmEmployee : Form
    {
        ServiceReference2.WebService1SoapClient servicio = new ServiceReference2.WebService1SoapClient();

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Emp_id=txtEmp_id.Text;
            string Fname=txtFname.Text;
            string Minit=txtMinit.Text;
            string Iname=txtIname.Text;
            int Job_id= int.Parse(txtJob_id.Text);
            int Job_lvl= int.Parse(txtJob_lvl.Text);
            string Pub_id = txtPub_id.Text;
            DateTime Hire_Date = DateTime.Parse(txtHireDate.Text);
            servicio.AgregarEmployee(Emp_id,Fname,Minit,Iname,Job_id,Job_lvl,Pub_id,Hire_Date);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Emp_id = txtEmp_id.Text;
            string Fname = txtFname.Text;
            string Minit = txtMinit.Text;
            string Iname = txtIname.Text;
            int Job_id = int.Parse(txtJob_id.Text);
            int Job_lvl = int.Parse(txtJob_lvl.Text);
            string Pub_id = txtPub_id.Text;
            DateTime Hire_Date = DateTime.Parse(txtHireDate.Text);
            servicio.ActualizarEmployee(Emp_id, Fname, Minit, Iname, Job_id, Job_lvl, Pub_id, Hire_Date);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Emp_id = txtEmp_id.Text;
            servicio.EliminarEmployee(Emp_id);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEmploye.DataSource = servicio.ListarEmployee().Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtTextoEm.Text.Trim();
            string criterio = cbCriterioEm.SelectedItem.ToString();
            dgvEmploye.DataSource = servicio.BuscarEmployee(texto,criterio).Tables[0];

        }

        private void btnSalirE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegresarE_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
        }
    }
}
