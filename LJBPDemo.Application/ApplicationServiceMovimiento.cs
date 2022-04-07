using AutoMapper;
using LJBPDemo.Application.DTOs;
using LJBPDemo.Application.Interfaces;
using LJBPDemo.Domain.Core.Interfaces.Services;
using LJBPDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Application
{
    public class ApplicationServiceMovimiento : IApplicationServiceMovimiento
    {
        private readonly IServiceMovimiento serviceMovimiento;
        private readonly IMapper mapper;
        public ApplicationServiceMovimiento(IServiceMovimiento serviceMovimiento
                                           , IMapper mapper)
        {
            this.serviceMovimiento = serviceMovimiento;
            this.mapper = mapper;
        }

        public void Add(MovimientoDTO movimientoDTO)
        {
            var movimiento = mapper.Map<Movimiento>(movimientoDTO);
            serviceMovimiento.Add(movimiento);
        }

        public void Delete(MovimientoDTO movimientoDTO)
        {
            var movimiento = mapper.Map<Movimiento>(movimientoDTO);
            serviceMovimiento.Delete(movimiento);
        }

        public IEnumerable<MovimientoDTO> GetAll()
        {
            var movimientos = serviceMovimiento.GetAll();
            return mapper.Map<IEnumerable<MovimientoDTO>>(movimientos);
        }

        public MovimientoDTO GetById(int id)
        {
            var movimiento = serviceMovimiento.GetById(id);
            return mapper.Map<MovimientoDTO>(movimiento);
        }

        public void Update(MovimientoDTO movimientoDTO)
        {
            var movimiento = mapper.Map<Movimiento>(movimientoDTO);
            serviceMovimiento.Update(movimiento);
        }
    }
}
