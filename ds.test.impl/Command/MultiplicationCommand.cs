using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для умножения
    /// </summary>
    internal class MultiplicationCommand : PluginBase
    {
        /// <inheritdoc/>
        public override string PluginName => "Multiplication";

        /// <inheritdoc/>
        public override string Version => "1.0";

        /// <inheritdoc/>
        public override Image? Image => null; // Можно задать иконку плагина

        /// <inheritdoc/>
        public override string Description => "Плагин, умножающий первое число на второе.";

        /// <inheritdoc/>
        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
