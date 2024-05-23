using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Datos
{
    public static class InterfazAPIBodega
    {
        public static List<Entidades.Vino> ObtenerActualizaciones()
        {
            List<Entidades.Bodega> bodegas = BodegaFactory.DatosBodegas();
            List<Entidades.Maridaje> maridajes = MaridajeFactory.DatosMaridajes();
            List<Entidades.Vino> vinosConActualizacion = new List<Entidades.Vino>();

            vinosConActualizacion.Add(new Entidades.Vino("2018", "imagen1.jpg", "Vino Tinto Reserva", 1, 1500.5f, bodegas[0], new List<Entidades.Maridaje> { maridajes[0], maridajes[1] }));
            vinosConActualizacion.Add(new Entidades.Vino("2019", "imagen2.jpg", "Vino Blanco Chardonnay", 5, 1200.0f, bodegas[0], new List<Entidades.Maridaje> { maridajes[2], maridajes[3] }));
            vinosConActualizacion.Add(new Entidades.Vino("2017", "imagen3.jpg", "Vino Rosado", 3, 1350.75f, bodegas[5], new List<Entidades.Maridaje> { maridajes[4], maridajes[5] }));
            vinosConActualizacion.Add(new Entidades.Vino("2020", "imagen4.jpg", "Vino Espumante", 4, 1600.0f, bodegas[4], new List<Entidades.Maridaje> { maridajes[6], maridajes[7] }));

            return getActualizacion(vinosConActualizacion);
        }

        public static List<Entidades.Vino> getActualizacion(List<Entidades.Vino> vinos)
        {
            //List<Entidades.Vino> actualizaciones = ObtenerActualizaciones();
            return vinos;
        }
    }
}