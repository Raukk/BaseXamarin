namespace General
{
    /// <summary>
    /// An Enum representing the possible combinations of source and destination Datasources.
    /// </summary>
    public enum DataSourceLink
    {
        /// <summary>
        /// The Networked Api is the source Data Source and the Local DB is the Destination Data Source
        /// </summary>
        ApiToDataBase,

        /// <summary>
        /// The Local DB is the source Data Source and the Networked Api is the Destination Data Source
        /// </summary>
        DataBaseToApi,

        /// <summary>
        /// The Blue Tooth Connection is the source Data Source and the Local DB is the Destination Data Source
        /// </summary>
        BlueToothToDataBase, // For replicating Data Across a bluetooth connection, a possilbe future requirement

        /// <summary>
        /// The Local DB is the source Data Source and the Blue Tooth Connection is the Destination Data Source
        /// </summary>
        DataBaseToBlueTooth, // For replicating Data Across a bluetooth connection, a possilbe future requirement
    }

}
