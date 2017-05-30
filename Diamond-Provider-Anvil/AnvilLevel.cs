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

using System.IO;
using NBT;

namespace Diamond.Anvil
{
    internal sealed class AnvilLevel : Level
    {
        #region Field

        private readonly DirectoryInfo _path;

        #region Backing field - level.dat

        private bool _allowCommands;
        private double _borderCenterX;
        private double _borderCenterZ;
        private double _borderDamagePerBlock;
        private double _borderSafeZone;
        private double _borderSize;
        private double _borderSizeLerpTarget;
        private long _borderSizeLerpTime;
        private double _borderWarningBlocks;
        private double _borderWarningTime;
        private int _clearWeatherTime;
        private int _dataVersion;
        private long _dayTime;
        private byte _difficulty;
        private bool _difficultyLocked;
        private int _gameType;
        private string _generatorName;
        private string _generatorOptions;
        private int _generatorVersion;
        private bool _hardcore;
        private bool _initialized;
        private long _lastPlayed;
        private string _levelName;
        private bool _mapFeatures;
        private bool _raining;
        private int _rainTime;
        private long _randomSeed;
        private long _sizeOnDisk;
        private int _spawnX;
        private int _spawnY;
        private int _spawnZ;
        private bool _thundering;
        private int _thunderTime;
        private long _time;
        private int _version;

        #endregion

        #endregion

        #region Property

        #region Property - level.dat

        public override bool AllowCommands => _allowCommands;
        public override double BorderCenterX => _borderCenterX;
        public override double BorderCenterZ => _borderCenterZ;
        public override double BorderDamagePerBlock => _borderDamagePerBlock;
        public override double BorderSafeZone => _borderSafeZone;
        public override double BorderSize => _borderSize;
        public override double BorderSizeLerpTarget => _borderSizeLerpTarget;
        public override long BorderSizeLerpTime => _borderSizeLerpTime;
        public override double BorderWarningBlocks => _borderWarningBlocks;
        public override double BorderWarningTime => _borderWarningTime;
        public override int ClearWeatherTime => _clearWeatherTime;
        public override int DataVersion => _dataVersion;
        public override long DayTime => _dayTime;
        public override byte Difficulty => _difficulty;
        public override bool DifficultyLocked => _difficultyLocked;
        public override int GameType => _gameType;
        public override string GeneratorName => _generatorName;
        public override string GeneratorOptions => _generatorOptions;
        public override int GeneratorVersion => _generatorVersion;
        public override bool Hardcore => _hardcore;
        public override bool Initialized => _initialized;
        public override long LastPlayed => _lastPlayed;
        public override string LevelName => _levelName;
        public override bool MapFeatures => _mapFeatures;
        public override bool Raining => _raining;
        public override int RainTime => _rainTime;
        public override long RandomSeed => _randomSeed;
        public override long SizeOnDisk => _sizeOnDisk;
        public override int SpawnX => _spawnX;
        public override int SpawnY => _spawnY;
        public override int SpawnZ => _spawnZ;
        public override bool Thundering => _thundering;
        public override int ThunderTime => _thunderTime;
        public override long Time => _time;
        public override int Version => _version;

        #endregion

        #endregion

        internal AnvilLevel(DirectoryInfo path)
        {
            _path = path;
            LoadLevelDat();
        }

        private void LoadLevelDat()
        {
            var levelDatFile = new FileInfo(Path.Combine(_path.FullName, Constants.LevelDatFileName));
            if (!levelDatFile.Exists)
            {
                throw new FileNotFoundException(levelDatFile.FullName);
            }
            NbtDocument document;
            using (var stream = levelDatFile.OpenRead())
            {
                document = NbtDocument.LoadDocument(stream);
            }
            var level = document.DocumentRoot;
            var tag = level.GetCompound(Constants.LevelDatTagNameData);
            _allowCommands = tag.GetBooleanValue(Constants.LevelDatTagNameAllowCommands);
            _borderCenterX = tag.GetDouble(Constants.LevelDatTagNameBorderCenterX).Value;
            _borderCenterZ = tag.GetDouble(Constants.LevelDatTagNameBorderCenterZ).Value;
            _borderDamagePerBlock = tag.GetDouble(Constants.LevelDatTagNameBorderDamagePerBlock).Value;
            _borderSafeZone = tag.GetDouble(Constants.LevelDatTagNameBorderSafeZone).Value;
            _borderSize = tag.GetDouble(Constants.LevelDatTagNameBorderSize).Value;
            _borderSizeLerpTarget = tag.GetDouble(Constants.LevelDatTagNameBorderSizeLerpTarget).Value;
            _borderSizeLerpTime = tag.GetLong(Constants.LevelDatTagNameBorderSizeLerpTime).Value;
            _borderWarningBlocks = tag.GetDouble(Constants.LevelDatTagNameBorderWarningBlocks).Value;
            _borderWarningTime = tag.GetDouble(Constants.LevelDatTagNameBorderWarningTime).Value;
            _clearWeatherTime = tag.GetInt(Constants.LevelDatTagNameClearWeatherTime).Value;
            _dataVersion = tag.GetInt(Constants.LevelDatTagNameDataVersion).Value;
            _dayTime = tag.GetLong(Constants.LevelDatTagNameDayTime).Value;
            _difficulty = tag.GetByte(Constants.LevelDatTagNameDifficulty).Value;
            _difficultyLocked = tag.GetBooleanValue(Constants.LevelDatTagNameDifficultyLocked);
            _gameType = tag.GetInt(Constants.LevelDatTagNameGameType).Value;
            _generatorName = tag.GetString(Constants.LevelDatTagNameGeneratorName).Value;
            _generatorOptions = tag.GetString(Constants.LevelDatTagNameGeneratorOptions).Value;
            _generatorVersion = tag.GetInt(Constants.LevelDatTagNameGeneratorVersion).Value;
            _hardcore = tag.GetBooleanValue(Constants.LevelDatTagNameHardcore);
            _initialized = tag.GetBooleanValue(Constants.LevelDatTagNameInitialized);
            _lastPlayed = tag.GetLong(Constants.LevelDatTagNameLastPlayed).Value;
            _levelName = tag.GetString(Constants.LevelDatTagNameLevelName).Value;
            _mapFeatures = tag.GetBooleanValue(Constants.LevelDatTagNameMapFeatures);
            _raining = tag.GetBooleanValue(Constants.LevelDatTagNameRaining);
            _rainTime = tag.GetInt(Constants.LevelDatTagNameRainTime).Value;
            _randomSeed = tag.GetLong(Constants.LevelDatTagNameRandomSeed).Value;
            _sizeOnDisk = tag.GetLong(Constants.LevelDatTagNameSizeOnDisk).Value;
            _spawnX = tag.GetInt(Constants.LevelDatTagNameSpawnX).Value;
            _spawnY = tag.GetInt(Constants.LevelDatTagNameSpawnY).Value;
            _spawnZ = tag.GetInt(Constants.LevelDatTagNameSpawnZ).Value;
            _thundering = tag.GetBooleanValue(Constants.LevelDatTagNameThundering);
            _thunderTime = tag.GetInt(Constants.LevelDatTagNameThunderTime).Value;
            _time = tag.GetLong(Constants.LevelDatTagNameTime).Value;
            _version = tag.GetInt(Constants.LevelDatTagNameVersion).Value;
        }

        public override World GetWorld(WorldType type)
        {
            return GetWorld((int) type);
        }

        public override World GetWorld(int type)
        {
            DirectoryInfo regionPath;
            if (type == 0)
            {
                regionPath = new DirectoryInfo(Path.Combine(_path.FullName, Constants.RegionDirectoryName));
            }
            else
            {
                regionPath = new DirectoryInfo(Path.Combine(_path.FullName,
                    $"{Constants.DimentionDirectoryPrefix}{type}", Constants.RegionDirectoryName));
            }
            if (!regionPath.Exists)
            {
                throw new DirectoryNotFoundException(regionPath.FullName);
            }
            return new AnvilWorld(regionPath);
        }
    }
}