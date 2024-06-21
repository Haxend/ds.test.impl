using System.Drawing;

namespace ds.test.impl.Interfaces
{
    /// <summary>
    /// Интерфейс для плагина
    /// </summary>
    public interface IPlugin
    {
        /// <value>Название плагина.</value>
        string PluginName { get; }

        /// <value>Версии плагина.</value>
        string Version { get; }

        /// <value>Изображение, представляющее плагин.</value>
        Image? Image { get; }

        /// <value>Краткое описание функционала плагина.</value>
        string Description { get; }

        /// <summary>
        /// Выполняет функциональность плагина с предоставленными входными параметрами.
        /// </summary>
        /// <returns>Результат выполнения плагина.</returns>
        int Run(int input1, int input2);
    }
}
