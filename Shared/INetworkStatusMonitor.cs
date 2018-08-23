namespace DataAccess.Interfaces
{
    /// <summary>
    /// An interface for generically exposing system network information that the app needs
    /// </summary>
    public interface INetworkStatusMonitor
    {

        // TODO this should add some more details

        /// <summary>
        /// If the device is connected to the internet.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// If the Device is connected using a mobile network
        /// </summary>
        bool Mobile { get; }

        /// <summary>
        /// If the Device is on a WiFi connection
        /// </summary>
        bool IsOnWiFi { get; }

    }
}