
public class Elevator
{
    private int _minFloor, _maxFloor, _currentFloor = 1;
    private LoggerFloor _loggerFloor;
    public Elevator(int minFloor, int maxFloor)
    {
        _maxFloor = maxFloor;
        _minFloor = minFloor;
        _loggerFloor = new LoggerFloor();
    }

    public void moveDown() => _currentFloor--;

    public void moveUp() => _currentFloor++;

    public bool move(int floor)
    {
        var flag = true;

        if (floor > _maxFloor || floor < _minFloor)
        {
            flag = false;
        }
        else
        {
            var changeFloor = _currentFloor - floor;
            if (changeFloor < 0) engine(changeFloor, moveUp);
            else engine(changeFloor, moveDown);
        }

        return flag;
    }

    private void engine(int countFloors, Action action)
    {
        for (int i = 0; i < Math.Abs(countFloors); i++)
        {
            action();
            _loggerFloor.LogFloor(getCurrentFloor());
        }
    }

    public int getCurrentFloor() => _currentFloor;

}