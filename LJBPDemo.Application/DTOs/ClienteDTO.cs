using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Application.DTOs
{
    public class ClienteDTO : PersonaDTO
    {
        public long IdCliente { get; set; }
        public string Password { get; set; }
        public bool Estado { get; set; }
        public ICollection<Cuenta> Cuentas { get; set; }

        new public class MapProfile : AutoMapper.Profile
        {
            public MapProfile()
            {
                CreateMap<Cliente, ClienteDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombres, opt => opt.MapFrom(src => src.Nombres))
                .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genero))
                .ForMember(dest => dest.Edad, opt => opt.MapFrom(src => src.Edad))
                .ForMember(dest => dest.Identificacion, opt => opt.MapFrom(src => src.Identificacion))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.IdCliente, opt => opt.MapFrom(src => src.IdCliente))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                .ForMember(dest => dest.Cuentas, opt => opt.MapFrom(src => src.Cuentas));
            }
        }
    }
}
