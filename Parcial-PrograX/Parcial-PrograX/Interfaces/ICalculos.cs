using Parcial_PrograX.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Interfaces
{
    interface iColchonAhorro
    {
        double calcularColchonAhorro(Clientes cliente);
    }

    interface iIVA
    {
        double calcularIVA(Clientes cliente);
    }

    interface iISR
    {
        double calcularISR(Clientes cliente);
    }

    interface IDescuento : iColchonAhorro, iIVA, iISR
    {

    }
}
