using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neo.Cryptography;

namespace Neo.UnitTests
{
    [TestClass]
    public class UT_Algorithm
    {
        [TestMethod]
        public void testHash()
        {
            var seeds = Enumerable.Range(0, 3).Select(p => (uint) p * 0xFBA4C795 + 2222).ToArray();

            byte[] element = {100, 2, 3, 4, 5, 100, 2, 3, 4, 5, 100, 2, 3, 4, 5, 100, 2, 3, 4, 5, 100, 2, 3, 4, 5};
            var hashes = seeds.Select(s => element.Murmur32(s));
            foreach (uint i in hashes)
            {
                Assert.IsNotNull(i, String.Format("i is {0}", i));
            }
        }
    }
}