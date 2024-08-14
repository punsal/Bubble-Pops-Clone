using Data.Abstract;
using UI.Indicator.Abstract;

namespace UI.Indicator
{
    public class NextLevelIndicator : ALevelIndicator
    {
        public override void Show(APlayerData playerData, AColorData colorData)
        {
            var level = playerData.GetLevel() + 1;
            TextUgui.text = level.ToString();
            Background.color = colorData.GetColor(level);
        }
    }
}