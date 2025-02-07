

namespace CosmageV2.GamePhase
{
    public interface IGameValidator
    {
        /// <summary>
        /// Throws exceptions if necessary game parameters are not configured properly.
        /// </summary>
        public void ValidateGame(GamePhaseManager manager); // TODO maybe don't use manager as param, just access Instance
    }
}
