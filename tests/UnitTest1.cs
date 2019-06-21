using System;
using Xunit;
using api.Controllers;

namespace tests
{
    public class RangeTests
    {
        [Fact]
        public void Test1()
        {
            var range = new Range {Count = 3};
            var generated = range.of(()=>"");
            Assert.Equal(3, gener)

        }
    }
}
