using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaGrupo4.Modelo.Entidades
{
   public  class Boleto
    {
        public int Id { get; set; }
        public string IDPasajero { get; set; }
        public string Precio { get; set; }
        public string Clase { get; set; }
        public string Asiento { get; set; }
        public string FechaVuelo { get; set; }
    }
}
