using AutoMapper;
using LJBPDemo.Application.DTOs;
using LJBPDemo.Application.Interfaces;
using LJBPDemo.Domain.Core.Interfaces.Services;
using LJBPDemo.Domain.Entities;
using System.Collections.Generic;

namespace LJBPDemo.Application
{
    public class ApplicationServicePersona : IApplicationServicePersona
    {
        private readonly IServicePersona servicePersona;
        private readonly IMapper mapper;

        public ApplicationServicePersona(IServicePersona servicePersona
                                            , IMapper mapper)
        {
            this.servicePersona = servicePersona;
            this.mapper = mapper;
        }

        public void Add(PersonaDTO personaDto)
        {
            var persona = mapper.Map<Persona>(personaDto);
            servicePersona.Add(persona);
        }

        public void Delete(PersonaDTO personaDto)
        {
            var persona = mapper.Map<Persona>(personaDto);
            servicePersona.Delete(persona);
        }

        public IEnumerable<PersonaDTO> GetAll()
        {
            var personas = servicePersona.GetAll();
            return mapper.Map<IEnumerable<PersonaDTO>>(personas);
        }

        public PersonaDTO GetById(int id)
        {
            var persona = servicePersona.GetById(id);
            return mapper.Map<PersonaDTO>(persona);
        }

        public void Update(PersonaDTO personaDto)
        {
            var persona = mapper.Map<Persona>(personaDto);
            servicePersona.Update(persona);
        }
    }
}