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
    private IList<Cliente> listaCliente;

    [TestInitialize]
    public void UnitTest1()
    {
      listaCliente = new List<Cliente>();

      listaCliente.Add(new Cliente() { Nome = "Marcus Oliveira Costa" });
      listaCliente.Add(new Cliente() { Nome = "Carlos Luiz de Castro" });
      listaCliente.Add(new Cliente() { Nome = "Maria Inacio de Oliveira" });
      listaCliente.Add(new Cliente() { Nome = "José Ruiz Peres" });
      listaCliente.Add(new Cliente() { Nome = "Marcos José" });
      listaCliente.Add(new Cliente() { Nome = "Ednaldo Pera" });
      listaCliente.Add(new Cliente() { Nome = "Marcus Paiva" });
      listaCliente.Add(new Cliente() { Nome = "Juliana de Paula" });
      listaCliente.Add(new Cliente() { Nome = "Clara Viviane Coelho" });

    }

    [TestMethod]
    public void TestMethod1()
    {
      var moq = new Moq.Mock<IClienteService>();

      moq.Setup(x => x.BuscaPorNome("Marcus")).Returns(listaCliente);
    }
  }
}
