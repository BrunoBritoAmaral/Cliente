using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AtuCadastro.Domain.Interfaces.Services;
using System.Collections;
using AtuCadastro.Domain.Entities;
using System.Collections.Generic;

namespace AtuCadastro.UnitTest
{
  [TestClass]
  public class UnitTestCliente
  {
    /// <summary>
    /// Valida Data Nascimento Menor Que Data Atual
    /// </summary>
    [TestMethod]
    public void ValidaDataNascimentoMenorQueDataAtual()
    {
      //Cria objeto cliente
      Cliente cliente = new Cliente() { Nome = "Marcus Oliveira Costa", DataNascimento = new DateTime(2014, 12, 18) };

      //Define a data atual
      DateTime dataAtual = new DateTime(2014, 12, 17);

      //Instancia a classe cliente utils
      ClienteUtils clienteUtils = new ClienteUtils(cliente);

      //Confirma que o método ValidaDataNascimentoMenorDataAtual retorna falso caso a data nascimento seja maior que data atual
      Assert.AreEqual(false, clienteUtils.ValidaDataNascimentoMenorDataAtual(dataAtual));
    }
  }
}
