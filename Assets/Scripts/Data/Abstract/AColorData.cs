using Data.Common.Abstract;
using UnityEngine;

namespace Data.Abstract
{
    public abstract class AColorData : AData
    {
        /// <summary>
        /// Gets a color from palette
        /// </summary>
        /// <param name="seed">Level index, POT index, etc.</param>
        /// <returns></returns>
        public abstract Color GetColor(int seed);
    }
}