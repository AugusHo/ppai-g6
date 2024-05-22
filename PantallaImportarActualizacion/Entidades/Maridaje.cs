using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizarVinos.Entidades
{
    public class Maridaje
    {
        private string descripcion;
        private string nombre;

        public Maridaje(string descripcionMaridaje, string nombreMaridaje)
        {
            descripcion = descripcionMaridaje;
            nombre = nombreMaridaje;
        }

        public string descripcionMaridaje
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string nombreMaridaje
        {
            get => nombre;
            set => nombre = value;
        }
    }
}
