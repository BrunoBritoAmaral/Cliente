using AtuCadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

    public bool ValidaTelefoneCelular()
    {
      string strRegex = @"^\(\d{2}\)\d{4}-\d{4}$";

      Regex rgx = new Regex(strRegex);

      MatchCollection matches = rgx.Matches(_cliente.NroTelefoneCelular);

      return matches.Count == 1 && matches[0].Success;
    }
  }
}
