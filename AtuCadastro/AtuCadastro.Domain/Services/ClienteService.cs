using AtuCadastro.Domain.Entities;
using AtuCadastro.Domain.Interfaces.Repositories;
using AtuCadastro.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtuCadastro.Domain.Services
{
  public class ClienteService : ServiceBase<Cliente>, IClienteService
  {
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
      : base(clienteRepository)
    {
      _clienteRepository = clienteRepository;
    }


    public IEnumerable<Cliente> BuscaPorNome(string nome)
    {
      return _clienteRepository.BuscaPorNome(nome);
    }
  }
}
