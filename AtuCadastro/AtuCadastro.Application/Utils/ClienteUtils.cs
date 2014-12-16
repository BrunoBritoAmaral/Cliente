using AtuCadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtuCadastro.Application.Utils
{
  /// <summary>
  /// Cliente utils
  /// </summary>
  public class ClienteUtils
  {
    private readonly Cliente _cliente;

    public ClienteUtils(Cliente cliente)
    {
      this._cliente = cliente;
    }

    public bool ValidaDataNascimentoMenorDataAtual(DateTime dataAtual)
    {
      return _cliente.DataNascimento < dataAtual;
    }
  }
}
