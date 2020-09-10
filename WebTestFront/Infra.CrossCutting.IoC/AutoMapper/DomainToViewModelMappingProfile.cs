using AutoMapper;
using Domain.Entities;
using WebTestFront.Shared.ViewModel;

namespace Infra.CrossCutting.IoC
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClientesModel, ClientesViewModel>();
            //CreateMap<ClientesModel, ClientesPostViewModel>();
            //CreateMap<ClientesModel, ClientesPutViewModel>();

        }
    }
}
