using AutoMapper;
using LJBPDemo.Application.DTOs;
using LJBPDemo.Domain.Entities;

namespace LJBPDemo.API

{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonaDTO, Persona>();
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<CuentaDTO, Cuenta>();
            CreateMap<MovimientoDTO, Movimiento>();
        }
    }
}
