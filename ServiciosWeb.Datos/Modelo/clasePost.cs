using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWeb.Datos.Modelo
{
    public partial class clasePost
    {
        public int estado { get; set; }
        public Post valor { get; set; }
        public string mensaje { get; set; }
    }
}
