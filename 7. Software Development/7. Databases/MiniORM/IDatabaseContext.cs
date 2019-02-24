using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM
{
    public interface IDatabaseContext
    {
        /// <summary>
        /// Insert or Update entity depending if its attached to the context
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Persist(object entity);

        /// <summary>
        /// Returns entity with data from the db
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T FindById<T>(int id);

        /// <summary>
        /// Find all entities in the database of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<T> FindAll<T>();

        /// <summary>
        /// Finds all entities of type T by given criteria
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        IEnumerable<T> FindAll<T>(string where);

        /// <summary>
        /// Gets the first element in a table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        T FindFirst<T>();

        /// <summary>
        /// Gets the first elements in a table by given criteria
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        T FindFirst<T>(string where);

        /// <summary>
        /// Deletes given object from the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>succesfull removal of object</returns>
        void Delete<T>(object entity);

        /// <summary>
        /// Deletes object of type T with given Id from the database 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns>succesfull removal of object</returns>
        void DeleteById<T>(int id);
    }
}
