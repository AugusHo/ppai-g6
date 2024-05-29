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
            bodegas.Add(new Entidades.Bodega("Conocida por sus vinos tintos robustos y su pintoresco estanque, ofrece visitas guiadas y catas exclusivas.", "Fundada en 1982, Bodega El Estanque ha desarrollado una reputación por sus excepcionales vinos tintos y su atractivo entorno junto a un estanque.", "Los Santos", true, 151515, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Produce vinos blancos y rosados de alta calidad en un entorno montañoso con un enfoque en la sostenibilidad.", "Ubicada en una región montañosa, esta bodega ha sido pionera en la producción sostenible de vinos blancos y rosados desde su creación.", "Aimar Vinos", true, 151115, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Fundada hace más de 100 años, se especializa en vinos añejos elaborados con técnicas tradicionales.", "Con más de un siglo de historia, Bodega Santa Isabel es una institución en la viticultura clásica, produciendo vinos añejos con técnicas tradicionales desde 1900.", "Norton", true, 151565, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Combina tecnología avanzada y prácticas ecológicas para crear vinos innovadores como Sauvignon Blanc y Merlot.", "Desde su establecimiento en 2005, Bodega Monte Verde ha innovado en la creación de vinos frescos y ecológicos mediante la fusión de tecnología y prácticas sostenibles.", "Zuccardi", false, 2151565, "18-06-2024"));
            bodegas.Add(new Entidades.Bodega("Reconocida por sus tintos especiados, produce vinos con un carácter distintivo de suelos volcánicos.", "Desde sus inicios en terrenos volcánicos, Bodega Tierra Roja ha producido vinos tintos especiados que reflejan el carácter único de su territorio.", "Andeluna", false, 2151565, "22-07-2024"));
            bodegas.Add(new Entidades.Bodega("Cerca de una majestuosa cascada, ofrece vinos finos de Pinot Noir y Chardonnay.", "Fundada en 1998 cerca de una impresionante cascada, esta bodega se ha especializado en la producción de vinos elegantes de Pinot Noir y Chardonnay.", "Rutini", false, 2151565, "14-08-2024"));
            bodegas.Add(new Entidades.Bodega("Con vistas panorámicas a extensos viñedos, es famosa por sus premiados Malbec y Cabernet Sauvignon.", "Establecida en 1975, Bodega El Mirador ha ganado reconocimiento por sus intensos Malbec y Cabernet Sauvignon, ofreciendo vistas panorámicas de sus viñedos.", "Colomé", true, 2151565, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Una bodega familiar que produce vinos artesanales auténticos y bien equilibrados con gran dedicación.", "Desde su creación como una bodega familiar, Los Pinos ha dedicado su esfuerzo a la producción de vinos artesanales auténticos y bien equilibrados.", "Luigi Bosca", true, 2151565, "24-04-2024"));

            return bodegas;
        }
        public static List<Entidades.Bodega> DatosBodegasFalsa()
        {
            List<Entidades.Bodega> bodegas = new List<Entidades.Bodega>();

            // Hardcodea las instancias de Bodega aquí
            bodegas.Add(new Entidades.Bodega("Conocida por sus vinos tintos robustos y su pintoresco estanque, ofrece visitas guiadas y catas exclusivas.", "Fundada en 1982, Bodega El Estanque ha desarrollado una reputación por sus excepcionales vinos tintos y su atractivo entorno junto a un estanque.", "Los Santos", false, 151515, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Produce vinos blancos y rosados de alta calidad en un entorno montañoso con un enfoque en la sostenibilidad.", "Ubicada en una región montañosa, esta bodega ha sido pionera en la producción sostenible de vinos blancos y rosados desde su creación.", "Aimar Vinos", false, 151115, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Fundada hace más de 100 años, se especializa en vinos añejos elaborados con técnicas tradicionales.", "Con más de un siglo de historia, Bodega Santa Isabel es una institución en la viticultura clásica, produciendo vinos añejos con técnicas tradicionales desde 1900.", "Norton", false, 151565, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Combina tecnología avanzada y prácticas ecológicas para crear vinos innovadores como Sauvignon Blanc y Merlot.", "Desde su establecimiento en 2005, Bodega Monte Verde ha innovado en la creación de vinos frescos y ecológicos mediante la fusión de tecnología y prácticas sostenibles.", "Zuccardi", false, 2151565, "18-06-2024"));
            bodegas.Add(new Entidades.Bodega("Reconocida por sus tintos especiados, produce vinos con un carácter distintivo de suelos volcánicos.", "Desde sus inicios en terrenos volcánicos, Bodega Tierra Roja ha producido vinos tintos especiados que reflejan el carácter único de su territorio.", "Andeluna", false, 2151565, "22-07-2024"));
            bodegas.Add(new Entidades.Bodega("Cerca de una majestuosa cascada, ofrece vinos finos de Pinot Noir y Chardonnay.", "Fundada en 1998 cerca de una impresionante cascada, esta bodega se ha especializado en la producción de vinos elegantes de Pinot Noir y Chardonnay.", "Rutini", false, 2151565, "14-08-2024"));
            bodegas.Add(new Entidades.Bodega("Con vistas panorámicas a extensos viñedos, es famosa por sus premiados Malbec y Cabernet Sauvignon.", "Establecida en 1975, Bodega El Mirador ha ganado reconocimiento por sus intensos Malbec y Cabernet Sauvignon, ofreciendo vistas panorámicas de sus viñedos.", "Colomé", false, 2151565, "24-04-2024"));
            bodegas.Add(new Entidades.Bodega("Una bodega familiar que produce vinos artesanales auténticos y bien equilibrados con gran dedicación.", "Desde su creación como una bodega familiar, Los Pinos ha dedicado su esfuerzo a la producción de vinos artesanales auténticos y bien equilibrados.", "Luigi Bosca", false, 2151565, "24-04-2024"));

            return bodegas;
        }
    }
}
