using System;
using Xunit;
using HelloWorld;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_PrintsHelloWorld()
        {
            // Arrange
            using var sw = new System.IO.StringWriter();
            Console.SetOut(sw);

            // Act
            Program.Main(Array.Empty<string>());

            // Assert
            var result = sw.ToString().Trim();
            Assert.Equal("Hello, World!", result);
        }
    }
}
