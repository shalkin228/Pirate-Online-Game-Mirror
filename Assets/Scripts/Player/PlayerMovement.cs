using UnityEngine;
using Mirror;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] private PlayerSettings _playerSettings;

    private float _speed => _playerSettings.Speed;
    private Vector2 _input => InputManager.Instance.ActiveInputListener.Movement;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        TryMove();
    }

    private void TryMove()
    {
        if (!isLocalPlayer) return;
        if (_input == Vector2.zero) return;

        _rigidbody.MovePosition((Vector2)transform.position + _input * _speed);
    }
}
