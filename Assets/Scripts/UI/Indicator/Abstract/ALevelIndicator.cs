using Data.Abstract;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Indicator.Abstract
{
    public abstract class ALevelIndicator : MonoBehaviour
    {
        [SerializeField] private Image background;
        [SerializeField] private TextMeshProUGUI textUgui;

        protected Image Background => background;
        protected TextMeshProUGUI TextUgui => textUgui;

        public abstract void Show(APlayerData playerData, AColorData colorData);
    }
}