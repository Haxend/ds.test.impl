using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для сложения
    /// </summary>
    internal class SummationCommand : PluginBase
    {
        /// <inheritdoc/>
        public override string PluginName => "Summation";

        /// <inheritdoc/>
        public override string Version => "1.0";

        /// <inheritdoc/>
        public override Image? Image => null; // Можно задать иконку плагина

        /// <inheritdoc/>
        public override string Description => "Плагин, сложения двух чисел.";

        /// <inheritdoc/>
        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
