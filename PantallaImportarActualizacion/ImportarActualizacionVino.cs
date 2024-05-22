using PantallaImportarActualizacion.Entidades;
using System.Windows.Forms;

namespace PantallaImportarActualizacion
{
    public partial class ImportarActualizacionVino : Form
    {
        private GestorImportadorBodega gestor = new GestorImportadorBodega();

        public ImportarActualizacionVino()
        {
            InitializeComponent();
            
        }

        public void habilitarPantalla()
        {
            this.Show();
            cmbBodegas.DataSource = gestor.buscarBodegasConActualizacionesPendientes();
        }

        private void cmbBodegas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            gestor.tomarSeleccionBodega(cmbBodegas.SelectedItem.ToString());
        }
    }
}
