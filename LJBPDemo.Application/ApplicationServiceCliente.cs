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
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapper mapper;
        public ApplicationServiceCliente(IServiceCliente serviceCliente
                                            ,IMapper mapper)
        {
            this.serviceCliente = serviceCliente;
            this.mapper = mapper;
        }
        public void Add(ClienteDTO clienteDto)
        {
            var cliente = mapper.Map<Cliente>(clienteDto);
            serviceCliente.Add(cliente);
        }

        public void Delete(ClienteDTO clienteDto)
        {
            var cliente = mapper.Map<Cliente>(clienteDto);
            serviceCliente.Delete(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mapper.Map<IEnumerable<ClienteDTO>>(clientes);

        }

        public ClienteDTO GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapper.Map<ClienteDTO>(cliente);
        }

        public void Update(ClienteDTO clienteDto)
        {
            var cliente = mapper.Map<Cliente>(clienteDto);
            serviceCliente.Update(cliente);
        }
    }
}
