using UnityEngine;

namespace Sample2Scripts
{
    public class UserZenjectSingleton : MonoBehaviour
    {
        IGameManager _gameManager;

        // [Zenject.Inject]
        // public IGameManager GameManager { get; private set; }
        
        [Zenject.Inject]
        private void Constructor([Zenject.Inject]IGameManager gameManager)
        {
            _gameManager = gameManager;
            _gameManager.OnValueChanged += HandleOnValueChanged;
        }

        void OnDisable()
        {
            _gameManager.OnValueChanged -= HandleOnValueChanged;
        }

        void HandleOnValueChanged()
        {
            Debug.Log($"{nameof(UserZenjectSingleton)} {nameof(HandleOnValueChanged)}");
        }
    }
}