namespace GameOfLife;

public class Cell
{
    private IState _state;

    public Cell(bool isAlive)
    {
        _state = isAlive ? new AliveState() : new DeadState();
    }

    public bool IsAlive()
    {
        return _state.IsAlive();
    }

    public void SurvivedWith(int aliveNeighbours)
    {
        _state = _state.SurvivedWith(aliveNeighbours);
    }
}

public interface IState
{
    IState SurvivedWith(int aliveNeighbours);
    bool IsAlive();
}

public class AliveState : IState
{
    public IState SurvivedWith(int aliveNeighbours)
    {
        
        if(aliveNeighbours == 2 || aliveNeighbours == 3)
        {
            return this;
        }
        return new DeadState();
    }

    public bool IsAlive()
    {
        return true;
    }
}

public class DeadState : IState
{
    public IState SurvivedWith(int aliveNeighbours)
    {
        if (aliveNeighbours == 3)
        {
            return new AliveState();
        }

        return this;
    }

    public bool IsAlive()
    {
        return false;
    }
}