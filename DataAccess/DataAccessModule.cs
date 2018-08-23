using Autofac;
using General;
using SQLite.Net.Interop;

namespace DataAccess
{
    /// <summary>
    /// Autofac Module for the Data Access Layer
    /// </summary>
    public class DataAccessModule : Module
    {
        /// <summary>
        /// Register all the Data Access layer
        /// </summary>
        /// <param name="builder">Autofac Builder</param>
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterModule(new DataSources.DataSourcesModule());

            builder.Register(x => new SQLiteDefaultConnection(
                x.ResolveNamed<string>(Constants.DataBasePathKey), 
                x.Resolve<ISQLitePlatform>())).As<ISQLite>().SingleInstance();
        }
    }
}
