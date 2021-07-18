using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SIV_Pokemons_LL.Services.Interfaces;

namespace SIV_Pokemons_LL.Services.Repositories
{
    public class Repository<TEntity, TEntityDTO> : IRepository<TEntity, TEntityDTO>
        where TEntity : class
        where TEntityDTO : class
    {
        protected DbContext context;
        protected IMapper mapper;
        public Repository(DbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public TEntityDTO Get(int id)
        {
            var result = context.Set<TEntity>().Find(id);
            return mapper.Map<TEntityDTO>(result);
        }

        public IEnumerable<TEntityDTO> GetAll()
        {
            var result = context.Set<TEntity>().ToList();
            return mapper.Map<IEnumerable<TEntityDTO>>(result);
        }

        public TEntity Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            return entity;
        }
    }
}
