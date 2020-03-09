using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticOperationDemo;

namespace Arithmetic.Test
{
    [TestClass]
    public class ArithmaticTest
    {
        private TestContext testContextinstance;

        public TestContext TestContext
        {
            get { return testContextinstance; }
            set { testContextinstance = value; }
        }


        [ClassInitialize]
        public static void TestClass_Before(TestContext ta)
        {
            Console.WriteLine("Initialize before class");
        }

        [ClassCleanup]
        public static void TestClass_After()
        {
            Console.WriteLine("Initialize After class");
        }

        [TestInitialize]
        public  void BeforeTest()
        {           
            Console.WriteLine("Before Test");
        }


        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("After Test" );
        }

        //"| DataDirectory |\\Arithmetic.xml",
        //DeploymentItem("Arithmetic.xml"),


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "Arithmetic.xml",
                    "Operation", DataAccessMethod.Sequential),  TestMethod]
        public void Test_Divide()
        {
            int input1 = Int32.Parse(TestContext.DataRow["input1"].ToString());
            int input2 = Int32.Parse(TestContext.DataRow["input2"].ToString());
            var output = Int32.Parse(TestContext.DataRow["output"].ToString());
            var actual = ArithmeticOperationDemo.Arithmetic.Divide(input1, input2);
            Assert.AreEqual(output, actual);

        }

        //[Ignore]
        [TestMethod]
        public void Test_Divide_Neg()
        {
            int expected = 3;
            int actual = ArithmeticOperationDemo.Arithmetic.Divide(-9, -3);
            Assert.AreEqual(expected, actual);

        }




    }
}
