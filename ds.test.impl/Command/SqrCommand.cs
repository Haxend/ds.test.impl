using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для возведения в степень
    /// </summary>
    internal class SqrCommand : PluginBase
    {
        /// <inheritdoc/>
        public override string PluginName => "Sqr";

        /// <inheritdoc/>
        public override string Version => "1.0";

        /// <inheritdoc/>
        public override Image? Image => null; // Можно задать иконку плагина

        /// <inheritdoc/>
        public override string Description => "Плагин, возводящий первое число в степень второго числа.";

        /// <inheritdoc/>
        public override int Run(int input1, int input2)
        {
            return (int)Math.Pow(input1, input2);
        }
    }
}
