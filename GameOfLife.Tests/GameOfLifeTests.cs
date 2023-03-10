namespace GameOfLife.Tests;

public class GameOfLifeTests
{

    [Theory]
    [InlineData(true, 1, false)]
    [InlineData(true, 2, true)]
    [InlineData(true, 3, true)]
    [InlineData(true, 4, false)]
    [InlineData(false, 3, true)]
    public void GetCellState(bool isAlive, int aliveNeighbours, bool survived)
    {
        var cell = new Cell(isAlive);
        cell.SurvivedWith(aliveNeighbours);
        
        Assert.Equal(survived, cell.IsAlive());

    }
}