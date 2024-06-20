namespace ds.test.impl.UnitTest
{
    public class SummationTest
    {
        [Fact]
        public void Summation_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = Plugins.GetPlugin("Summation");

            // Act
            var result = plugin.Run(5, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
