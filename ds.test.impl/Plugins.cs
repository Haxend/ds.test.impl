using ds.test.impl.Command;
using ds.test.impl.Interfaces;

namespace ds.test.impl
{
    /// <summary>
    /// Реализует интерфейс и предоставляет методы для управления плагинами и доступа к ним.
    /// </summary>
    public static class Plugins
    {
        private static readonly List<IPlugin> plugins = new List<IPlugin>();

        static Plugins()
        {
            // Добавление плагинов в коллекцию
            plugins.Add(new SummationCommand());
            plugins.Add(new SubtractionCommand());
            plugins.Add(new DivisionCommand());
            plugins.Add(new MultiplicationCommand());
            plugins.Add(new SqrCommand());
            plugins.Add(new SqrtCommand());
        }

        /// <inheritdoc/>
        public static int PluginsCount => plugins.Count;

        /// <inheritdoc/>
        public static string[] GetPluginNames => plugins.Select(p => p.PluginName).ToArray();

        /// <inheritdoc/>
        public static IPlugin GetPlugin(string pluginName)
        {
            var plugin = plugins.FirstOrDefault(p => p.PluginName.Equals(pluginName, StringComparison.OrdinalIgnoreCase));

            if (plugin == null) throw new ArgumentException($"Плагин с именем '{pluginName}' не найден", nameof(pluginName));

            return plugin;
        }
    }
}
