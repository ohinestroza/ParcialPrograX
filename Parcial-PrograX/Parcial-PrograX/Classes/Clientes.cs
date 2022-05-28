using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Classes
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string apellido_cliente { get; set; }
        public int codigo_postal { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public int id_ciudad {get; set; }
        public int id_donacion { get; set; }
        public double pib { get; set; }

    }
}
