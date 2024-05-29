using System;
using System.Collections.Generic;

namespace PantallaImportarActualizacion.Entidades
{
    public class Bodega
    {
        private string descripcion;
        private string historia;
        private string nombre;
        private bool periodoActualizacion;
        private int coordenadasUbicacion;
        private string fechaUltimaActualizacion;
     

        public Bodega(string descripcionBodega, string historiaBodega, string nombreBodega, bool periodoActualizacionBodega, int coordenadasUbicacionBodega, string fechaUltimaActualizacionBodega)
        {
            descripcion = descripcionBodega;
            historia = historiaBodega;
            nombre = nombreBodega;
            periodoActualizacion = periodoActualizacionBodega;
            coordenadasUbicacion = coordenadasUbicacionBodega;
            fechaUltimaActualizacion = fechaUltimaActualizacionBodega;
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

        public string fechaUltimaActualizacionBodega
        {
            get => fechaUltimaActualizacion;
            set => fechaUltimaActualizacion = value;
        }

        public List<Bodega> bodegas { get; set; }

        //Metodos

        public string getNombre()
        {
            return this.nombre;
        }

        public bool estaParaActualizarNovedadesVino()
        {
            return periodoActualizacion;
        }

        public bool esTuVino(string nombreBodegaVino, string nombreBodega)
        {
            if (nombreBodegaVino == nombreBodega)
            {
                return true;
            };
            return false;
        }

        public void actualizarDatosDeVino(Vino vinoAActualizar, List<Vino> vinos, string fechaActual, List<Vino> listaFinalAct, List<Vino> listaCreados)
        {
            bool vinoEncontrado = false;

            for (int i = 0; i < vinos.Count; i++)
            {
                // Verifica que el vino de la api exista ya en la base de datos
                bool vinoActual = vinos[i].sosParaActualizar(vinos[i].nombreVino, vinoAActualizar.nombreVino);

                if (vinoActual && vinos[i].bodegaVino.nombre == vinoAActualizar.bodegaVino.nombre && vinos[i].añadaVino == vinoAActualizar.añadaVino)
                {
                    vinos[i].setPrecio(vinoAActualizar.precioARSVino);
                    vinos[i].setNotaCata(vinoAActualizar.notaDeCataBodegaVino);
                    vinos[i].setImagenEtiqueta(vinoAActualizar.imagenEtiquetaVino);
                    vinos[i].setFechaActualizacion(fechaActual);
                    listaFinalAct.Add(vinos[i]);
                    Console.WriteLine(listaFinalAct);
                    vinoEncontrado = true;
                    break;
                }
            }

            if (!vinoEncontrado)
            {
                listaCreados.Add(vinoAActualizar);
                Console.WriteLine(listaCreados);
            }
        }

        public void setFechaUltimaActualizacion(string fechaActual)
        {
            this.fechaUltimaActualizacion = fechaActual;
            Console.WriteLine(this.fechaUltimaActualizacion);
        }
    }
}
