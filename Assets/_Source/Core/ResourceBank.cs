using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
    public enum GameResource
    {
        Humans,
        Food,
        Wood,
        Stone,
        Gold
    }

    public class ResourceBank
    {
        private Dictionary<GameResource, ObservableInt> _bank;

        public ResourceBank()
        {
            _bank = new Dictionary<GameResource, ObservableInt>();
            _bank[GameResource.Humans] = new ObservableInt();
            _bank[GameResource.Food] = new ObservableInt();
            _bank[GameResource.Wood] = new ObservableInt();
            _bank[GameResource.Stone] = new ObservableInt();
            _bank[GameResource.Gold] = new ObservableInt();
        }
        
        public void ChangeResource(GameResource resource, int deltaValue)
        {
            _bank[resource].Value += deltaValue;
        }

        public ObservableInt GetResources(GameResource resource)
        {
            return _bank[resource];
        }
    }
}
