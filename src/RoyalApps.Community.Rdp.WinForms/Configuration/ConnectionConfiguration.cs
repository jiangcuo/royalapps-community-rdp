﻿using System.ComponentModel;

namespace RoyalApps.Community.Rdp.WinForms.Configuration;

/// <summary>
/// Connection related configuration and settings.
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ConnectionConfiguration : ExpandableObjectConverter
{
    /// <summary>
    /// Specifies whether compression is enabled.
    /// </summary>
    /// <seealso>
    ///     <cref>https://docs.microsoft.com/en-us/windows/win32/termserv/imstscadvancedsettings-compress</cref>
    /// </seealso>
    public bool Compression { get; set; }
 
    /// <summary>
    /// Specifies whether to enable the client control to reconnect automatically to a session in the event of a network disconnection.
    /// </summary>
    /// <seealso>
    ///     <cref>https://docs.microsoft.com/en-us/windows/win32/termserv/imsrdpclientadvancedsettings2-enableautoreconnect</cref>
    /// </seealso>
    public bool EnableAutoReconnect { get; set; }

    /// <summary>
    /// Specifies the number of times to try to reconnect during automatic reconnection. Valid values are 0 to 200.
    /// </summary>
    /// <seealso>
    ///     <cref>https://docs.microsoft.com/en-us/windows/win32/termserv/imsrdpclientadvancedsettings2-maxreconnectattempts</cref>
    /// </seealso>
    public int MaxReconnectAttempts { get; set; }
    
    /// <summary>
    /// Disables RDP UDP transport and forces TCP transport. It is recommended to set this true when using connection through UDP based VPN connections. 
    /// </summary>
    public bool DisableUdpTransport { get; set; }
    
    /// <summary>
    /// Gets and sets whether to use the redirection server name.
    /// </summary>
    /// <seealso>
    ///     <cref>https://docs.microsoft.com/en-us/windows/win32/termserv/imsrdppreferredredirectioninfo-useredirectionservername</cref>
    /// </seealso>
    public bool UseRedirectionServerName { get; set; }

    /// <summary>
    /// Specifies the load balancing cookie that will be placed in the X.224 Connection Request packet in the Remote Desktop Session Host (RD Session Host) server protocol connection sequence.
    /// </summary>
    /// <seealso>
    ///     <cref>https://docs.microsoft.com/en-us/windows/win32/termserv/imsrdpclientadvancedsettings-loadbalanceinfo</cref>
    /// </seealso>
    public string? LoadBalanceInfo { get; set; }
    
    /// <summary>
    /// ToString
    /// </summary>
    /// <returns>Empty string.</returns>
    public override string ToString()
    {
        return string.Empty;
    }
}