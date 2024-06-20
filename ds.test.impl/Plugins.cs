using ds.test.impl.Command;
using ds.test.impl.Interfaces;

namespace ds.test.impl
{
    public static class Plugins
    {
        private static readonly List<IPlugin> _plugins = new List<IPlugin>();

        static Plugins()
        {
            // Добавление плагинов в коллекцию
            _plugins.Add(new SummationCommand());
            _plugins.Add(new SubtractionCommand());
            _plugins.Add(new DivisionCommand());
            _plugins.Add(new MultiplicationCommand());
            _plugins.Add(new SqrCommand());
            _plugins.Add(new SqrtCommand());
        }

        public static int PluginsCount => _plugins.Count;

        public static string[] GetPluginNames => _plugins.Select(p => p.PluginName).ToArray();

        public static IPlugin GetPlugin(string pluginName) => _plugins.FirstOrDefault(p => p.PluginName.Equals(pluginName, StringComparison.OrdinalIgnoreCase));
    }
}
