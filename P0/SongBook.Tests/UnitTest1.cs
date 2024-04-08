using System;
using System.IO;

namespace SongBook.Tests
{
    public class MenuTests
    {
        [Fact]
        public void ListMenu_WritesMenuOptionsToConsole()
        {
            // Arrange
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Menu.ListMenu();

                // Assert
                string expectedOutput = "1. Record a New Song\r\n2. View SongBook\r\n3. Remove a Record\r\n  Press 9 to exit\r\n";
                Assert.Equal(expectedOutput, sw.ToString());
            }
        }

        [Fact]
        public void UserSelection_ReturnsValidInput()
        {
            // Arrange
            using (StringReader sr = new StringReader("2"))
            {
                Console.SetIn(sr);

                // Act
                int userInput = Menu.UserSelection();

                // Assert
                Assert.Equal(2, userInput);
            }
        }
    }
}

