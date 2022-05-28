using Parcial_PrograX.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Classes
{
    public class ColchonAhorro : iColchonAhorro
    {
        public double calcularColchonAhorro(Clientes cliente)
        {
            double ColchonAhorro = cliente.monto_donacion * 0.05;
            return ColchonAhorro;
        }
    }
}
