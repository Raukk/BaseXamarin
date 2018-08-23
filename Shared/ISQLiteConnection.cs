using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    /// <summary>
    /// Wrapper Interface for SQLiteConnection which sadly doesn't have one
    /// </summary>
    public interface ISQLiteConnection : IDisposable
    {

        /// <summary>
        /// Call Data Base Commit
        /// </summary>
        void Commit();

        /// <summary>
        /// Insert or update the object in the database
        /// </summary>
        /// <param name="obj">The Object to save or update</param>
        /// <returns>no idea</returns>
        int InsertOrReplace(object obj);

        /// <summary>
        /// Insert or Update the Object in the Data Base 
        /// </summary>
        /// <param name="obj">The object to insert</param>
        /// <param name="type">The type of Data to insert it as</param>
        /// <returns>no idea</returns>
        int InsertOrReplace(object obj, Type type);

        /// <summary>
        /// Create the table if it doesn't exist
        /// </summary>
        /// <typeparam name="T">The class whose table to create</typeparam>
        /// <returns>Not sure</returns>
        int CreateTable<T>() where T : class;

        /// <summary>
        /// Get an entire tables worth of data
        /// </summary>
        /// <typeparam name="T">The Class of the Table to get</typeparam>
        /// <returns>The whole table of data</returns>
        IEnumerable<T> Table<T>() where T : class;

        /// <summary>
        /// Get an item of class T with the provided Id
        /// </summary>
        /// <typeparam name="T">The Class of Object To get</typeparam>
        /// <param name="id">The Id of the Desired Object</param>
        /// <returns>The object with that Id</returns>
        T Get<T>(object id) where T : class;

    }
}
