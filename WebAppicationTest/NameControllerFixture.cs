using BaiscWebApplication.Controllers;
using System;
using Xunit;

namespace WebAppicationTest
{
    public class NameControllerFixture
    {
        [Fact]
        public void TestSimpleGet()
        {
            NameController nm = new NameController();
            Assert.Equal("Hello Shubham",nm.Get("Shubham"));
        }
    }
}
