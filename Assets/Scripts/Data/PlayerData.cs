using Data.Abstract;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(menuName = "Data/Player", fileName = "New PlayerData", order = 0)]
    public class PlayerData : APlayerData
    {
        private const ulong LevelUpCost = 20480;
        
        [SerializeField] private ulong score;

        public override ulong GetScore()
        {
            return score;
        }

        public override int GetLevel()
        {
            return (int) (score / LevelUpCost);
        }
    }
}
