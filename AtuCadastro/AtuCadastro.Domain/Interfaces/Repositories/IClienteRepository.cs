using AtuCadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtuCadastro.Domain.Interfaces.Repositories
{
  /// <summary>
  /// repositório cliente
  /// </summary>
  public interface IClienteRepository : IRepositoryBase<Cliente>
  {
    /// <summary>
    /// Busca por nome
    /// </summary>
    /// <param name="nome"></param>
    /// <returns></returns>
    IEnumerable<Cliente> BuscaPorNome(string nome);
  }
}
