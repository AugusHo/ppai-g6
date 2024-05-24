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

            vinosConActualizacion.Add(new Entidades.Vino("2018", "imagen100.jpg", "Vino Tinto Reserva", 4, 1234.5f, bodegas[0], new List<Entidades.Maridaje> { maridajes[0], maridajes[1] }, "no se actualizo"));
            vinosConActualizacion.Add(new Entidades.Vino("2019", "imagen200.jpg", "Vino Blanco Chardonnay", 3, 5678.9f, bodegas[0], new List<Entidades.Maridaje> { maridajes[2], maridajes[3] }, "no se actualizo"));
            vinosConActualizacion.Add(new Entidades.Vino("2017", "imagen300.jpg", "Vino Rosado", 5, 9101.25f, bodegas[2], new List<Entidades.Maridaje> { maridajes[4], maridajes[5] }, "no se actualizo"));
            vinosConActualizacion.Add(new Entidades.Vino("2020", "imagen400.jpg", "Vino Blanco Sauvignon", 2, 3456.70f, bodegas[2], new List<Entidades.Maridaje> { maridajes[6], maridajes[7] },"no se actualizo"));

            return getActualizacion(vinosConActualizacion);
        }

        public static List<Entidades.Vino> getActualizacion(List<Entidades.Vino> vinos)
        {
            //List<Entidades.Vino> actualizaciones = ObtenerActualizaciones();
            return vinos;
        }

    }
}