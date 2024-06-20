using System.Drawing;

namespace ds.test.impl.Command
{
    internal class SubtractionCommand : PluginBase
    {
        public override string PluginName => "Вычитание";
        public override string Version => "1.0";
        public override Image? Image => null; // Можно задать иконку плагина
        public override string Description => "Плагин, вычитания второго число из первого.";
        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
