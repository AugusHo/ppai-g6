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
            bodegas.Add(new Entidades.Bodega("Esta es una bodega", "Bodega 1","Los Santos",true,151515,"2023,5,23"));
            bodegas.Add(new Entidades.Bodega("Esta es otra bodega", "Bodega 2", "Aimar Vinos", false,151115, "2022, 5, 23"));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegon","Bodega 3", "Norton", false,151565, "2021, 5, 23"));
            bodegas.Add(new Entidades.Bodega("VLLC", "Bodega 4", "Zuccardi", true, 2151565, "2013, 5, 23"));
            bodegas.Add(new Entidades.Bodega("PPQGS", "Bodega 5", "Andeluna", true, 2151565, "2007, 5, 23"));
            bodegas.Add(new Entidades.Bodega("OA", "Bodega 6", "Rutini", true, 2151565, "2023, 5, 23"));
            bodegas.Add(new Entidades.Bodega("AJKDJAS", "Bodega 7", "Colomé", true, 2151565, "2003, 5, 23"));
            bodegas.Add(new Entidades.Bodega("EA", "Bodega 8", "Luigi Bosca", true, 2151565, "2015, 5, 23"));
            return bodegas;
        }
    }
}
