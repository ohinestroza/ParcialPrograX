using Parcial_PrograX.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Classes
{
    public class ISR : iISR
    {
        public double calcularISR(Clientes cliente)
        {
            double ISR;

            if (cliente.monto_donacion >= 0.01 && cliente.monto_donacion <= 30000)
            {
                ISR = cliente.monto_donacion * 0.05;
            }
            else
            {
                ISR = cliente.monto_donacion * 0.07;
            }
            return ISR;
        }
    }
}
