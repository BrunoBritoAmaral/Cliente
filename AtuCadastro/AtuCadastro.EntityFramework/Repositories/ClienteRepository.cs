
using AtuCadastro.Domain.Entities;
using AtuCadastro.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtuCadastro.EntityFramework.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
      public IEnumerable<Cliente> BuscaPorNome(string nome)
        {
            return Db.Clientes.Where(x => x.Nome.Contains(nome)).ToList();
        }
    }
}
