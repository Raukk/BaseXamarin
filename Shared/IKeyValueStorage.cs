namespace DataAccess.Interfaces
{
    /// <summary>
    /// A generic interface for storing simple key value strings, excellent for user settings, and such.
    /// </summary>
    public interface IKeyValueStorage
    {

        /// <summary>
        /// Persist a value into storage, or change an existing value
        /// </summary>
        /// <param name="key">Unique string to identify the value</param>
        /// <param name="value">The value stored</param>
        void SaveItem(string key, string value);

        /// <summary>
        /// Gets a value from storage using the key
        /// </summary>
        /// <param name="key">Unique string to identify the value</param>
        /// <returns>The value stored with this key or null</returns>
        string RetriveItem(string key);

    }
}