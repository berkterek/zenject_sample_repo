using UnityEngine;

namespace Sample1Scripts
{
    public class UserNormal2Singleton : MonoBehaviour
    {
        void Update()
        {
            if (GameManagerNormalSingleton.Instance == null) return;
            if (!GameManagerNormalSingleton.Instance.IsValueChanged) return;

            HandleOnValueChanged();
        }

        void HandleOnValueChanged()
        {
            GameManagerNormalSingleton.Instance.IsValueChanged = false;
            Debug.Log($"{nameof(HandleOnValueChanged)} {nameof(UserNormal2Singleton)}");
        }
    }
}