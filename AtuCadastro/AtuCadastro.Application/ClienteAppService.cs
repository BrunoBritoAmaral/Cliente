using AtuCadastro.Application.Interfaces;
using AtuCadastro.Domain.Entities;
using AtuCadastro.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtuCadastro.Application
{
  public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
  {
    private readonly IClienteService _clienteService;

    public ClienteAppService(IClienteService clienteService)
      : base(clienteService)
    {
      _clienteService = clienteService;
    }

    public IEnumerable<Cliente> BuscaPorNome(string nome)
    {
      return _clienteService.BuscaPorNome(nome);
    }
  }
}
