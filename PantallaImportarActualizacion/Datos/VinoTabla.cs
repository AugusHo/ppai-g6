﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PantallaImportarActualizacion.Entidades;

namespace PantallaImportarActualizacion.Datos
{
    public class VinoTabla
    {
        public string Añada { get; set; }
        public string ImagenEtiqueta { get; set; }
        public string Nombre { get; set; }
        public int NotaDeCataBodega { get; set; }
        public float PrecioARS { get; set; }
        public string NombreBodega { get; set; }
        public string DatosMaridaje { get; set; }
        public string FechaActualizacion { get; set; }
    }


}
