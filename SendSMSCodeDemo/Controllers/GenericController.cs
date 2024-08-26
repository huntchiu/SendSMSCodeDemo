using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SendSMSCodeDemo.Models.Entities;
using SendSMSCodeDemo.Services;

namespace SendSMSCodeDemo.Controllers
{
    public abstract class GenericController<TEntity, TDto, TRequest, TResponse> : ControllerBase
    where TEntity : BaseEntity
    where TDto : class
    where TRequest : class
    where TResponse : class
    {
        private readonly GenericService<TEntity, TDto> _service;
        private readonly IMapper _mapper;
        public GenericController(GenericService<TEntity, TDto> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TResponse>> Get()
        {
            var entities = _service.GetAll();
            var response = _mapper.Map<IEnumerable<TResponse>>(entities);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<TResponse> GetById(Guid id)
        {
            var entity = _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            var response = _mapper.Map<TResponse>(entity);
            return Ok(response);
        }

        [HttpPost]
        public ActionResult<TResponse> Create([FromBody] TRequest model)
        {
            var entityDto = _mapper.Map<TDto>(model);
            var createdEntity = _service.Create(entityDto);

            var createdEntityDto = _mapper.Map<TDto>(createdEntity);
            var response = _mapper.Map<TResponse>(createdEntityDto);
            return CreatedAtAction(nameof(GetById), new { id = createdEntity.Id }, response);
        }
    }
}