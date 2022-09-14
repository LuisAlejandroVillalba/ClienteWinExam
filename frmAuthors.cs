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
    public partial class frmAuthors : Form
    {
        ServiceReference2.WebService1SoapClient servicio = new ServiceReference2.WebService1SoapClient();

        public frmAuthors()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Au_id = txtAu_id.Text.Trim();
            string Au_Iname=txtAu_Iname.Text.Trim();
            string Au_fname = txtAu_fname.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Address=txtAddress.Text.Trim();
            string City=txtCity.Text.Trim();    
            string State=txtState.Text.Trim();
            int Zip = int.Parse(txtZip.Text);
            string Contract=txtContact.Text.Trim();
            servicio.AgregarAuthors(Au_id, Au_Iname, Au_fname, Phone, Address, City, State, Zip, Contract);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Au_id = txtAu_id.Text.Trim();
            string Au_Iname = txtAu_Iname.Text.Trim();
            string Au_fname = txtAu_fname.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string City = txtCity.Text.Trim();
            string State = txtState.Text.Trim();
            int Zip = int.Parse(txtZip.Text);
            string Contract = txtContact.Text.Trim();
            servicio.ActualizarAuthors(Au_id, Au_Iname, Au_fname, Phone, Address, City, State, Zip, Contract);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Au_id = txtAu_id.Text.Trim();
            servicio.EliminarAuthors(Au_id);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvAuthors.DataSource = servicio.ListarAuthors().Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Texto = txtTexto.Text.Trim();
            string Crtierio=cmbCriterioAu.SelectedItem.ToString();
            dgvAuthors.DataSource = servicio.BuscarAuthors(Texto,Crtierio).Tables[0];

        }

        private void btnSalirAu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegresarAut_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
        }
    }
}
