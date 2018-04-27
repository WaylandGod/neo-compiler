using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Neo.UnitTests
{
    [TestClass]
    public class UT_Fixed8
    {
        [TestMethod]
        public void Basic_equality()
        {
            var a = Fixed8.FromDecimal(1.23456789m);
            var b = Fixed8.Parse("1.23456789");
            a.Should().Be(b);
        }

        [TestMethod]
        public void Can_parse_exponent_notation()
        {
            Fixed8 expected = Fixed8.FromDecimal(1.23m);
            Fixed8 actual = Fixed8.Parse("1.23E-0");
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void test()
        {
            var d = sizeof(decimal);
            var i = sizeof(int);
            var l = sizeof(long);
            var f = sizeof(float);
            var dd = sizeof(double);
            var by = sizeof(byte);

            var  c = sizeof(char);
            var ss = "zzc199231f06e2091f89e0128e7d875fdfb0fb5fc7c4f916af0c50d04ab70e7z";
            var cc = ss.Length* c;
            var bb = ss.HexToBytes();
                
            
            Fixed8 expected = Fixed8.FromDecimal(123456789m);
            Fixed8 expected1 = Fixed8.FromDecimal(1.23456789m);
            Fixed8 fixedMulti = expected * expected1;
            decimal decimalMulti = 123456789m * 1.23456789m;
            
            
            BigDecimal bd = new BigDecimal(123456789, 1);
            bd.ChangeDecimals(8);
            
            BigDecimal bd1 = new BigDecimal(123456789999, 10);
            bd1.ChangeDecimals(8);
        }
    }
}