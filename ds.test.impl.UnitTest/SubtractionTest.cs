namespace ds.test.impl.UnitTest
{
    public class SubtractionTest
    {
        [Fact]
        public void Subtraction_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = Plugins.GetPlugin("Subtraction");

            // Act
            var result = plugin.Run(5, 3);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
