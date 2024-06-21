using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для деления
    /// </summary>
    internal class DivisionCommand : PluginBase
    {
        /// <inheritdoc/>
        public override string PluginName => "Division";

        /// <inheritdoc/>
        public override string Version => "1.0";

        /// <inheritdoc/>
        public override Image? Image => null; // Можно задать иконку плагина

        /// <inheritdoc/>
        public override string Description => "Плагин, деление первого числа на второе.";

        /// <inheritdoc/>
        public override int Run(int input1, int input2)
        {
            if (input2 == 0)
            {
                throw new DivideByZeroException("Деление на ноль не допускается.");
            }
            return input1 / input2;
        }
    }
}
