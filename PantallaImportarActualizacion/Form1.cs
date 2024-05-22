using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaImportarActualizacion
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
