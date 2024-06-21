using ds.test.impl.Interfaces;

namespace ds.test.impl.UnitTest
{
    public class SqrTest
    {
        private readonly IPluginFactory _plugin;

        public SqrTest()
        {
            _plugin = new Plugins();
        }

        [Fact]
        public void Sqr_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = _plugin.GetPlugin("Sqr");

            // Act
            var result = plugin.Run(2, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
