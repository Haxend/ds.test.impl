using ds.test.impl.Command;
using ds.test.impl.Interfaces;

namespace ds.test.impl
{
    /// <summary>
    /// Реализует интерфейс и предоставляет методы для управления плагинами и доступа к ним.
    /// </summary>
    /// Если класс будет статическим, то наследование от реализация интерфейса будет недоступна
    public class Plugins : IPluginFactory
    {
        private readonly List<IPlugin> plugins = new List<IPlugin>
        {
            // Добавление плагинов в коллекцию
            new SummationCommand(),
            new SubtractionCommand(),
            new DivisionCommand(),
            new MultiplicationCommand(),
            new SqrCommand(),
            new SqrtCommand()
        };

        /// <inheritdoc/>
        public int PluginsCount => plugins.Count;

        /// <inheritdoc/>
        public string[] GetPluginNames => plugins.Select(p => p.PluginName).ToArray();

        /// <inheritdoc/>
        public IPlugin GetPlugin(string pluginName)
        {
            var plugin = plugins.FirstOrDefault(p => p.PluginName.Equals(pluginName, StringComparison.OrdinalIgnoreCase));

            if (plugin == null) throw new ArgumentException($"Плагин с именем '{pluginName}' не найден", nameof(pluginName));

            return plugin;
        }
    }
}
