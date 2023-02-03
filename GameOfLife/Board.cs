namespace GameOfLife;

public class Board
{
    private readonly int _height;
    private readonly int _width;

    public Board(int height, int width)
    {
        _height = height;
        _width = width;
    }

    public string GetSize()
    {
        return $"{_height}:{_width}";
    }
}