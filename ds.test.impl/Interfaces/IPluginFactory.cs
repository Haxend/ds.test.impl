﻿namespace ds.test.impl.Interfaces
{
    public interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
