using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Entidades
{
    public class Varietal
    {
        private string descripcion;
        private string porcentajeTiposUva;
        private TipoUva tipoUva;

        public Varietal(string descripcionP, string porcentajeTiposUvaP, TipoUva tipoUvaP) 
        {
            descripcion = descripcionP;
            porcentajeTiposUva = porcentajeTiposUvaP;
            tipoUva = tipoUvaP;
        }

        public string descripcionVarietal
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string porcentajeTiposUvaVarietal
        {
            get => porcentajeTiposUva;
            set => porcentajeTiposUva = value;
        }

        public TipoUva tipoUvaVarietal
        {
            get => tipoUva;
            set => tipoUva = value;
        }

    }
}
