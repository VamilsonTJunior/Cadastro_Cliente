using CadastroClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Repository
{
    public class ClienteRepository : InterfaceCliente
    {
        private readonly Contexto _db;

        public ClienteRepository(Contexto db)
        {
            _db = db;
        }

        public IQueryable<Cliente> GetAll()
        {
            return _db.Cliente;
        }

        public ValueTask<Cliente> Get(int codigo)
        {
            return _db.Cliente.FindAsync(codigo);

        }

        public async Task Add(Cliente cliente)
        {
            await _db.AddAsync(cliente);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int codigo)
        {
            Cliente cliente = new Cliente() { codigo = codigo };
            _db.Remove(cliente);
            await _db.SaveChangesAsync();
        }

        public async Task Put(Cliente cliente)
        {
            _db.Cliente.Update(cliente);
            await _db.SaveChangesAsync();
        }
    }
}
