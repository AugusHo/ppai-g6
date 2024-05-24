using System;
using System.Collections.Generic;

namespace PantallaImportarActualizacion.Entidades
{
    public class Vino
    {
        private string añada;
        private string imagenEtiqueta;
        private string nombre;
        private int notaDeCataBodega;
        private float precioARS;
        private Bodega bodega;
        private List<Maridaje> maridaje;
        private string fechaActualizacion;

        public Vino (string añadaVino, string imagenEtiquetaVino, string nombreVino, int notaDeCataBodegaVino, float precioARSVino, Bodega bodegaVino, List<Maridaje>  maridajeVino, string fechaActualizacionVino)
        {
            añada = añadaVino;
            imagenEtiqueta = imagenEtiquetaVino;
            nombre = nombreVino;
            notaDeCataBodega = notaDeCataBodegaVino;
            precioARS = precioARSVino;
            bodega = bodegaVino;
            maridaje = maridajeVino;
            fechaActualizacion = fechaActualizacionVino;
        }

        public string añadaVino
        {
            get => añada;
            set => añada = value;
        }

        public string imagenEtiquetaVino
        {
            get => imagenEtiqueta;
            set => imagenEtiqueta = value;
        }

        public string nombreVino
        {
            get => nombre;
            set => nombre = value;
        }

        public int notaDeCataBodegaVino
        {
            get => notaDeCataBodega;
            set => notaDeCataBodega = value;
        }

        public float precioARSVino
        {
            get => precioARS;
            set => precioARS = value;
        }

        public Bodega bodegaVino
        {
            get => bodega;
            set => bodega = value;
        }

        public List<Maridaje> maridajeVino
        {
            get => maridaje;
            set => maridaje = value;
        }

        public string fechaActualizacionV {
            get => fechaActualizacion;
            set => fechaActualizacion = value;
        }

        public bool sosParaActualizar( string nombreAllVino, string nombreVinoAct)
        {
            if (nombreAllVino == nombreVinoAct)
            {
                return true;
            }
            return false;
        }

        public void setPrecio(float precio)
        {
            this.precioARS = precio;
        }

        public void setNotaCata(int notaDeCataBodega)
        {
            this.notaDeCataBodegaVino = notaDeCataBodega;
        }

        public void setImagenEtiqueta(string imagenEtiqueta)
        {
            this.imagenEtiquetaVino = imagenEtiqueta;
        }

        public void setFechaActualizacion( DateTime fechaActual)
        {
            string fechaActualString = fechaActual.ToString("dd-MM-yyyy");
            this.fechaActualizacion = fechaActualString;
        }
    }
}
