#region Copyright

// Copyright 2017 Ralph (Tamaki Hidetsugu)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

namespace Diamond
{
    public abstract class Level
    {
        #region Property

        public abstract bool AllowCommands { get; }
        public abstract double BorderCenterX { get; }
        public abstract double BorderCenterZ { get; }
        public abstract double BorderDamagePerBlock { get; }
        public abstract double BorderSafeZone { get; }
        public abstract double BorderSize { get; }
        public abstract double BorderSizeLerpTarget { get; }
        public abstract long BorderSizeLerpTime { get; }
        public abstract double BorderWarningBlocks { get; }
        public abstract double BorderWarningTime { get; }
        public abstract int ClearWeatherTime { get; }
        public abstract int DataVersion { get; }
        public abstract long DayTime { get; }
        public abstract byte Difficulty { get; }
        public abstract bool DifficultyLocked { get; }
        public abstract GameRules GameRules { get; }
        public abstract int GameType { get; }
        public abstract string GeneratorName { get; }
        public abstract string GeneratorOptions { get; }
        public abstract int GeneratorVersion { get; }
        public abstract bool Hardcore { get; }
        public abstract bool Initialized { get; }
        public abstract long LastPlayed { get; }
        public abstract string LevelName { get; }
        public abstract bool MapFeatures { get; }
        public abstract bool Raining { get; }
        public abstract int RainTime { get; }
        public abstract long RandomSeed { get; }
        public abstract long SizeOnDisk { get; }
        public abstract int SpawnX { get; }
        public abstract int SpawnY { get; }
        public abstract int SpawnZ { get; }
        public abstract bool Thundering { get; }
        public abstract int ThunderTime { get; }
        public abstract long Time { get; }
        public abstract int Version { get; }

        #endregion

        public abstract World GetWorld(WorldType type);
        public abstract World GetWorld(int type);
    }
}