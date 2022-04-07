using LJBPDemo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJBPDemo.Application.Interfaces
{
    public interface IApplicationServicePersona
    {
        void Add(PersonaDTO personaDto);

        void Update(PersonaDTO personaDto);

        void Delete(PersonaDTO personaDto);

        IEnumerable<PersonaDTO> GetAll();

        PersonaDTO GetById(int id);
    }
}
