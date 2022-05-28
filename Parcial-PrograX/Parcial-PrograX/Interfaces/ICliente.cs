using Parcial_PrograX.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Interfaces
{
    interface ICreateClient
    {
        void createClient(Clientes cliente);
    }
    interface IDeleteClient
    {
        void deleteClient(Clientes cliente);
    }

    interface IUpdateClient
    {
        void updateClient(Clientes cliente);
    }

    interface IAsignacionCliente : ICreateClient, IDeleteClient, IUpdateClient
    {

    }

}
