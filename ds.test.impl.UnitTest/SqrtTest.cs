using ds.test.impl.Interfaces;

namespace ds.test.impl.UnitTest
{
    public class SqrtTest
    {
        private readonly IPluginFactory _plugin;

        public SqrtTest()
        {
            _plugin = new Plugins();
        }

        [Fact]
        public void Sqrt_Run_ThrowExceptionOnNegativeInput()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Sqrt");

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => plugin.Run(-25, default));
            Assert.Equal("Невозможно вычислить квадратный корень из отрицательного числа.", ex.Message);
        }

        [Fact]
        public void Sqrt_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Sqrt");

            // Act
            var result = plugin.Run(25, default);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
