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
        private string imagenPerfil;
        private string nombre;
        private Usuario usuario;
        private List<Siguiendo> siguiendo;

        public Enofilo(string apellidoE, string imagenPerfilE, string nombreE, Usuario usuarioE, List<Siguiendo> siguiendoE)
        {
            apellido = apellidoE;
            imagenPerfil = imagenPerfilE;
            nombre = nombreE;
            usuario = usuarioE;
            siguiendo = siguiendoE;
        }

        public string apellidoE
        {
            get => apellido;
            set => apellido = value;
        }

        public string imagenPerfilE
        {
            get => imagenPerfil;
            set => imagenPerfil = value;
        }

        public string nombreE
        {
            get => nombre;
            set => nombre = value;
        }

        public Usuario usuarioE
        {
            get => usuario;
            set => usuario = value;
        }

        public List<Siguiendo> siguiendoE
        {
            get => siguiendo;
            set => siguiendo = value;
        }

        //Metodos
        public bool esSeguidor(string bodegaSeleccioda)
        {
            for (int i = 0; i < siguiendo.Count; i++)
            {
                if (siguiendo[i].sosDeBodega(bodegaSeleccioda))
                {
                    return true;
                }
            }
            return false;
        }

        public string getNombreUsuario()
        {
            return this.usuario.getNombre();
        }
    }

}
