namespace Level24;

public class Door
{
    private int _passcode;
    public DoorState State { get; private set; }

    public Door(int initialPasscode)
    {
        _passcode = initialPasscode;
        State = DoorState.Closed;
    }
    
    public void Close()
    {
        if (State == DoorState.Open) State = DoorState.Closed;
    }

    public void Open()
    {
        if (State == DoorState.Closed) State = DoorState.Open;
    }

    public void Lock()
    {
        if (State == DoorState.Closed) State = DoorState.Locked;
    }

    public void Unlock(int passcode)
    {
        if (State == DoorState.Locked && passcode == _passcode) State = DoorState.Closed;
    }

    public void ChangeCode(int oldPasscode, int newPasscode)
    {
        if (oldPasscode == _passcode) _passcode = newPasscode;
    }
}

public enum DoorState { Open, Closed, Locked }