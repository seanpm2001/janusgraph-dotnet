#region License

/*
 * Copyright 2023 JanusGraph.Net Authors
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

using Gremlin.Net.Structure.IO.GraphBinary;
using JanusGraph.Net.IO.GraphBinary;
using Xunit;

namespace JanusGraph.Net.IntegrationTest.IO.GraphBinary;

[Collection("JanusGraph Server collection")]
public class GraphBinaryGeoshapeDeserializerTests : GeoshapeDeserializerTests
{
    public GraphBinaryGeoshapeDeserializerTests(JanusGraphServerFixture fixture)
    {
        ConnectionFactory = new RemoteConnectionFactory(fixture.Host, fixture.Port,
            new GraphBinaryMessageSerializer(JanusGraphTypeSerializerRegistry.Instance));
    }

    protected override RemoteConnectionFactory ConnectionFactory { get; }
}