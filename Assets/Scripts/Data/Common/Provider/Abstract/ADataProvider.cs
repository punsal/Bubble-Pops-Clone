using System;
using System.Collections.Generic;
using Data.Common.Abstract;
using UnityEngine;

namespace Data.Common.Provider.Abstract
{
    public abstract class ADataProvider : MonoBehaviour
    {
        private Dictionary<Type, AData> _container;

        private void Awake()
        {
            _container = new Dictionary<Type, AData>();
            Cache(ref _container);
        }

        protected abstract void Cache(ref Dictionary<Type, AData> container);

        public T Get<T>() where T : AData
        {
            return (T)_container[typeof(T)];
        }
    }
}