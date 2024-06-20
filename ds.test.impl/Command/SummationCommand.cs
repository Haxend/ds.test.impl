using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для сложения
    /// </summary>
    internal class SummationCommand : PluginBase
    {
        public override string PluginName => "Summation";
        public override string Version => "1.0";
        public override Image? Image => null; // Можно задать иконку плагина
        public override string Description => "Плагин, сложения двух чисел.";
        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
