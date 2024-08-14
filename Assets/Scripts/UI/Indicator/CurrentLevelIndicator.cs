using Data.Abstract;
using UI.Indicator.Abstract;

namespace UI.Indicator
{
    public class CurrentLevelIndicator : ALevelIndicator
    {
        public override void Show(APlayerData playerData, AColorData colorData)
        {
            var level = playerData.GetLevel();
            TextUgui.text = level.ToString();
            Background.color = colorData.GetColor(level);
        }
    }
}
