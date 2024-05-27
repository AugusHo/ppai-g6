using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PantallaImportarActualizacion.Entidades
{
    class GestorImportadorBodega
    {
        private pantallaActualizarBodega pantalla;
        private List<Bodega> bodegas;
        private List<Bodega> bodegasConActualizacion;
        private Bodega bodegaSeleccionada;
        private List<Vino> vinos;
        private List<Maridaje> maridajes;
        private List<TipoUva> tiposUva;
      
        private List<Vino> vinosConActualizacion;
        private List<Vino> listaVinosAActualizar;
        private List<Vino> listaFinalVinos;
        private List<Vino> listaNuevosVinos;
        private List<Maridaje> listaNuevoVinoMaridaje;
        private List<TipoUva> listaNuevoVinoTU;
        //private bool validar;

        public GestorImportadorBodega(pantallaActualizarBodega pantalla)
        {
            bodegas = Datos.BodegaFactory.DatosBodegas();

            //Llama a todos los vinos de la "base de datos"
            vinos = Datos.VinoFactoy.DatosVinos();

            //LLama a todos los maridajes de la "base de datos"
            maridajes = Datos.MaridajeFactory.DatosMaridajes();

            //Llama a todas las tiposUva de la "base de datos"
            tiposUva = Datos.TipoUvaFactory.DatosTipoUva();

            bodegasConActualizacion = new List<Bodega>();

            //Lista de todos vinos que nos vienen de la API
            vinosConActualizacion = new List<Vino>();

            //Lista de los vinos que tenemos que actualizar
            listaVinosAActualizar = new List<Vino>();

            //Lista de solo los vinos actualizados
            listaFinalVinos = new List<Vino>();

            //Lista de vinos nuevos
            listaNuevosVinos = new List<Vino>();

            listaNuevoVinoMaridaje = new List<Maridaje>();

            listaNuevoVinoTU = new List<TipoUva>();


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
            actualizarOCrearVinos(listaVinosAActualizar, listaNuevosVinos);
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
            Console.WriteLine(listaVinosAActualizar);
        }
 
        public String getFechaActual()
        {
            DateTime fechaActual = DateTime.Now;
            string fechaActualString = fechaActual.ToString("dd-MM-yyyy");
            return fechaActualString;

        }

        public void actualizarOCrearVinos(List<Vino> listaVinosAActualizar, List<Vino> listaNuevosVinos)
        {
            //Parte de Actualizar
            actualizarVino(listaVinosAActualizar);
            //Parte de Crear
            crearVino(listaNuevosVinos);
            //Console.WriteLine(listaNuevosVinos);
        }

        public void actualizarVino(List<Vino> listaVinosAActualizar)
        {
            //Console.WriteLine(listaVinosAActualizar);
            listaFinalVinos.Clear();
            listaNuevosVinos.Clear();
            for (int i = 0; i < listaVinosAActualizar.Count; i++)
                {
                    bodegaSeleccionada.actualizarDatosDeVino(listaVinosAActualizar[i], vinos, getFechaActual(), listaFinalVinos, listaNuevosVinos);
                }
        }

        public void crearVino(List<Vino> creados)
        {
            //por cada uno de los vinos nuevos que no existen en la base de datos de la bodega: nuevos
            for (int i = 0; i < creados.Count; i++)
            {
               for (int j = 0; j < creados[i].maridajeVino.Count; j++)
                {
                    buscarMaridaje(creados[i].maridajeVino[j].nombreMaridaje, listaNuevoVinoMaridaje);
                }

               for (int k = 0; k < creados[i].varietalVino.Count; k++)
                {
                    buscarTipoUva(creados[i].varietalVino[k].tipoUvaVarietal.nombreUva, listaNuevoVinoTU);
                }

                crearNuevoVino(creados[i], listaNuevoVinoMaridaje, listaNuevoVinoTU);
                listaNuevoVinoMaridaje.Clear();
                listaNuevoVinoTU.Clear();
            }
        }

        //Anda
        public void buscarMaridaje(string nombreMaridaje, List<Maridaje> listaNuevoVinoM) {
            for (int i = 0; i < maridajes.Count; i++)
            {
                if (maridajes[i].sosMaridaje(nombreMaridaje, maridajes[i].nombreMaridaje))
                {
                    listaNuevoVinoM.Add(maridajes[i]);
                    Console.WriteLine(listaNuevoVinoM);
                };

            }
        }

        //No Anda
        public void buscarTipoUva(string nombreTipoUva, List<TipoUva> listaNuevoVinoTU)
        {
            for (int i = 0; i < tiposUva.Count; i++)
            {
                if (tiposUva[i].sosTipoUva(nombreTipoUva, tiposUva[i].nombreUva))
                {
                    listaNuevoVinoTU.Add(tiposUva[i]);
                }
            }
        }

        public void crearNuevoVino(Vino creado, List<Maridaje> listaNuevoVinoMaridaje, List<TipoUva> listaNuevoVinoTU)
        {
            Console.WriteLine(listaNuevoVinoMaridaje);
            Vino nuevoVino = new Vino(creado.añadaVino, creado.imagenEtiquetaVino, creado.nombreVino, creado.notaDeCataBodegaVino, creado.precioARSVino, creado.bodegaVino, listaNuevoVinoMaridaje, getFechaActual(), creado.varietalVino);
            vinos.Add(nuevoVino);
            Console.WriteLine(nuevoVino);
            listaFinalVinos.Add(nuevoVino);

        }



    }
}
