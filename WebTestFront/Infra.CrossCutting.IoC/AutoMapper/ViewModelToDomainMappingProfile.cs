using WebTestFront.Shared.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Infra.CrossCutting.IoC
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClientesViewModel, ClientesModel>();
            //CreateMap<ClientesPostViewModel, ClientesModel>();
            //CreateMap<ClientesPutViewModel, ClientesModel>();

        }
    }
}