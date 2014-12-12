using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtuCadastro.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Repositório Base
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        /// <summary>
        /// Adiciona
        /// </summary>
        /// <param name="obj"></param>
        void Add(TEntity obj);

        /// <summary>
        /// Busca por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(int id);

        /// <summary>
        /// Busca todos
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="obj"></param>
        void Update(TEntity obj);

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="obj"></param>
        void Remove(TEntity obj);

        /// <summary>
        /// Dispose
        /// </summary>
        void Dispose();
    }
}
