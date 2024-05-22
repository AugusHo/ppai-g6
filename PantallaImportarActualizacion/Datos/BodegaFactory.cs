using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Datos
{
    public static class BodegaFactory
    {
        public static List<Entidades.Bodega> DatosBodegas()
        {
            List<Entidades.Bodega> bodegas = new List<Entidades.Bodega>();

            // Hardcodea las instancias de Bodega aquí
            bodegas.Add(new Entidades.Bodega("Esta es una bodega", "Bodega 1","Bodega",true,151515));
            bodegas.Add(new Entidades.Bodega("Esta es otra bodega", "Bodega 2","Bodeguita",false,151115));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegon","Bodega 3","Bodegon",false,151565));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegonazo", "Bodega 4", "Bodegonazo", true, 2151565));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegonazo", "Bodega 4", "NombreGenerico 1", true, 2151565));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegonazo", "Bodega 4", "NombreGenerico 12", true, 2151565));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegonazo", "Bodega 4", "NombreGenerico 13", true, 2151565));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegonazo", "Bodega 4", "NombreGenerico 14", true, 2151565));
            return bodegas;
        }
    }
}
