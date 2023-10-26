using UnityEngine;

namespace _Source.Core
{
    public class GameManager : MonoBehaviour
    {
        private ResourceBank _resourceBank;
        [SerializeField] private GameObject _resources;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        private void Awake()
        {
            _resourceBank = new ResourceBank();
            foreach (ResourceVisual component in _resources.GetComponentsInChildren<ResourceVisual>())
            {
                _resourceBank.GetResources(component.GameResource).OnValueChanged += component.ValueChanged;
            }
            _resourceBank.ChangeResource(GameResource.Humans, +10);
            _resourceBank.ChangeResource(GameResource.Food, +5);
            _resourceBank.ChangeResource(GameResource.Wood, +5);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
