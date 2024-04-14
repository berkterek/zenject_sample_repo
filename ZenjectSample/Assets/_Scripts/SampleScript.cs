using UnityEngine;

namespace Sample2Scripts
{
    public class SampleScript : MonoBehaviour
    {
        IGameManager _gameManager;

        [Zenject.Inject]
        private void Constructor([Zenject.Inject]IGameManager gameManager)
        {
            _gameManager = gameManager;
        }

        [ContextMenu(nameof(ValueChangedFromThisScript))]
        public void ValueChangedFromThisScript()
        {
            _gameManager.ValueChanged();
        }
    }    
}