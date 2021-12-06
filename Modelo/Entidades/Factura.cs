using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaGrupo4.Modelo.Entidades
{
   public  class Factura
    {
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int Id { get; set; }
        public int IdBoleto { get; set; }
        public int IdPasajero { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        public string SubTotal { get; set; }
        public string ISV { get; set; }
        public string Total { get; set; }


    }
}
