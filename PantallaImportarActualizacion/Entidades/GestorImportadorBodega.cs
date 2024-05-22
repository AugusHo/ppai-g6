using System.Collections.Generic;
using System.Linq;

namespace PantallaImportarActualizacion.Entidades
{
    class GestorImportadorBodega
    {
        private List<Bodega> bodegas;
        private List<Bodega> bodegasConActualizacion;
        private Bodega bodegaSeleccionada;
        private List<Vino> vinos;
        private List<TipoUva> tiposUva;

        public GestorImportadorBodega()
        {
            bodegas = Datos.BodegaFactory.DatosBodegas();
            bodegasConActualizacion = new List<Bodega>();
        }

        public List<string> buscarBodegasConActualizacionesPendientes()
        {
            bodegasConActualizacion = bodegas.Where(x => x.estaParaActualizarNovedadesVino()).ToList();
            return bodegasConActualizacion.Select(x => x.nombreBodega).ToList();
        }

        public void tomarSeleccionBodega(string seleccionBodega)
        {
            bodegaSeleccionada = bodegasConActualizacion.FirstOrDefault(x=> x.nombreBodega == seleccionBodega);
        }
    }
}
