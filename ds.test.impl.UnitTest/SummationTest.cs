using ds.test.impl.Interfaces;

namespace ds.test.impl.UnitTest
{
    public class SummationTest
    {
        private readonly IPluginFactory _plugin;

        public SummationTest()
        {
            _plugin = new Plugins();
        }

        [Fact]
        public void Summation_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Summation");

            // Act
            var result = plugin.Run(5, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
