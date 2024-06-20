namespace ds.test.impl.Interfaces
{
    /// <summary>
    /// Фабрика плагинов
    /// </summary>
    public interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
