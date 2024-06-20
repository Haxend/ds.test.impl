using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для деления
    /// </summary>
    internal class DivisionCommand : PluginBase
    {
        public override string PluginName => "Division";
        public override string Version => "1.0";
        public override Image? Image => null; // Можно задать иконку плагина
        public override string Description => "Плагин, деление первого числа на второе.";
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
