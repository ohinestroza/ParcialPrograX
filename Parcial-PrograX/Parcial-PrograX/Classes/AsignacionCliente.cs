using Parcial_PrograX.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Classes
{
    public class AsignacionCliente : IAsignacionCliente, IDescuento
    {
        public double calcularColchonAhorro(Clientes cliente)
        {
            double ColchonAhorro = cliente.monto_donacion * 0.05;
            return ColchonAhorro;
        }

        public double calcularIVA(Clientes cliente)
        {
            double IVA = cliente.monto_donacion * 0.12;
            return IVA;
        }

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

        public void createClient(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public void deleteClient(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public void updateClient(Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
