using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Repository
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
