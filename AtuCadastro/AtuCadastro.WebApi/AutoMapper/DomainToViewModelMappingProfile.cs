using AtuCadastro.Domain.Entities;
using AtuCadastro.WebApi.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtuCadastro.WebApi.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
  {
    public override string ProfileName
    {
      get { return "ViewModelToDomainMappings"; }
    }

    protected override void Configure()
    {
      Mapper.CreateMap<ClienteViewModel, Cliente>();
    }
  }
}