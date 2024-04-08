using UnityEngine;
using TMPro;

namespace _Source.Core
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] private GameResource _gameResource;
        [SerializeField] private GameObject _currentValue;

        public GameResource GameResource
        {
            get => _gameResource;
        }
        
        internal void ValueChanged(int value)
        {
            _currentValue.GetComponent<TMP_Text>().text = $"{value}";
        }
    }
}
