using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Datos
{
    public static class VinoFactoy
    {
        public static List<Entidades.Vino> DatosVinos()
        {
            List<Entidades.Bodega> bodegas = BodegaFactory.DatosBodegas();
            List<Entidades.Maridaje> maridajes = MaridajeFactory.DatosMaridajes();
            List<Entidades.Vino> vinos = new List<Entidades.Vino>(); // Faltaba el punto y coma al final

            vinos.Add(new Entidades.Vino("2018", "imagen1.jpg", "Vino Tinto Reserva", 90, 1500.5f, bodegas[0], new List<Entidades.Maridaje> { maridajes[0], maridajes[1] }));
            vinos.Add(new Entidades.Vino("2019", "imagen2.jpg", "Vino Blanco Chardonnay", 85, 1200.0f, bodegas[1], new List<Entidades.Maridaje> { maridajes[2], maridajes[3] }));
            vinos.Add(new Entidades.Vino("2017", "imagen3.jpg", "Vino Rosado", 88, 1350.75f, bodegas[2], new List<Entidades.Maridaje> { maridajes[4], maridajes[5] }));
            vinos.Add(new Entidades.Vino("2020", "imagen4.jpg", "Vino Espumante", 92, 1600.0f, bodegas[3], new List<Entidades.Maridaje> { maridajes[6], maridajes[7] }));
            vinos.Add(new Entidades.Vino("2016", "imagen5.jpg", "Vino Tinto Malbec", 87, 1400.25f, bodegas[4], new List<Entidades.Maridaje> { maridajes[8], maridajes[9] }));
            vinos.Add(new Entidades.Vino("2021", "imagen6.jpg", "Vino Blanco Sauvignon", 89, 1300.0f, bodegas[2], new List<Entidades.Maridaje> { maridajes[0], maridajes[1] }));
            vinos.Add(new Entidades.Vino("2015", "imagen7.jpg", "Vino Tinto Cabernet", 91, 1550.5f, bodegas[5], new List<Entidades.Maridaje> { maridajes[2], maridajes[3] }));
            vinos.Add(new Entidades.Vino("2018", "imagen8.jpg", "Vino Blanco Riesling", 84, 1250.0f, bodegas[6], new List<Entidades.Maridaje> { maridajes[4], maridajes[5] }));
            vinos.Add(new Entidades.Vino("2019", "imagen9.jpg", "Vino Tinto Merlot", 86, 1450.75f, bodegas[4], new List<Entidades.Maridaje> { maridajes[6], maridajes[7] }));
            vinos.Add(new Entidades.Vino("2017", "imagen10.jpg", "Vino Rosado Zinfandel", 83, 1100.0f, bodegas[2], new List<Entidades.Maridaje> { maridajes[6], maridajes[1] }));

            return vinos;
        }
    }
}