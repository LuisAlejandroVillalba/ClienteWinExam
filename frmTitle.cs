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
    public partial class frmTitle : Form
    {
        ServiceReference2.WebService1SoapClient servicio = new ServiceReference2.WebService1SoapClient();
        public frmTitle()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Au_id =txtAu_id.Text.Trim();
            string Title_id=txtTitle_id.Text.Trim();
            int Au_ord = int.Parse(txtAu_ord.Text);
            int RoyalTyper = int.Parse(txtRoyaltiper.Text);
            servicio.AgregarTitleauthor(Au_id, Title_id,Au_ord ,RoyalTyper);
        }
        
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = servicio.ListarTitleauthor().Tables[0];
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texo = txtTextoTI.Text.Trim();
            string criterio = cmbCriterio.SelectedItem.ToString();
            dgvDatos.DataSource = servicio.BuscarTitleauthor(texo, criterio).Tables[0];

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Au_id = txtAu_id.Text.Trim();
            string Title_id = txtTitle_id.Text.Trim();
            int Au_ord = int.Parse(txtAu_ord.Text);
            int RoyalTyper = int.Parse(txtRoyaltiper.Text);
            servicio.ActualizarTitleauthor(Au_id, Title_id, Au_ord, RoyalTyper);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Au_id = txtAu_id.Text.Trim();
            servicio.EliminarTitleauthor(Au_id);
        }

        private void btnSalirA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegresarA_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
        }
    }
}
