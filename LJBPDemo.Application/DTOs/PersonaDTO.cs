
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Application.DTOs
{
    public  class PersonaDTO
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public class MapProfile : AutoMapper.Profile {
            public MapProfile() 
            {
                CreateMap<Persona, PersonaDTO>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Nombres, opt => opt.MapFrom(src => src.Nombres))
               .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genero))
               .ForMember(dest => dest.Edad, opt => opt.MapFrom(src => src.Edad))
               .ForMember(dest => dest.Identificacion, opt => opt.MapFrom(src => src.Identificacion))
               .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
               .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono));
            }
        }
    }
}
