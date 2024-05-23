using System;
using System.Collections.Generic;
using System.Linq;

namespace PantallaImportarActualizacion.Entidades
{
    class GestorImportadorBodega
    {
        private pantallaActualizarBodega pantalla;
        private List<Bodega> bodegas;
        private List<Bodega> bodegasConActualizacion;
        private Bodega bodegaSeleccionada;
        private List<Vino> vinos;
        private List<TipoUva> tiposUva;
        private List<Vino> vinosConActualizacion;
        private List<Vino> listaVinosActualizadosBodega;
        private bool validar;

        public GestorImportadorBodega(pantallaActualizarBodega pantalla)
        {
            bodegas = Datos.BodegaFactory.DatosBodegas();
            bodegasConActualizacion = new List<Bodega>();
            vinosConActualizacion = new List<Vino>();
            listaVinosActualizadosBodega = new List<Vino>();
            this.pantalla = pantalla;
        }

        //tomar Hora Actual
        

        public List<string> buscarBodegasConActualizacionesPendientes()
        {
            bodegasConActualizacion = bodegas.Where(x => x.estaParaActualizarNovedadesVino()).ToList();
            return bodegasConActualizacion.Select(x => x.nombreBodega).ToList();
        }

        public void tomarSeleccionBodega(string seleccionBodega)
        {
            bodegaSeleccionada = bodegasConActualizacion.FirstOrDefault(x=> x.nombreBodega == seleccionBodega);

            obtenerActualizaciones();
            buscarVinosAActualizar();
            pantalla.mostarResumen(listaVinosActualizadosBodega, bodegaSeleccionada.nombreBodega);
        }

        //poner debajo de tomarSeleccionBodega()
        public void obtenerActualizaciones()
        {
            vinosConActualizacion = Datos.InterfazAPIBodega.ObtenerActualizaciones();
        }

        public void buscarVinosAActualizar()
        {
            listaVinosActualizadosBodega.Clear();
            for (int i = 0; i < vinosConActualizacion.Count; i++)
            {
                validar = bodegaSeleccionada.esTuVino(vinosConActualizacion[i].bodegaVino.nombreBodega, bodegaSeleccionada.nombreBodega);
                if (validar)
                {
                    listaVinosActualizadosBodega.Add(vinosConActualizacion[i]);
                }
            }
            
        
        }
        public DateTime getFechaActual()
        {
            DateTime fechaActual = DateTime.Now.Date;
            return fechaActual;

        }

        public void actualizarOCrearVinos(Bodega bodegaSeleccionada, List<Vino> listaVinosActualizadosBodega)
        {
            //Parte de Actualizar
            for (int i = 0; i < listaVinosActualizadosBodega.Count; i++)
            {
                bodegaSeleccionada.actualizarDatosDeVino(listaVinosActualizadosBodega[i], bodegaSeleccionada, vinos, getFechaActual());
            }
        }

        

    }
}
