using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWeb.WepApi.Controllers
{
  internal class ServAsigS
    {

        public string ServAsigId { get; set; }
        public string ProveedorNombre { get; set; }
        public string ServAsigFHInicio { get; set; }
        public string ServAsigFHFin { get; set; }
        public string ServAsigFHPago { get; set; }
        public string StatusServAsigId { get; set; }
        public string servAsigCalificacion { get; set; }
    }
}