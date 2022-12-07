using TicTacToe22;

namespace TicTacToeTest
{
    /**
     * It wasnt clear for at the first what I want to do so I didnt use TDD
    */

    /*
     *I have error and Im writing this test to beable to find the problem faster 
     */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsBoardFilled_Always_ReturnsFalseForEmptyBoard()
        {
            //Arrange
            var apllyRulesService = new ApplyRulesService();
            var emptyBoard= new string[][] { new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" }, new string[] { "Z", "Z", "Z" } };
            //Act
            var expected = apllyRulesService.IsBoardFilled(emptyBoard);

            //Assert
            Assert.AreEqual(false, expected);

        }

        [TestMethod]
        public void IsBoardFilled_Always_ReturnsTrueForFilledBoard()
        {
            //Arrange
            var apllyRulesService = new ApplyRulesService();
            var emptyBoard = new string[][] { new string[] { "X", "X", "X" }, new string[] { "O", "O", "O" }, new string[] { "X", "X", "X" } };
            //Act
            var expected = apllyRulesService.IsBoardFilled(emptyBoard);

            //Assert
            Assert.AreEqual(true, expected);

        }

        [TestMethod]
        public void HasWon_EnteredDiagonalX_ReturnsTrue()
        {
            //Arrange
            var apllyRulesService = new ApplyRulesService();
            var emptyBoard = new string[][] { new string[] { "X", "Z", "Z" }, new string[] { "Z", "X", "Z" }, new string[] { "Z", "Z", "X" } };
            var player = new Player(0, 0, "X");
            
            //Act
            var expected = apllyRulesService.HasWon(player, emptyBoard);

            //Assert
            Assert.AreEqual(true, expected);

        }

        [TestMethod]
        public void HasWon_EnteredReversedDiagonalX_ReturnsTrue()
        {
            //Arrange
            var apllyRulesService = new ApplyRulesService();
            var emptyBoard = new string[][] { new string[] { "Z", "Z", "X" }, new string[] { "Z", "X", "Z" }, new string[] { "X", "Z", "Z" } };
            var player = new Player(0, 0, "X");

            //Act
            var expected = apllyRulesService.HasWon(player, emptyBoard);

            //Assert
            Assert.AreEqual(true, expected);

        }

        [TestMethod]
        public void HasWon_EntereddiagonalY_ReturnsTrue()
        {
            //Arrange
            var apllyRulesService = new ApplyRulesService();
            var emptyBoard = new string[][] { new string[] { "Y", "Z", "Z" }, new string[] { "Z", "Y", "Z" }, new string[] { "Z", "Z", "Y" } };
            var player = new Player(0, 0, "Y");

            //Act
            var expected = apllyRulesService.HasWon(player, emptyBoard);

            //Assert
            Assert.AreEqual(true, expected);

        }
        [TestMethod]
        public void HasWon_EnteredReversedDiagonalY_ReturnsTrue()
        {
            //Arrange
            var apllyRulesService = new ApplyRulesService();
            var emptyBoard = new string[][] { new string[] { "Z", "Z", "Y" }, new string[] { "Z", "Y", "Z" }, new string[] { "Y", "Z", "Z" } };
            var player = new Player(0, 0, "Y");

            //Act
            var expected = apllyRulesService.HasWon(player, emptyBoard);

            //Assert
            Assert.AreEqual(true, expected);

        }
    }
}