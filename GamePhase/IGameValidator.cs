

namespace CosmageV2.GamePhase
{
    public interface IGameValidator
    {
        public void ValidateGame(GamePhaseManager manager); // TODO maybe don't use manager as param, just access Instance
    }
}
