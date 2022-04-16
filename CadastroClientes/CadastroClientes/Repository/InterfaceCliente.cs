using CadastroClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Repository
{
    public interface InterfaceCliente
    {
        IQueryable<Cliente> GetAll();
        ValueTask<Cliente> Get(int codigo);
        Task Add(Cliente cliente);
        Task Delete(int codigo);
        Task Put(Cliente cliente);
    }
}
