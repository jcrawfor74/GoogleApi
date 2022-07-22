namespace GoogleApi.Entities.Maps.Geolocation.Request;

/// <summary>
/// The request body's wifiAccessPoints array must contain two or more WiFi access point objects.
/// MacAddress is required.
/// All other fields are optional.
/// </summary>
public class WifiAccessPoint
{
    /// <summary>
    /// Required. The MAC address of the WiFi node. Separators must be : (colon).
    /// </summary>
    public virtual string MacAddress { get; set; }

    /// <summary>
    /// The current signal strength measured in dBm.
    /// </summary>
    public virtual int SignalStrength { get; set; }

    /// <summary>
    /// The number of milliseconds since this access point was detected.
    /// </summary>
    public virtual int Age { get; set; }

    /// <summary>
    /// The channel over which the client is communicating with the access point.
    /// </summary>
    public virtual int Channel { get; set; }

    /// <summary>
    /// The current signal to noise ratio measured in dB.
    /// </summary>
    public virtual int SignalToNoiseRatio { get; set; }
}