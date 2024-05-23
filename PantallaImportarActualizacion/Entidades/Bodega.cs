using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Entidades
{
    public class Bodega
    {
        private string descripcion;
        private string historia;
        private string nombre;
        private bool periodoActualizacion;
        private int coordenadasUbicacion;
        public Vino Vino { get; set; }

        public Bodega(string descripcionBodega, string historiaBodega, string nombreBodega, bool periodoActualizacionBodega, int coordenadasUbicacionBodega)
        {
            descripcion = descripcionBodega;
            historia = historiaBodega;
            nombre = nombreBodega;
            periodoActualizacion = periodoActualizacionBodega;
            coordenadasUbicacion = coordenadasUbicacionBodega;

        }

        public string descripcionBodega
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string historiaBodega
        {
            get => historia;
            set => historia = value;
        }

        public string nombreBodega
        {
            get => nombre;
            set => nombre = value;
        }

        public bool periodoActualizacionBodega
        {
            get => periodoActualizacion;
            set => periodoActualizacion = value;
        }

        public int coordenadasUbicacionBodega
        {
            get => coordenadasUbicacion;
            set => coordenadasUbicacion = value;
        }

        public List<Bodega> bodegas { get; set; }

        //Metodos

        public bool estaParaActualizarNovedadesVino()
        {
            return periodoActualizacion;
        }

        public bool esTuVino(string nombreVino, string nombreBodega)
        {
            if (nombreVino == nombreBodega)
            {
                return true;
            };
            return false;
        }

        public void actualizarDatosDeVino(Vino listaVinosActualizadosBodega, Bodega bodegaSeleccionada, List<Vino> allVinos, DateTime fechaActual)
        {
            for (int i = 0; i < allVinos.Count; i++)
            {
                bool vinoActual = Vino.sosParaActualizar(allVinos[i].nombreVino, listaVinosActualizadosBodega.nombreVino);
                if (vinoActual == true)
                {
                    allVinos[i].setPrecio(listaVinosActualizadosBodega.precioARSVino);
                    //allVinos[i].setNotaCata(listaVinosActualizadosBodega.notaDeCataBodegaVino);
                    allVinos[i].setImagenEtiqueta(listaVinosActualizadosBodega.imagenEtiquetaVino);
                    allVinos[i].setFechaActualizacion(fechaActual);
                }
            }

        }
    }
}
