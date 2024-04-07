namespace SongBook.Tests;

public class SongTests {
    
        [Fact]

           //ClassName_MethodName_ExpectedBehavior
        public void Song_Main_ExitsTheProgram()
        {
            // Arrange
            var fakeConsole = new FakeConsole(new string[] { "9" });

            // Act
            Program.Main(null);

            // Assert
            Assert.Contains("And on that Note...", fakeConsole.Output);
        }

        [Fact]
        public void Song_Main_InvalidInputHandling()
        {
            // Arrange
            var fakeConsole = new FakeConsole(new string[] { "invalid", "9" });

            // Act
            Program.Main(null);

            // Assert
            Assert.Contains("Oops! Try Again", fakeConsole.Output);
        }
}
    

