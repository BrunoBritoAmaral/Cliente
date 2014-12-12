using AtuCadastro.Domain.Entities;
using AtuCadastro.EntityFramework.EntityFrameworkConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtuCadastro.EntityFramework.Context
{
    public class AtuCadastroContext : DbContext
    {
        public AtuCadastroContext()
            : base("BaseCliente")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          modelBuilder.Configurations.Add(new ClienteConfiguration());
        }
    }
}
