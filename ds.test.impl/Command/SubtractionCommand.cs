using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для вычитания
    /// </summary>
    internal class SubtractionCommand : PluginBase
    {
        /// <inheritdoc/>
        public override string PluginName => "Subtraction";

        /// <inheritdoc/>
        public override string Version => "1.0";

        /// <inheritdoc/>
        public override Image? Image => null; // Можно задать иконку плагина

        /// <inheritdoc/>
        public override string Description => "Плагин, вычитания второго число из первого.";

        /// <inheritdoc/>
        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
