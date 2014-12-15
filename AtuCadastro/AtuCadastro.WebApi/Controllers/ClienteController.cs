using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AtuCadastro.WebApi.ViewModels;
using AtuCadastro.Application.Interfaces;
using AutoMapper;
using AtuCadastro.Domain.Entities;
using System.Web.Http.Cors;

namespace AtuCadastro.WebApi.Controllers
{
  [EnableCors(origins: "http://localhost:55918", headers: "*", methods: "*")] 
  public class ClienteController : ApiController
  {
    private readonly IClienteAppService _clienteApp;

    public ClienteController(IClienteAppService clienteApp)
    {
      _clienteApp = clienteApp;
    }

    /// <summary>
    /// Get cliente
    /// </summary>
    /// <returns></returns>
    public IEnumerable<ClienteViewModel> GetCliente()
    {
      var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());
      return clienteViewModel;
    }
    
    /// <summary>
    /// Get cliente
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [ResponseType(typeof(ClienteViewModel))]
    public IHttpActionResult GetCliente(int id)
    {
      var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clienteApp.GetById(id));
      if (clienteViewModel == null)
      {
        return NotFound();
      }

      return Ok(clienteViewModel);
    }

    /// <summary>
    /// Put cliente
    /// </summary>
    /// <param name="id"></param>
    /// <param name="clienteViewModel"></param>
    /// <returns></returns>
    public IHttpActionResult PutCliente(int id, ClienteViewModel clienteViewModel)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (id != clienteViewModel.ClienteId)
      {
        return BadRequest();
      }

      var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);

      try
      {
        _clienteApp.Update(clienteDomain);
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ClienteExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return StatusCode(HttpStatusCode.NoContent);
    }

    /// <summary>
    /// Post cliente
    /// </summary>
    /// <param name="clienteViewModel"></param>
    /// <returns></returns>
    [ResponseType(typeof(ClienteViewModel))]
    public IHttpActionResult PostCliente(ClienteViewModel clienteViewModel)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
      _clienteApp.Add(clienteDomain);

      return CreatedAtRoute("DefaultApi", new { id = clienteViewModel.ClienteId }, clienteViewModel);
    }


    private bool ClienteExists(int id)
    {
      return _clienteApp.GetById(id) != null;
    }
  }
}