using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Application.DTOs
{
    public class CuentaDTO


    {
        public int Id { get; set; }
        public long NumeroCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public decimal SaldoInicial { get; set; }
        public bool Estado { get; set; }
        public decimal LimiteDiario { get; set; }
        public decimal SaldoLimiteDiario { get; set; }
        public ICollection<Movimiento> Movimientos { get; set; }
        public Cliente Cliente { get; set; }

        public class MapProfile : AutoMapper.Profile
        {
            public MapProfile()
            {
                CreateMap<Cuenta, CuentaDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NumeroCuenta, opt => opt.MapFrom(src => src.NumeroCuenta))
                .ForMember(dest => dest.TipoCuenta, opt => opt.MapFrom(src => src.TipoCuenta))
                .ForMember(dest => dest.SaldoInicial, opt => opt.MapFrom(src => src.SaldoInicial))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                .ForMember(dest => dest.LimiteDiario, opt => opt.MapFrom(src => src.LimiteDiario))
                .ForMember(dest => dest.SaldoLimiteDiario, opt => opt.MapFrom(src => src.SaldoLimiteDiario))
                .ForMember(dest => dest.Movimientos, opt => opt.MapFrom(src => src.Movimientos))
                .ForMember(dest => dest.Cliente, opt => opt.MapFrom(src => src.Cliente));
            }
        }


    }
}
