using UnityEngine;

namespace Sample2Scripts
{
    public class GameManagerZenjectDont1 : MonoBehaviour,IGameManagerDont
    {
        [SerializeField] int _value = 0;

        public int Value { get => _value; set => _value = value; }
    }
    
    public class GameManagerZenjectDont2 : IGameManagerDont
    {
        int _value = 0;

        public int Value { get => _value; set => _value = value; }
    }

    public interface IGameManagerDont
    {
        int Value { get; set; }
    }
}