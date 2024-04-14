using UnityEngine;

namespace Sample1Scripts
{
    public class GameManagerNormalSingleton : MonoBehaviour
    {
        public static GameManagerNormalSingleton Instance { get; private set; }

        public event System.Action OnValueChanged;
        public bool IsValueChanged { get; set; } = false;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        [ContextMenu(nameof(ValueChanged))]
        public void ValueChanged()
        {
            Debug.Log("Value updated on " + nameof(GameManagerNormalSingleton));
            OnValueChanged?.Invoke();
            IsValueChanged = true;
        }
    }    
}