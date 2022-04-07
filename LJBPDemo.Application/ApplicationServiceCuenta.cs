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
    public class ApplicationServiceCuenta : IApplicationServiceCuenta
    {
        private readonly IServiceCuenta serviceCuenta;
        private readonly IMapper mapper;

        public ApplicationServiceCuenta(IServiceCuenta serviceCuenta
                                          , IMapper mapper)
        {
            this.serviceCuenta = serviceCuenta;
            this.mapper = mapper;
        }

        public void Add(CuentaDTO cuentaDto)
        {
            var cuenta = mapper.Map<Cuenta>(cuentaDto);
            serviceCuenta.Add(cuenta);
        }

        public void Delete(CuentaDTO cuentaDto)
        {
            var cuenta = mapper.Map<Cuenta>(cuentaDto);
            serviceCuenta.Delete(cuenta);
        }

        public IEnumerable<CuentaDTO> GetAll()
        {
            var cuentas = serviceCuenta.GetAll();
            return mapper.Map<IEnumerable<CuentaDTO>>(cuentas);
        }

        public CuentaDTO GetById(int id)
        {
            var cuenta = serviceCuenta.GetById(id);
            return mapper.Map<CuentaDTO>(cuenta);
        }

        public void Update(CuentaDTO cuentaDto)
        {
            var cuenta = mapper.Map<Cuenta>(cuentaDto);
            serviceCuenta.Update(cuenta);
        }
    }
}
