using System.Drawing;

namespace ds.test.impl.Command
{
    internal class MultiplicationCommand : PluginBase
    {
        public override string PluginName => "Multiplication";
        public override string Version => "1.0";
        public override Image? Image => null; // Можно задать иконку плагина
        public override string Description => "Плагин, умножающий первое число на второе.";
        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
