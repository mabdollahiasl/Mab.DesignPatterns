using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Mab.DesignPatterns;
namespace Mab.DesignPatterns.Test.SimpleTest
{
    public class SimpleUnitTest
    {

        public SimpleUnitTest()
        {
        }

        [Fact]
        public void NullTest()
        {
            Simple simpleTest=new(null);
            Assert.Null(simpleTest.GetInverse());

            simpleTest=new Simple("");
            Assert.Equal("",simpleTest.GetInverse());

        }
        [Fact]
        public void OneCharTest()
        {
            Simple simpleTest = new("a");
            Assert.Equal("a", simpleTest.GetInverse());

        }
        [Fact]
        public void SmallTest()
        {
            Simple simpleTest = new("abc");
            Assert.Equal("cba", simpleTest.GetInverse());
        }


        [Fact]
        public void BigTest()
        {
            Simple simpleTest = new("abcdefghijklmnopqrstuvwxyz");
            Assert.Equal("zyxwvutsrqponmlkjihgfedcba", simpleTest.GetInverse());
        }
    }
}
