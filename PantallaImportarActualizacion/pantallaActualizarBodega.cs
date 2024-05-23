﻿using PantallaImportarActualizacion.Entidades;
using System;
using System.Collections.Generic;
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

        private void opcionImportarActualizacionVino_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
            cmbBodegas.DataSource = gestor.buscarBodegasConActualizacionesPendientes();

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
            dgBodega.DataSource = null;
            dgBodega.DataSource = vinos;
            lblNombreBodega.Enabled = true;
            lblNombreBodega.Text = nombreBodega;
        }
    }
}
