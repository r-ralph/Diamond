namespace Diamond
{
    public abstract class GameRules
    {
        #region Property

        public abstract string CommandBlockOutput { get; }
        public abstract string DisableElytraMovementCheck { get; }
        public abstract string DoDaylightCycle { get; }
        public abstract string DoEntityDrops { get; }
        public abstract string DoFireTick { get; }
        public abstract string DoMobLoot { get; }
        public abstract string DoMobSpawning { get; }
        public abstract string DoTileDrops { get; }
        public abstract string DoWeatherCycle { get; }
        public abstract string KeepInventory { get; }
        public abstract string LogAdminCommands { get; }
        public abstract string MaxEntityCramming { get; }
        public abstract string MobGriefing { get; }
        public abstract string NaturalRegeneration { get; }
        public abstract string RandomTickSpeed { get; }
        public abstract string ReducedDebugInfo { get; }
        public abstract string SendCommandFeedback { get; }
        public abstract string ShowDeathMessages { get; }
        public abstract string SpawnRadius { get; }
        public abstract string SpectatorsGenerateChunks { get; }

        #endregion
    }
}