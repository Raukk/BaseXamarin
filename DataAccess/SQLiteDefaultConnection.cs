using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using General;
using SQLite.Net;
using SQLite.Net.Interop;

namespace DataAccess
{
    /// <summary>
    /// A Quick Attempt at implementing the ISQLite Interface
    /// </summary>
    public class SQLiteDefaultConnection : ISQLite
    {
        // TODO delete this class once each Platform Implementation is done.

        /// <summary>
        /// The Path to the DB
        /// </summary>
        private string dataBasePath;

        /// <summary>
        /// The platform specific to this Sqlite connector
        /// </summary>
        private ISQLitePlatform platform;

        /// <summary>
        /// Create a Default ISQLite object for accessing the SQLite Connection
        /// </summary>
        /// <param name="dataBasePath">The DB Path</param>
        /// <param name="platform">THe Platform</param> 
        public SQLiteDefaultConnection(string dataBasePath, ISQLitePlatform platform)
        {
            this.dataBasePath = dataBasePath;
            this.platform = platform;
        }

        /// <summary>
        /// Gets the SQLite Connection
        /// </summary>
        /// <returns>The SQLite Connection</returns>
        public ISQLiteConnection GetConnection()
        {
            return new SQLiteConnectionWrapper(new SQLiteConnection(this.platform, this.dataBasePath));
        }

    }
}
