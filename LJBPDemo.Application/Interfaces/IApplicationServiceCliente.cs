using LJBPDemo.Application.DTOs;
using System.Collections.Generic;

namespace LJBPDemo.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO clienteDto);

        void Update(ClienteDTO clienteDto);

        void Delete(ClienteDTO clienteDto);

        IEnumerable<ClienteDTO> GetAll();

        ClienteDTO GetById(int id);
    }
}