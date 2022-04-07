using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Application.DTOs
{
    public class MovimientoDTO
    {
        public int Id { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
        public Cuenta Cuenta { get; set; }
        public class MapProfile : AutoMapper.Profile
        {
            public MapProfile()
            {
                CreateMap<Movimiento, MovimientoDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FechaMovimiento, opt => opt.MapFrom(src => src.FechaMovimiento))
                .ForMember(dest => dest.TipoMovimiento, opt => opt.MapFrom(src => src.TipoMovimiento))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(src => src.Valor))
                .ForMember(dest => dest.Saldo, opt => opt.MapFrom(src => src.Saldo))
                .ForMember(dest => dest.Cuenta, opt => opt.MapFrom(src => src.Cuenta));
            }
        }
    }
}

