using PantallaImportarActualizacion.Datos;
using PantallaImportarActualizacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PantallaImportarActualizacion
{
    public partial class pantallaActualizarBodega : Form
    {
        private GestorImportadorBodega gestor; 

        public pantallaActualizarBodega()
        {
            InitializeComponent();
            clbBodegas.Enabled = false;
            btnSeleccionar.Enabled = false;
            dgBodega.Enabled = false;
            lblNombreBodega.Enabled = false;
            label1.Enabled = false;
            gestor = new GestorImportadorBodega(this);
        }

        //Inicio del CU
        private void opcionImportarActualizacionVino_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
            List<String> bodegasConActualizacion = gestor.opcionImportarActualizacionVinos();
            Console.WriteLine(bodegasConActualizacion);
            mostrarYSolicitarBodegasConActualizacion(bodegasConActualizacion);

            /*if (bodegasConActualizacion.Count == 0)
            {
                MessageBox.Show("No hay bodegas para actualizar","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //mostrarYSeleccionarBodegasConActualizacion()
                clbBodegas.DataSource = gestor.buscarBodegasConActualizacionesPendientes();

            }*/
        }

        private void mostrarYSolicitarBodegasConActualizacion(List<string> bodegasConActualizacion)
        {
            if (bodegasConActualizacion.Count == 0)
            {
                MessageBox.Show("No hay bodegas para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clbBodegas.DataSource = gestor.buscarBodegasConActualizacionesPendientes();
            }
        }

        public void habilitarPantalla()
        {
            clbBodegas.Enabled = true;
            btnSeleccionar.Enabled = true;
            dgBodega.Enabled = true;
            label1.Enabled = true;
        }

        private void tomarSeleccionBodega_Click(object sender, EventArgs e)
        {
            //gestor.tomarSeleccionBodega(clbBodegas.SelectedItem.ToString());
            if (dgBodega.Rows.Count > 0)
            {
                dgBodega.DataSource = null;  // Esto limpiará el DataGridView
            }


            List<string> bodegasSeleccionadas = clbBodegas.CheckedItems.Cast<string>().ToList();

            for (int i = 0; i < bodegasSeleccionadas.Count; i++)
            {
                gestor.tomarSeleccionBodega(bodegasSeleccionadas[i].ToString());
            }

        }

        public void mostarResumen(List<Vino> vinos, string nombreBodega)
        {
            List<VinoTabla> vinosTabla = this.Transformar(vinos);
            var existingData = dgBodega.DataSource as List<VinoTabla>;

            if (existingData != null)
            {
                vinosTabla.AddRange(existingData);
            }
            dgBodega.DataSource = null;
            dgBodega.DataSource = vinosTabla;
            lblNombreBodega.Enabled = true;
            lblNombreBodega.Text = ("Nombre de la bodega: " + nombreBodega);
        }

        public List<VinoTabla> Transformar(List<Vino> vinos)
        {
            return vinos.Select(v => new VinoTabla
            {
                Añada = v.añadaVino,
                ImagenEtiqueta = v.imagenEtiquetaVino,
                Nombre = v.nombreVino,
                NotaDeCataBodega = v.notaDeCataBodegaVino,
                PrecioARS = v.precioARSVino,
                NombreBodega = v.bodegaVino.nombreBodega,
                DatosMaridaje = string.Join(" // ", v.maridajeVino.Select(m => $"{m.nombreMaridaje}: {m.descripcionMaridaje}")),
                FechaActualizacion = v.fechaActualizacionV,
                DatosVarietal = string.Join(" // ", v.varietalVino.Select(varietal => $"{varietal.porcentajeTiposUvaVarietal}% de {varietal.tipoUvaVarietal.nombreUva}: {varietal.descripcionVarietal}"))
            }).ToList();
        }

    }
}
