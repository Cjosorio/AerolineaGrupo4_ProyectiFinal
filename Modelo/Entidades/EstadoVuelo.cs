using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaGrupo4.Modelo.Entidades
{
    public class EstadoVuelo
    {
        public int Id { get; set; }
        public bool Disponible { get; set; }
        public bool Retrasado { get; set; }
        public bool Cancelado { get; set; }
    }
}
