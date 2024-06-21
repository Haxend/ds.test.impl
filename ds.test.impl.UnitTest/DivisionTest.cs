using ds.test.impl.Interfaces;

namespace ds.test.impl.UnitTest
{
    public class DivisionTest
    {
        private readonly IPluginFactory _plugin;

        public DivisionTest()
        {
            _plugin = new Plugins();
        }

        [Fact]
        public void Division_Run_ThrowDivideByZeroException()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Division");

            // Act & Assert
            var ex = Assert.Throws<DivideByZeroException>(() => plugin.Run(10, 0));
            Assert.Equal("Деление на ноль не допускается.", ex.Message);
        }

        [Fact]
        public void Division_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Division");

            // Act
            var result = plugin.Run(10, 2);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
