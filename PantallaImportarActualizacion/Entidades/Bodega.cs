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
    }
}
