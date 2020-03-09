using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.Test
{
    [TestClass]
    public class AssemblyTest
    {
        [AssemblyInitialize]
        public static void AssemplyTest(TestContext tc)
        {
            Console.WriteLine("Assembly Initialized");
        }

        [AssemblyCleanup]
        public static void Assemply_Cleanup_Test()
        {
            Console.WriteLine("Assembly Cleaup");
        }
    }
}
