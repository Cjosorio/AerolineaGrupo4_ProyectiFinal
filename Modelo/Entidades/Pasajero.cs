using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaGrupo4.Modelo.Entidades
{
   public  class Pasajero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string Pasaporte { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}
