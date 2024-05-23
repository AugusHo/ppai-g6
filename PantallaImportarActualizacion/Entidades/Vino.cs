using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Entidades
{
    public class Vino
    {
        private string añada;
        private string fechaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private int notaDeCataBodega;
        private float precioARS;
        private Bodega bodega;
        private List<Maridaje> maridaje;

        public Vino (string añadaVino, string imagenEtiquetaVino, string nombreVino, int notaDeCataBodegaVino, float precioARSVino, Bodega bodegaVino, List<Maridaje>  maridajeVino)
        {
            añada = añadaVino;
            imagenEtiqueta = imagenEtiquetaVino;
            nombre = nombreVino;
            notaDeCataBodega = notaDeCataBodegaVino;
            precioARS = precioARSVino;
            bodega = bodegaVino;
            maridaje = maridajeVino;
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

        public bool sosParaActualizar( string nombreAllVino, string nombreVinoAct )
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

        /*public void setNotaCata(int notaDeCataBodega)
        {
            for (int i = 0; i < .nota;
            this.setNotaCata = notaDeCataBodega;
        }*/

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
