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
            cmbBodegas.Enabled = false;
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
            cmbBodegas.DataSource =  gestor.OpcionImportarActualizacionVinos();
            Console.WriteLine(cmbBodegas.DataSource);



        }

        public void habilitarPantalla()
        {
            cmbBodegas.Enabled = true;
            btnSeleccionar.Enabled = true;
            dgBodega.Enabled = true;
            label1.Enabled = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            gestor.tomarSeleccionBodega(cmbBodegas.SelectedItem.ToString());
        }

        public void mostarResumen(List<Vino> vinos, string nombreBodega)
        {
            List<VinoTabla> vinosTabla = this.Transformar(vinos);
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
