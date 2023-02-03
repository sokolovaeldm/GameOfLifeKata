namespace GameOfLife.Tests;

public class GameOfLifeTests
{
    [Fact]
    public void GetCellState()
    {
        var cell = new Cell(true);
        Assert.False(cell.NextGen(1));

    }
}