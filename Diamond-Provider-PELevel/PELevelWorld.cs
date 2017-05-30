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

namespace Diamond
{
    /*
    public class PELevelWorld : World
    {
        private PELevelWorld(Stream stream)
        {
        }

        public static World LoadFrom(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }
            if (!stream.CanRead)
            {
                throw new IOException("Can't read from provided stream ");
            }
            var zipArchive = new ZipArchive(stream);
            return new PELevelWorld(stream);
        }

        public override Block GetBlock(int x, int y, int z)
        {
            throw new System.NotImplementedException();
        }

        public override Chunk GetChunk(int cx, int cz)
        {
            throw new NotImplementedException();
        }

        public override bool IsBlockAvailavle(Block block)
        {
            throw new System.NotImplementedException();
        }
    }
    */
}