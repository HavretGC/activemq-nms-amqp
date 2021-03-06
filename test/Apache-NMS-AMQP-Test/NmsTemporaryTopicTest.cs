/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Apache.NMS.AMQP;
using Apache.NMS.AMQP.Util;
using NUnit.Framework;

namespace NMS.AMQP.Test
{
    [TestFixture]
    public class NmsTemporaryTopicTest
    {
        [Test]
        public void TestTwoTemporaryTopicsWithTheSameAddressesAreEqual()
        {
            NmsTemporaryTopic nmsTopic1 = new NmsTemporaryTopic(new Id("test")) { Address = "myTopic" };
            NmsTemporaryTopic nmsTopic2 = new NmsTemporaryTopic(new Id("test")) { Address = "myTopic" };

            Assert.AreEqual(nmsTopic1, nmsTopic2);
            Assert.AreNotSame(nmsTopic1, nmsTopic2);
            Assert.AreEqual(nmsTopic1.GetHashCode(), nmsTopic2.GetHashCode());
        }
        
        [Test]
        public void TestTwoTemporaryTopicsWithDifferentAddressesAreNotEqual()
        {
            NmsTemporaryTopic nmsTopic1 = new NmsTemporaryTopic(new Id("test")) { Address = "myTopic" };
            NmsTemporaryTopic nmsTopic2 = new NmsTemporaryTopic(new Id("test")) { Address = "myTopic1" };

            Assert.AreNotEqual(nmsTopic1, nmsTopic2);
            Assert.AreNotEqual(nmsTopic1.GetHashCode(), nmsTopic2.GetHashCode());
        }
    }
}