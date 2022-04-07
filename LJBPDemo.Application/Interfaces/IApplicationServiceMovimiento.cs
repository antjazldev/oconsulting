using LJBPDemo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Application.Interfaces
{
    public interface IApplicationServiceMovimiento
    {
        void Add(MovimientoDTO movimientoDTO);

        void Update(MovimientoDTO movimientoDTO);

        void Delete(MovimientoDTO movimientoDTO);

        IEnumerable<MovimientoDTO> GetAll();

        MovimientoDTO GetById(int id);
    }
}
