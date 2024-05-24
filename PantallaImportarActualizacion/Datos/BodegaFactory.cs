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
            bodegas.Add(new Entidades.Bodega("Esta es una bodega", "Bodega 0","Los Santos",true,151515,"2023,5,23"));
            bodegas.Add(new Entidades.Bodega("Esta es otra bodega", "Bodega 1", "Aimar Vinos", true,151115, "2022, 5, 23"));
            bodegas.Add(new Entidades.Bodega("Y este es un Bodegon","Bodega 2", "Norton", true,151565, "2021, 5, 23"));
            bodegas.Add(new Entidades.Bodega("VLLC", "Bodega 3", "Zuccardi", false, 2151565, "2013, 5, 23"));
            bodegas.Add(new Entidades.Bodega("PPQGS", "Bodega 4", "Andeluna", false, 2151565, "2007, 5, 23"));
            bodegas.Add(new Entidades.Bodega("OA", "Bodega 5", "Rutini", false, 2151565, "2023, 5, 23"));
            bodegas.Add(new Entidades.Bodega("AJKDJAS", "Bodega 6", "Colomé", true, 2151565, "2003, 5, 23"));
            bodegas.Add(new Entidades.Bodega("EA", "Bodega 7", "Luigi Bosca", true, 2151565, "2015, 5, 23"));
            return bodegas;
        }
    }
}
