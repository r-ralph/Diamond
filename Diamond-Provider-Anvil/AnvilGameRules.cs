using NBT;

namespace Diamond.Anvil
{
    internal class AnvilGameRules : GameRules
    {
        #region Property

        public override string CommandBlockOutput { get; }

        public override string DisableElytraMovementCheck { get; }

        public override string DoDaylightCycle { get; }

        public override string DoEntityDrops { get; }

        public override string DoFireTick { get; }

        public override string DoMobLoot { get; }

        public override string DoMobSpawning { get; }

        public override string DoTileDrops { get; }

        public override string DoWeatherCycle { get; }

        public override string KeepInventory { get; }

        public override string LogAdminCommands { get; }

        public override string MaxEntityCramming { get; }

        public override string MobGriefing { get; }

        public override string NaturalRegeneration { get; }

        public override string RandomTickSpeed { get; }

        public override string ReducedDebugInfo { get; }

        public override string SendCommandFeedback { get; }

        public override string ShowDeathMessages { get; }

        public override string SpawnRadius { get; }

        public override string SpectatorsGenerateChunks { get; }

        #endregion

        internal AnvilGameRules(TagCompound root)
        {
            var tag = root.GetCompound(Constants.LevelDatTagNameGameRules);
            CommandBlockOutput = tag.GetString(Constants.LevelDatGameRuleTagNameCommandBlockOutput).Value;
            DisableElytraMovementCheck = tag.GetString(Constants.LevelDatGameRuleTagNameDisableElytraMovementCheck)
                .Value;
            DoDaylightCycle = tag.GetString(Constants.LevelDatGameRuleTagNameDoDaylightCycle).Value;
            DoEntityDrops = tag.GetString(Constants.LevelDatGameRuleTagNameDoEntityDrops).Value;
            DoFireTick = tag.GetString(Constants.LevelDatGameRuleTagNameDoFireTick).Value;
            DoMobLoot = tag.GetString(Constants.LevelDatGameRuleTagNameDoMobLoot).Value;
            DoMobSpawning = tag.GetString(Constants.LevelDatGameRuleTagNameDoMobSpawning).Value;
            DoTileDrops = tag.GetString(Constants.LevelDatGameRuleTagNameDoTileDrops).Value;
            DoWeatherCycle = tag.GetString(Constants.LevelDatGameRuleTagNameDoWeatherCycle).Value;
            KeepInventory = tag.GetString(Constants.LevelDatGameRuleTagNameKeepInventory).Value;
            LogAdminCommands = tag.GetString(Constants.LevelDatGameRuleTagNameLogAdminCommands).Value;
            MaxEntityCramming = tag.GetString(Constants.LevelDatGameRuleTagNameMaxEntityCramming).Value;
            MobGriefing = tag.GetString(Constants.LevelDatGameRuleTagNameMobGriefing).Value;
            NaturalRegeneration = tag.GetString(Constants.LevelDatGameRuleTagNameNaturalRegeneration).Value;
            RandomTickSpeed = tag.GetString(Constants.LevelDatGameRuleTagNameRandomTickSpeed).Value;
            ReducedDebugInfo = tag.GetString(Constants.LevelDatGameRuleTagNameReducedDebugInfo).Value;
            SendCommandFeedback = tag.GetString(Constants.LevelDatGameRuleTagNameSendCommandFeedback).Value;
            ShowDeathMessages = tag.GetString(Constants.LevelDatGameRuleTagNameShowDeathMessages).Value;
            SpawnRadius = tag.GetString(Constants.LevelDatGameRuleTagNameSpawnRadius).Value;
            SpectatorsGenerateChunks = tag.GetString(Constants.LevelDatGameRuleTagNameSpectatorsGenerateChunks).Value;
        }
    }
}