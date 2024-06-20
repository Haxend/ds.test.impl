namespace ds.test.impl.UnitTest
{
    public class SqrTest
    {
        [Fact]
        public void Sqr_Run_ReturnCorrectResult()
        {
            // Arrange
            var plugin = Plugins.GetPlugin("Sqr");

            // Act
            var result = plugin.Run(2, 3);

            // Assert
            Assert.Equal(8, result);
        }
    }
}
