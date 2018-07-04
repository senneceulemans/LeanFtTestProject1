using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.Web;
using LeanFtTestProject1.FrameWork;
using LeanFtTestProject1.Tasks;

namespace LeanFtTestProject1
{
    [TestClass]
    public class LeanFtTest : UnitTestClassBase<LeanFtTest>
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            ApplicationTasks.LaunchApplication();
        }
       
        [TestMethod]
        public void FirstTest()
        {            
            SearchMenuTasks.SearchProduct();          
        }

        [TestCleanup]
        public void TestCleanup()
        {
            ApplicationTasks.CloseApplication();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}
