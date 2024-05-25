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
        public Vino vino { get; set; }
        

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

        public List<Bodega> bodegas { get; set; }

        //Metodos

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

        public void actualizarDatosDeVino(Vino vinoAActualizar, List<Vino> allVinos, DateTime fechaActual, List<Vino> listaFinalAct, List<Vino> listaCreados)
        {
            for (int i = 0; i < allVinos.Count; i++)
            {
                bool vinoActual = allVinos[i].sosParaActualizar(allVinos[i].nombreVino, vinoAActualizar.nombreVino);
                if (allVinos[i].bodegaVino.nombre == vinoAActualizar.bodegaVino.nombre)
                {
                    if (vinoActual == true)
                    {
                        allVinos[i].setPrecio(vinoAActualizar.precioARSVino);
                        allVinos[i].setNotaCata(vinoAActualizar.notaDeCataBodegaVino);
                        allVinos[i].setImagenEtiqueta(vinoAActualizar.imagenEtiquetaVino);
                        allVinos[i].setFechaActualizacion(fechaActual);
                        listaFinalAct.Add(allVinos[i]);
                    }
                    else
                    {
                        listaCreados.Add(allVinos[i]);
                    }
                }
            }
        }
    }
}
