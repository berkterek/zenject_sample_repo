using System;
using UnityEngine;

namespace Sample2Scripts
{
    public class GameManagerZenject1 : MonoBehaviour,IGameManager
    {
        public event Action OnValueChanged;
        
        [ContextMenu(nameof(ValueChanged))]
        public void ValueChanged()
        {
            Debug.Log("Value updated on " + nameof(GameManagerZenject1));
            OnValueChanged?.Invoke();
        }
    }

    public class GameManagerZenject2 : IGameManager
    {
        public event Action OnValueChanged;
        
        public void ValueChanged()
        {
            Debug.Log("Value updated on " + nameof(GameManagerZenject2));
            OnValueChanged?.Invoke();
        }
    }

    public interface IGameManager
    {
        event System.Action OnValueChanged;
        void ValueChanged();
    }
}