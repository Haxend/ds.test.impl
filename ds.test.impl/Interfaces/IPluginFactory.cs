namespace ds.test.impl.Interfaces
{
    /// <summary>
    /// Определяет методы управления плагинами и доступа к ним.
    /// </summary>
    public interface IPluginFactory
    {
        /// <summary>
        /// Получает количество доступных плагинов.
        /// </summary>
        /// <value>Общее количество плагинов.</value>
        int PluginsCount { get; }

        /// <summary>
        /// Получает имена всех доступных плагинов.
        /// </summary>
        /// <value>Массив названий плагинов.</value>
        string[] GetPluginNames { get; }

        /// <summary>
        /// Получает плагин по его названию.
        /// </summary>
        /// <param name="pluginName">Имя полученного плагина.</param>
        /// <returns><see cref="IPlugin"/> с указанным именем или <c>null</c> если не найден.</returns>
        IPlugin GetPlugin(string pluginName);
    }
}
