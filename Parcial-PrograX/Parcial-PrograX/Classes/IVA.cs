using Parcial_PrograX.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Classes
{
    public class IVA : iIVA
    {
        public double calcularIVA(Clientes cliente)
        {
            double IVA = cliente.monto_donacion * 0.12;
            return IVA;
        }
    }
}
