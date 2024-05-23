using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Entidades
{
    public class Siguiendo
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private Bodega bodega;
        private Enofilo amigo;

        public Siguiendo(DateTime fechaFinSiguiendo, DateTime fechaInicioSiguiendo, Bodega bodegaSiguiendo, Enofilo amigoEnofilo)
        {
            fechaFin = fechaFinSiguiendo;
            fechaInicio = fechaInicioSiguiendo;
            bodega = bodegaSiguiendo;
            amigo = amigoEnofilo;
        }

        public DateTime fechaFinSiguiendo
        {
            get => fechaFin;
            set => fechaFin = value;
        }

        public DateTime fechaInicioSiguiendo
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }

        public Bodega bodegaSiguiendo
        {
            get => bodega;
            set => bodega = value;
        }

        public Enofilo amigoEnofilo
        {
            get => amigo;
            set => amigo = value;
        }
    }
}
