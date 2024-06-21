using ds.test.impl.Interfaces;

namespace ds.test.impl.UnitTest
{
    public class MultiplicationTest
    {
        private readonly IPluginFactory _plugin;

        public MultiplicationTest()
        {
            _plugin = new Plugins();
        }

        [Fact]
        public void Multiplication_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Multiplication");

            // Act
            var result = plugin.Run(5, 3);

            // Assert
            Assert.Equal(15, result);
        }
    }
}
