using System;
using Xunit;

namespace selenium_xunit_c_sharp.src.test.test_cases
{
    // IClassFixture<MyFixtureClass> = use to do before class & after class fixture
    public class Sample_Demo : IDisposable, IClassFixture<MyFixtureClass>
    {
        private MyFixtureClass fixtureclass;
       
        //Constructor for setup in xunit instead of setup
        public Sample_Demo(MyFixtureClass fixturesetup) 
        {
            this.fixtureclass = fixturesetup;
            Console.WriteLine("Test start");
        }
        
        [Fact]
        public void test1()
        {
            Console.WriteLine("This is test 1 ");
        }

        // for parameterized
        //[Theory]
        //[InlineData(1,2)] 
        // [InlineData(1, 2)]
        // public void test2(int a, int b)

        [Fact]
        public void test2()
        {
            Console.WriteLine("This is test 2");
        }

        public void Dispose() // teardown test or fact using Dispose
        {
            Console.WriteLine("Test Close or close driver after test");
        }
     
    }

    public class MyFixtureClass :IDisposable
    {
        public MyFixtureClass() //before every class 
        {
            Console.WriteLine("Class start");
        }

        public void Dispose() //After every class
        {
            Console.WriteLine("Class stop");
        }

    }
}
