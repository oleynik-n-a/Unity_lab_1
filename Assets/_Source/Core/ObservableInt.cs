using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{
    public class ObservableInt
    {
        private int _value;
        public System.Action<int> OnValueChanged;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnValueChanged?.Invoke(value);
            }
        }

        public ObservableInt(int value) 
        {
            _value = value;
        }
    }
}
