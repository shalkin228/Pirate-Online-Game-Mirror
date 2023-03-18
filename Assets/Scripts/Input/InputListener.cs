using UnityEngine;

public abstract class InputListener
{
    public bool IsActive;
    public abstract int Priority { get; }
    public abstract Vector2 Movement { get; }

    protected PlayerActions _playerActions;

    public InputListener() => Initialize();

    public abstract bool CanUse();
    protected virtual void Initialize()
    {
        _playerActions = new PlayerActions();
        _playerActions.Enable();
    }

    public virtual void Deinitialize()
    {
        _playerActions.Disable();
    }
}
