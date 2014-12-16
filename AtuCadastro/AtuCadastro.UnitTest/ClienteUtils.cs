using AtuCadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtuCadastro.UnitTest
{
  class ClienteUtils
  {
    private Cliente _cliente;

    public ClienteUtils(Cliente cliente)
    {
      // TODO: Complete member initialization
      this._cliente = cliente;
    }

    public bool ValidaDataNascimentoMenorDataAtual(DateTime dataAtual)
    {
      return _cliente.DataNascimento < dataAtual;
    }
  }
}
