using LJBPDemo.Application.DTOs;
using System.Collections.Generic;

namespace LJBPDemo.Application.Interfaces
{
    public interface IApplicationServiceCuenta
    {
        void Add(CuentaDTO cuentaDto);

        void Update(CuentaDTO cuentaDto);

        void Delete(CuentaDTO cuentaDto);

        IEnumerable<CuentaDTO> GetAll();

        CuentaDTO GetById(int id);
    }
}