using System;
using System.Collections.Generic;
using Data.Common.Abstract;
using Data.Common.Provider.Abstract;
using UnityEngine;

namespace Data.Common.Provider
{
    public class DataProvider : ADataProvider
    {
        [SerializeField] private List<AData> data;
        
        protected override void Cache(ref Dictionary<Type, AData> container)
        {
            foreach (var dataItem in data)
            {
                container.Add(dataItem.GetType(), dataItem);
            }
        }
    }
}