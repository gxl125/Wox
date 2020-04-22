using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Wox.Test
{
    public class XunitTest
    {
        private readonly ITestOutputHelper output;

        public XunitTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Output1Test()
        {
            output.WriteLine("test output1");
            Assert.True(1 == 1);
        }

        [Fact]
        public void Output2Test()
        {
            output.WriteLine("test output2");
            Assert.True(1 == 2);
        }
    }
}
