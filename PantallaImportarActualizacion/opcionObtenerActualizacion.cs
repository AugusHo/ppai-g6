using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaImportarActualizacion
{
    public partial class opcionObtenerActualizacion : Form
    {
        public opcionObtenerActualizacion()
        {
            InitializeComponent();
        }

        private void opcionImportarActualizacionVino_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario que deseas abrir
            ImportarActualizacionVino nuevaVentana = new ImportarActualizacionVino();

            // Mostrar la nueva ventana
            nuevaVentana.habilitarPantalla();

        }

        // Generar Informe
        private void opcionResumenBodega_Click(object sender, EventArgs e)
        {
            //llamar a la nueva pantalla con el resumen
            
        }
      
    }
}
