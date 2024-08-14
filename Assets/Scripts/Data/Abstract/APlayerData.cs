using Data.Common.Abstract;

namespace Data.Abstract
{
    public abstract class APlayerData : AData
    {
        public abstract ulong GetScore();
        public abstract int GetLevel();
    }
}
