using UnityEngine;

[CreateAssetMenu(fileName = "New player settings")]
public class PlayerSettings : ScriptableObject
{
    public float Speed { get { return _speed / 100; } }

    [SerializeField] private float _speed;
}
