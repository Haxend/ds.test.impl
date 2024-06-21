using System.Drawing;
using ds.test.impl.Interfaces;

namespace ds.test.impl
{
    /// <summary>
    /// Предоставляет базовую реализацию подключаемых модулей, реализующую общие функции для <see cref="IPlugin"/>.
    /// </summary>
    internal abstract class PluginBase : IPlugin
    {

        /// <inheritdoc/>
        public abstract string PluginName { get; }

        /// <inheritdoc/>
        public abstract string Version { get; }

        /// <inheritdoc/>
        public abstract Image? Image { get; }

        /// <inheritdoc/>
        public abstract string Description { get; }

        /// <inheritdoc/>
        public abstract int Run(int input1, int input2);
    }
}
