using System.Collections.Generic;

namespace SIV_Pokemons_LL.Services.Interfaces
{
    public interface IRepository<TEntity, TEntityDTO> 
        where TEntity : class
        where TEntityDTO : class
    {
        IEnumerable<TEntityDTO> GetAll();
        TEntityDTO Get(int id);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
    }
}
