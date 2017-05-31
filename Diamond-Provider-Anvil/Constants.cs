namespace Diamond.Anvil
{
    internal static class Constants
    {
        internal const string RegionDirectoryName = "region";
        internal const string DimentionDirectoryPrefix = "DIM";
        internal const string LevelDatFileName = "level.dat";

        #region level.dat

        #region level.dat - root

        internal const string LevelDatTagNameData = "Data";
        internal const string LevelDatTagNameAllowCommands = "allowCommands";
        internal const string LevelDatTagNameBorderCenterX = "BorderCenterX";
        internal const string LevelDatTagNameBorderCenterZ = "BorderCenterZ";
        internal const string LevelDatTagNameBorderDamagePerBlock = "BorderDamagePerBlock";
        internal const string LevelDatTagNameBorderSafeZone = "BorderSafeZone";
        internal const string LevelDatTagNameBorderSize = "BorderSize";
        internal const string LevelDatTagNameBorderSizeLerpTarget = "BorderSizeLerpTarget";
        internal const string LevelDatTagNameBorderSizeLerpTime = "BorderSizeLerpTime";
        internal const string LevelDatTagNameBorderWarningBlocks = "BorderWarningBlocks";
        internal const string LevelDatTagNameBorderWarningTime = "BorderWarningTime";
        internal const string LevelDatTagNameClearWeatherTime = "clearWeatherTime";
        internal const string LevelDatTagNameDataVersion = "DataVersion";
        internal const string LevelDatTagNameDayTime = "DayTime";
        internal const string LevelDatTagNameDifficulty = "Difficulty";
        internal const string LevelDatTagNameDifficultyLocked = "DifficultyLocked";
        internal const string LevelDatTagNameGameRules = "GameRules";
        internal const string LevelDatTagNameGameType = "GameType";
        internal const string LevelDatTagNameGeneratorName = "generatorName";
        internal const string LevelDatTagNameGeneratorOptions = "generatorOptions";
        internal const string LevelDatTagNameGeneratorVersion = "generatorVersion";
        internal const string LevelDatTagNameHardcore = "hardcore";
        internal const string LevelDatTagNameInitialized = "initialized";
        internal const string LevelDatTagNameLastPlayed = "LastPlayed";
        internal const string LevelDatTagNameLevelName = "LevelName";
        internal const string LevelDatTagNameMapFeatures = "MapFeatures";
        internal const string LevelDatTagNameRaining = "raining";
        internal const string LevelDatTagNameRainTime = "rainTime";
        internal const string LevelDatTagNameRandomSeed = "RandomSeed";
        internal const string LevelDatTagNameSizeOnDisk = "SizeOnDisk";
        internal const string LevelDatTagNameSpawnX = "SpawnX";
        internal const string LevelDatTagNameSpawnY = "SpawnY";
        internal const string LevelDatTagNameSpawnZ = "SpawnZ";
        internal const string LevelDatTagNameThundering = "thundering";
        internal const string LevelDatTagNameThunderTime = "thunderTime";
        internal const string LevelDatTagNameTime = "Time";
        internal const string LevelDatTagNameVersion = "version";

        #endregion

        #region level.dat - GameRules

        internal const string LevelDatGameRuleTagNameCommandBlockOutput = "commandBlockOutput";
        internal const string LevelDatGameRuleTagNameDisableElytraMovementCheck = "disableElytraMovementCheck";
        internal const string LevelDatGameRuleTagNameDoDaylightCycle = "doDaylightCycle";
        internal const string LevelDatGameRuleTagNameDoEntityDrops = "doEntityDrops";
        internal const string LevelDatGameRuleTagNameDoFireTick = "doFireTick";
        internal const string LevelDatGameRuleTagNameDoMobLoot = "doMobLoot";
        internal const string LevelDatGameRuleTagNameDoMobSpawning = "doMobSpawning";
        internal const string LevelDatGameRuleTagNameDoTileDrops = "doTileDrops";
        internal const string LevelDatGameRuleTagNameDoWeatherCycle = "doWeatherCycle";
        internal const string LevelDatGameRuleTagNameKeepInventory = "keepInventory";
        internal const string LevelDatGameRuleTagNameLogAdminCommands = "logAdminCommands";
        internal const string LevelDatGameRuleTagNameMaxEntityCramming = "maxEntityCramming";
        internal const string LevelDatGameRuleTagNameMobGriefing = "mobGriefing";
        internal const string LevelDatGameRuleTagNameNaturalRegeneration = "naturalRegeneration";
        internal const string LevelDatGameRuleTagNameRandomTickSpeed = "randomTickSpeed";
        internal const string LevelDatGameRuleTagNameReducedDebugInfo = "reducedDebugInfo";
        internal const string LevelDatGameRuleTagNameSendCommandFeedback = "sendCommandFeedback";
        internal const string LevelDatGameRuleTagNameShowDeathMessages = "showDeathMessages";
        internal const string LevelDatGameRuleTagNameSpawnRadius = "spawnRadius";
        internal const string LevelDatGameRuleTagNameSpectatorsGenerateChunks = "spectatorsGenerateChunks";

        #endregion

        #endregion
    }
}