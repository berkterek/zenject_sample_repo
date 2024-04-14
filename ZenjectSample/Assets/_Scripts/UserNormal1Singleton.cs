using System.Collections;
using UnityEngine;

namespace Sample1Scripts
{
    public class UserNormal1Singleton : MonoBehaviour
    {
        // IEnumerator Start()
        // {
        //     //yield return new WaitUntil(() => GameManagerNormalSingleton.Instance != null);
        //     while (GameManagerNormalSingleton.Instance == null)
        //     {
        //         yield return null;
        //     }
        //     
        //     GameManagerNormalSingleton.Instance.OnValueChanged += HandleOnValueChanged;
        // }

        void OnEnable()
        {
            GameManagerNormalSingleton.Instance.OnValueChanged += HandleOnValueChanged;
        }

        void OnDisable()
        {
            if (GameManagerNormalSingleton.Instance == null) return;
            GameManagerNormalSingleton.Instance.OnValueChanged -= HandleOnValueChanged;
        }
        
        void HandleOnValueChanged()
        {
            Debug.Log($"{nameof(HandleOnValueChanged)} {nameof(UserNormal1Singleton)}");
        }
    }    
}