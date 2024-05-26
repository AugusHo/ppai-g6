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
            List<Entidades.Varietal> varietales = VarietalFactory.DatosVarietal();
            List<Entidades.Varietal> varietalesNuevos = VarietalFactory.DatosVarietal();
            List<Entidades.TipoUva> tiposUvaNuevos = TipoUvaFactory.DatosTipoUva();

            //Vinos para Actualizar
            vinosConActualizacion.Add(new Entidades.Vino("2018", "imagen100.jpg", "Vino Tinto Reserva", 4, 1234.5f, bodegas[0], new List<Entidades.Maridaje> { maridajes[0], maridajes[1] }, "no se actualizo", new List<Entidades.Varietal> { varietales[0], varietales[1] }));
            vinosConActualizacion.Add(new Entidades.Vino("2021", "imagen400.jpg", "Vino Blanco Sauvignon", 2, 3456.70f, bodegas[2], new List<Entidades.Maridaje> { maridajes[0], maridajes[1] },"no se actualizo", new List<Entidades.Varietal> { varietales[4], varietales[5] }));
            vinosConActualizacion.Add(new Entidades.Vino("2017", "imagen300.jpg", "Vino Rosado", 5, 9101.25f, bodegas[2], new List<Entidades.Maridaje> { maridajes[4], maridajes[5] }, "no se actualizo", new List<Entidades.Varietal> { varietales[4], varietales[5] }));
            //Vinos para crear
            vinosConActualizacion.Add(new Entidades.Vino("2019", "imagen200.jpg", "Vino Blanco Chardonnay", 3, 5678.9f, bodegas[0], new List<Entidades.Maridaje> { maridajes[2], maridajes[3] }, "no se actualizo", new List<Entidades.Varietal> { varietalesNuevos[0], varietalesNuevos[1] }));
            
            //Nuevos varietales:
            //Primer Vino
            varietalesNuevos.Add( new Entidades.Varietal("Un vino tinto robusto y complejo.", "91%", tiposUvaNuevos[0]));
            varietalesNuevos.Add(new Entidades.Varietal("Un vino blanco fresco y afrutado.", "9", tiposUvaNuevos[1]));
            //Segundo Vino
            varietalesNuevos.Add(new Entidades.Varietal("Un vino tinto suave y aterciopelado.", "90%", tiposUvaNuevos[2]));
            varietalesNuevos.Add(new Entidades.Varietal("Un vino espumoso elegante y seco.", "10%", tiposUvaNuevos[0]));
            //Tercer Vino
            varietalesNuevos.Add(new Entidades.Varietal("Un vino tinto suave y aterciopelado.", "100%", tiposUvaNuevos[1]));
            //Cuarto Vino
            varietalesNuevos.Add(new Entidades.Varietal("Un vino espumoso elegante y seco.", "100%", tiposUvaNuevos[2]));




            return getActualizacion(vinosConActualizacion);
        }

        public static List<Entidades.Vino> getActualizacion(List<Entidades.Vino> vinos)
        {
            //List<Entidades.Vino> actualizaciones = ObtenerActualizaciones();
            return vinos;
        }

    }
}