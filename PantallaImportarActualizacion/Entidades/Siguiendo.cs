using System;

namespace PantallaImportarActualizacion.Entidades
{
    public class Siguiendo
    {
        private string fechaFin;
        private string fechaInicio;
        private Bodega bodega;
        private Enofilo amigo;

        public Siguiendo(string fechaFinSiguiendo, string fechaInicioSiguiendo, Bodega bodegaSiguiendo, Enofilo amigoE)
        {
            fechaFin = fechaFinSiguiendo;
            fechaInicio = fechaInicioSiguiendo;
            bodega = bodegaSiguiendo;
            amigo = amigoE;
        }

        public string fechaFinSiguiendo
        {
            get => fechaFin;
            set => fechaFin = value;
        }

        public string fechaInicioSiguiendo
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }

        public Bodega bodegaSiguiendo
        {
            get => bodega;
            set => bodega = value;
        }

        public Enofilo amigoE
        {
            get => amigo;
            set => amigo = value;
        }

        public bool sosDeBodega(string nombreBodega)
        {
            if (bodega.nombreBodega == nombreBodega) { return true; }
            return false;
        }
    }
}
