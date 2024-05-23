using PantallaImportarActualizacion.Entidades;
using System;
using System.Windows.Forms;

namespace PantallaImportarActualizacion
{
    public partial class opcionObtenerActualizacion : Form
    {
        GestorImportadorBodega gestor = new GestorImportadorBodega();
        public opcionObtenerActualizacion()
        {
            InitializeComponent();
            cmbBodegas.Enabled = false;
            btnSeleccionar.Enabled = false;
        }

        private void opcionImportarActualizacionVino_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
            cmbBodegas.DataSource = gestor.buscarBodegasConActualizacionesPendientes();

        }

        public void habilitarPantalla()
        {
            cmbBodegas.Enabled = true;
            btnSeleccionar.Enabled = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            gestor.tomarSeleccionBodega(cmbBodegas.SelectedItem.ToString());
        }
    }
}
