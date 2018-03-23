using Xunit;
using TimelineProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimelineProject.Tests
{
    public class TimelineBuilderTests
    {
        [Fact]
        public void BuildTimeLineTest()
        {
            var timelineBuilder = new TimelineBuilder();
            timelineBuilder.BuildTimeLine();
            Assert.True(false, "This test needs an implementation");
        }
    }
}