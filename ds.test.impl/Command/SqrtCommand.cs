using System.Drawing;

namespace ds.test.impl.Command
{
    /// <summary>
    /// Плагин для извлечения квадратного корня
    /// </summary>
    internal class SqrtCommand : PluginBase
    {
        public override string PluginName => "Sqrt";
        public override string Version => "1.0";
        public override Image? Image => null; // Можно задать иконку плагина
        public override string Description => "Плагин, который вычисляет квадратный корень из введенного числа.";
        public override int Run(int input1, int input2)
        {
            if (input1 < 0)
            {
                throw new ArgumentException("Невозможно вычислить квадратный корень из отрицательного числа.");
            }
            return (int)Math.Sqrt(input1);
        }
    }
}
