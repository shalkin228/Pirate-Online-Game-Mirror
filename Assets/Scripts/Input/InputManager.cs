using Mirror;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Singelton
    public static InputManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameObject(nameof(InputManager)).AddComponent<InputManager>();

            return _instance;
        }
    }

    private static InputManager _instance;
    #endregion

    public InputListener ActiveInputListener { get; private set; }

    private void Awake()
    {
        ActiveInputListener = new KeyboardMouseListener();
    }
}
