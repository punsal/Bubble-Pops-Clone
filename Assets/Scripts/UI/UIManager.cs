using System.Collections.Generic;
using Data;
using Data.Common.Provider.Abstract;
using UI.Indicator.Abstract;
using UnityEngine;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private ADataProvider dataProvider;
        
        [Header("Management")]
        [SerializeField] private List<ALevelIndicator> levelIndicators;

        public void ShowLevelIndicators()
        {
            var playerData = dataProvider.Get<PlayerData>();
            var colorData = dataProvider.Get<ColorData>();

            foreach (var levelIndicator in levelIndicators)
            {
                levelIndicator.Show(playerData, colorData);
            }
        }
    }
}