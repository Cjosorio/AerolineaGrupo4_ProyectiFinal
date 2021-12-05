using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaGrupo4.Modelo.Entidades
{
   public  class Vuelo
    {

        public int Id { get; set; }

        public string Hora_Salidad { get; set; }

        public string Hora_Llegada { get; set; }

        public string Origen { get; set; }

        public string Destino { get; set; }


    }
}
