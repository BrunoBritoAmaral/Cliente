using AtuCadastro.Domain.Entities;
using AtuCadastro.WebApi.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtuCadastro.WebApi.AutoMapper
{
  public class ViewModelToDomainMappingProfile : Profile
  {
    public override string ProfileName
    {
      get { return "DomainToViewModelMappings"; }
    }

    protected override void Configure()
    {
      Mapper.CreateMap<Cliente, ClienteViewModel>();
    }
  }
}