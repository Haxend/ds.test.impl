namespace ds.test.impl.UnitTest
{
    public class MultiplicationTest
    {
        [Fact]
        public void Multiplication_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = Plugins.GetPlugin("Multiplication");

            // Act
            var result = plugin.Run(5, 3);

            // Assert
            Assert.Equal(15, result);
        }
    }
}
