using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General;
using SQLite.Net;

namespace DataAccess
{
    /// <summary>
    /// Wrapper for SQLite Connections
    /// </summary>
    public class SQLiteConnectionWrapper : ISQLiteConnection
    {

        /// <summary>
        /// The wrapped object
        /// </summary>
        private SQLiteConnection wrapped;

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="wrapped">The object to be Wrapped</param>
        public SQLiteConnectionWrapper(SQLiteConnection wrapped)
        {
            if (null == wrapped)
            {
                throw new ArgumentNullException("wrapped");
            }

            this.wrapped = wrapped;
        }

        /// <summary>
        /// Call Data Base Commit
        /// </summary>
        public void Commit()
        {
            this.wrapped.Commit();
        }

        /// <summary>
        /// Create the table if it doesn't exist
        /// </summary>
        /// <typeparam name="T">The class whose table to create</typeparam>
        /// <returns>Not sure</returns>
        public int CreateTable<T>() where T : class
        {
            return this.wrapped.CreateTable<T>();
        }

        /// <summary>
        /// Dispose the wrapped object
        /// </summary>
        public void Dispose()
        {
            this.wrapped.Dispose();
        }

        /// <summary>
        /// Get an item of class T with the provided Id
        /// </summary>
        /// <typeparam name="T">The Class of Object To get</typeparam>
        /// <param name="id">The Id of the Desired Object</param>
        /// <returns>The object with that Id</returns>
        public T Get<T>(object id) where T : class
        {
            return this.wrapped.Get<T>(id);
        }

        /// <summary>
        /// Insert or update the object in the database
        /// </summary>
        /// <param name="obj">The Object to save or update</param>
        /// <returns>no idea</returns>
        public int InsertOrReplace(object obj)
        {
            return this.wrapped.InsertOrReplace(obj);
        }

        /// <summary>
        /// Insert or Update the Object in the Data Base 
        /// </summary>
        /// <param name="obj">The object to insert</param>
        /// <param name="type">The type of Data to insert it as</param>
        /// <returns>no idea</returns>
        public int InsertOrReplace(object obj, Type type)
        {
            return this.wrapped.InsertOrReplace(obj, type);
        }

        /// <summary>
        /// Get an entire tables worth of data
        /// </summary>
        /// <typeparam name="T">The Class of the Table to get</typeparam>
        /// <returns>The whole table of data</returns>
        public IEnumerable<T> Table<T>() where T : class
        {
            return this.wrapped.Table<T>();
        }

    }
}
