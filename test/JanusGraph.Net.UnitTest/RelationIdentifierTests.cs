#region License

/*
 * Copyright 2018 JanusGraph.Net Authors
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

using Xunit;

namespace JanusGraph.Net.UnitTest
{
    public class RelationIdentifierTests
    {
        [Fact]
        public void ToString_ValidRelationId_RelationId()
        {
            const string relationId = "4qp-360-7x1-3aw";
            var relationIdentifier = new RelationIdentifier(relationId);

            Assert.Equal(relationId, relationIdentifier.ToString());
        }

        [Fact]
        public void CtrWithStr_ValidRelationId_ExpectedLongValues()
        {
            var relationIdentifier = new RelationIdentifier("4qp-360-7x1-3aw");

            Assert.Equal(4104, relationIdentifier.OutVertexId);
            Assert.Equal(10261, relationIdentifier.TypeId);
            Assert.Equal(6145, relationIdentifier.RelationId);
            Assert.Equal(4280, relationIdentifier.InVertexId);
        }

        [Fact]
        public void CtrWithLongs_ValidLongValues_ExpectedStringRepresentation()
        {
            var relationIdentifier = new RelationIdentifier(4104, 10261, 6145, 4280);

            Assert.Equal("4qp-360-7x1-3aw", relationIdentifier.StringRepresentation);
            Assert.Equal("4qp-360-7x1-3aw", relationIdentifier.ToString());
        }
    }
}