using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Entidades
{
    public class Enofilo
    {
        private string apellido;
        private string nombre;
        private string imagenPerfil;
        private List<Siguiendo> seguido;

        public Enofilo(string apellidoEnofilo, string nombreEnofilo, string imagenPerfilEnofilo, List<Siguiendo> seguidoEnofilo)
        {
            apellido = apellidoEnofilo;
            nombre = nombreEnofilo;
            imagenPerfil = imagenPerfilEnofilo;
            seguido = seguidoEnofilo;
        }

        public string apellidoEnofilo
        {
            get => apellido;
            set => apellido = value;
        }

        public string nombreEnofilo
        {
            get => nombre;
            set => nombre = value;
        }

        public string imagenPerfilEnofilo
        {
            get => imagenPerfil;
            set => imagenPerfil = value;
        }

        public List<Siguiendo> seguidoEnofilo
        {
            get => seguido;
            set => seguido = value;
        }
    }
}
