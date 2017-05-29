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
    public abstract class World : IBlockAccess
    {
        protected World()
        {
        }

        public abstract Block GetBlock(int x, int y, int z);

        public abstract Chunk GetChunk(int cx, int cz);

        /// <summary>
        /// If given block is available in this world, return true.
        /// </summary>
        /// <param name="block">Checking block</param>
        /// <returns>If available, return true</returns>
        public abstract bool IsBlockAvailavle(Block block);
    }
}