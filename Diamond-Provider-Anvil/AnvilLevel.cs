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

using System;
using System.IO;
using System.IO.Compression;
using NBT;
using NBT.Serialization;

namespace Diamond.Anvil
{
    internal sealed class AnvilLevel : Level
    {
        private readonly DirectoryInfo _path;

        private string _levelName;

        public override string LevelName => _levelName;

        internal AnvilLevel(DirectoryInfo path)
        {
            _path = path;
            Initialize();
        }

        private void Initialize()
        {
            var levelDatFile = new FileInfo(Path.Combine(_path.FullName, Constants.LevelDatFileName));
            if (!levelDatFile.Exists)
            {
                throw new FileNotFoundException(levelDatFile.FullName);
            }
            using (var stream = levelDatFile.OpenRead())
            {
                var levelDat = NbtDocument.LoadDocument(stream);
//                var tag = levelDat.ReadDocument().GetCompound(Constants.LevelDatTagNameData);
//                _levelName = tag.GetString(Constants.LevelDatTagNameLevelName).Value;
            }
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