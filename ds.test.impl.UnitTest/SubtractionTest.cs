using ds.test.impl.Interfaces;

namespace ds.test.impl.UnitTest
{
    public class SubtractionTest
    {
        private readonly IPluginFactory _plugin;

        public SubtractionTest()
        {
            _plugin = new Plugins();
        }

        [Fact]
        public void Subtraction_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Subtraction");

            // Act
            var result = plugin.Run(5, 3);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
