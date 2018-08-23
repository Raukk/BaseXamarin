using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

namespace General
{
    /// <summary>
    /// This interface defines a way to access the SQLiteConnection
    /// </summary>
    public interface ISQLite
    {

        /// <summary>
        /// Retrieves the SQLiteConnection.
        /// </summary>
        /// <returns>the SQLiteConnection</returns>
        ISQLiteConnection GetConnection();

    }
}
