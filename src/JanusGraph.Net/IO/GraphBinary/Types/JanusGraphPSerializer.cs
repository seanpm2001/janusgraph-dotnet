﻿#region License

/*
 * Copyright 2021 JanusGraph.Net Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System.IO;
using System.Threading.Tasks;
using Gremlin.Net.Structure.IO.GraphBinary;

namespace JanusGraph.Net.IO.GraphBinary.Types
{
    internal class JanusGraphPSerializer : JanusGraphTypeSerializer<JanusGraphP>
    {
        public JanusGraphPSerializer() : base(GraphBinaryType.JanusGraphP)
        {
        }

        protected override async Task WriteNonNullableValueAsync(JanusGraphP value, Stream stream,
            GraphBinaryWriter writer)
        {
            await writer.WriteValueAsync(value.OperatorName, stream, false).ConfigureAwait(false);
            await writer.WriteAsync(value.Value, stream).ConfigureAwait(false);
        }

        protected override async Task<JanusGraphP> ReadNonNullableValueAsync(Stream stream, GraphBinaryReader reader)
        {
            var operatorName = (string)await reader.ReadValueAsync<string>(stream, false).ConfigureAwait(false);
            var value = await reader.ReadAsync(stream).ConfigureAwait(false);
            return new JanusGraphP(operatorName, value);
        }
    }
}