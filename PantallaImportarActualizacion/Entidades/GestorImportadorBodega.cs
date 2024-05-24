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
        private List<Vino> listaVinosAActualizar;
        private List<Vino> listaFinalVinos;
        private List<Vino> listaNuevosVinos;
        private bool validar;

        public GestorImportadorBodega(pantallaActualizarBodega pantalla)
        {
            bodegas = Datos.BodegaFactory.DatosBodegas();
            vinos = Datos.VinoFactoy.DatosVinos();
            bodegasConActualizacion = new List<Bodega>();
            //Lista de todos vinos que nos vienen de la API
            vinosConActualizacion = new List<Vino>();
            //Lista de los vinos que tenemos que actualizar
            listaVinosAActualizar = new List<Vino>();
            //Lista de solo los vinos actualizados
            listaFinalVinos = new List<Vino>();
            //Lista de vinos nuevos
            listaNuevosVinos = new List<Vino>();
            this.pantalla = pantalla;
        }

        public List<string> buscarBodegasConActualizacionesPendientes()
        {
            bodegasConActualizacion = bodegas.Where(x => x.estaParaActualizarNovedadesVino()).ToList();
            return bodegasConActualizacion.Select(x => x.nombreBodega).ToList();
        }

        public void tomarSeleccionBodega(string seleccionBodega)
        {
            bodegaSeleccionada = bodegasConActualizacion.FirstOrDefault(x => x.nombreBodega == seleccionBodega);

            obtenerActualizaciones();
            buscarVinosAActualizar();
            actualizarOCrearVinos(listaVinosAActualizar);
            pantalla.mostarResumen(listaFinalVinos, bodegaSeleccionada.nombreBodega);
        }

        //poner debajo de tomarSeleccionBodega()
        public void obtenerActualizaciones()
        {
            vinosConActualizacion = Datos.InterfazAPIBodega.ObtenerActualizaciones();
        }

        public void buscarVinosAActualizar()
        {
            listaVinosAActualizar.Clear();
            for (int i = 0; i < vinosConActualizacion.Count; i++)
            {
                bool validar = bodegaSeleccionada.esTuVino(vinosConActualizacion[i].bodegaVino.nombreBodega, bodegaSeleccionada.nombreBodega);
                if (validar)
                {
                    listaVinosAActualizar.Add(vinosConActualizacion[i]);
                }
                
            }
        }
        public DateTime getFechaActual()
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual;

        }

        public void actualizarOCrearVinos(List<Vino> listaVinosAActualizar)
        {
            //Parte de Actualizar
            actualizarVino(listaVinosAActualizar);
            //Parte de Crear
            
        }

        public void actualizarVino(List<Vino> listaVinos)
        {
            Console.WriteLine(listaVinos);
            listaFinalVinos.Clear();
            for (int i = 0; i < listaVinos.Count; i++)
                {
                    bodegaSeleccionada.actualizarDatosDeVino(listaVinos[i], vinos, getFechaActual(), listaFinalVinos);
                    //listaFinalVinos.Add(listaVinos[i]);
                }
            Console.WriteLine(listaFinalVinos);
        }

        public void crearVino(List<Vino> listaVinos)
        {
            /*for (int i = 0; i < listaVinos.Count; i++)
            {
                
            }*/
        }

    }
}
