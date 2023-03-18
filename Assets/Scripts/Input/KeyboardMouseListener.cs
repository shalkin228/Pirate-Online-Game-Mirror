using UnityEngine;

public class KeyboardMouseListener : InputListener
{
    public override int Priority => _priority;

    public override Vector2 Movement => _playerActions.Keyboard.Walk.ReadValue<Vector2>();

    private readonly int _priority = 3;

    public override bool CanUse() 
    {
        if (Application.platform != RuntimePlatform.WindowsPlayer) return false;

        return true;
    }
}
