using System.Collections.Generic;
using Data.Abstract;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(menuName = "Data/Color", fileName = "New ColorData", order = 1)]
    public class ColorData : AColorData
    {
        [SerializeField] private List<Color> colors;
        
        public override Color GetColor(int seed)
        {
            var index = seed % colors.Count;
            return colors[index];
        }
    }
}