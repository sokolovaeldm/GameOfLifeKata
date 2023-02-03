namespace GameOfLife.Tests;

public class BoardTests
{
    [Fact]
    public void CreateBoard()
    {
        var board = new Board(10, 10);
        Assert.Equal("10:10", board.GetSize());
    }
}