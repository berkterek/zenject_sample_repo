using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sample2Scripts
{
    public class UserZenjectSingleton2 : MonoBehaviour
    {
        IGameManagerDont _gameManager;
        
        [Zenject.Inject]
        private void Constructor([Zenject.Inject]IGameManagerDont gameManager)
        {
            _gameManager = gameManager;
        }

        [ContextMenu(nameof(UpdateManagerValue))]
        public void UpdateManagerValue()
        {
            _gameManager.Value++;
            Debug.Log($"{_gameManager.Value}");
        }
        
        [ContextMenu(nameof(LoadSameScene))]
        public void LoadSameScene()
        {
            SceneManager.LoadScene(0);
        }
    }
}