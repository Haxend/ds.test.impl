using System.Drawing;

namespace ds.test.impl.Command
{
    internal class SqrCommand : PluginBase
    {
        public override string PluginName => "Sqr";
        public override string Version => "1.0";
        public override Image? Image => null; // Можно задать иконку плагина
        public override string Description => "Плагин, возводящий первое число в степень второго числа.";
        public override int Run(int input1, int input2)
        {
            return (int)Math.Pow(input1, input2);
        }
    }
}
