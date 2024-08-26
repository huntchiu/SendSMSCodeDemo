using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SendSMSCodeDemo.Repositories;

namespace SendSMSCodeDemo.Services
{
    public class GenericService<TEntity, TDto>
    where TEntity : class
    where TDto : class
    {
        private readonly GenericRepository<TEntity> repository;
        private readonly IMapper mapper;

        public GenericService(GenericRepository<TEntity> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }


        public IEnumerable<TDto> GetAll()
        {
            var entities = repository.GetAll();
            return mapper.Map<IEnumerable<TDto>>(entities);
        }


        public TDto GetById(Guid id)
        {
            var entity = repository.GetById(id);
            return mapper.Map<TDto>(entity);
        }


        public TEntity Create(TDto entityDto)
        {
            var entity = mapper.Map<TEntity>(entityDto);
            repository.Create(entity);
            return entity;
        }

    }
}