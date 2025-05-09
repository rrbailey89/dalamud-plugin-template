﻿using Dalamud.Configuration;
using Dalamud.Plugin;
using System;

namespace BlameSerena;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;

    public bool IsConfigWindowMovable { get; set; } = true;
    public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;

    // Plugin notification configuration
    public string BotApiEndpoint { get; set; } = "https://blameserena.app/notify/partyfinder";
    public ulong TargetChannelId { get; set; } = 0;
    public ulong RoleId { get; set; } = 0;
    public bool EnableNotifications { get; set; } = false;

    // Party Finder additional fields
    /// <summary>
    /// The password for the party finder listing.
    /// </summary>
    public string PartyFinderPassword { get; set; } = string.Empty;

    // the below exist just to make saving less cumbersome
    public void Save()
    {
        Plugin.PluginInterface.SavePluginConfig(this);
    }
}
