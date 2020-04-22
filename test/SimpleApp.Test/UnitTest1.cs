using System;
using Xunit;
using SimpleApp;

namespace SimpleApp.Test
{
    public class UnitTest1
    { 
        Program program = new Program();
        [Fact]
        public void Get()
        {
            var returnValue = program.Get(1);
            Assert.Equal("yaron" , returnValue.Value);
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
