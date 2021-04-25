using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArzTiServer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArzTiServer.Models;

namespace ArzTiServer.Controllers.Tests
{
    [TestClass()]
    public class PatientsControllerTests
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Executes once before the test run. (Optional)
        }
        #region Setup

        [ClassInitialize]
        public static void TestFixtureSetup(DbContextOptions<testdbContext> contextOptions)
        {
            // Executes once for the test class. (Optional)

        }
        protected DbContextOptions<testdbContext> ContextOptions { get; }
        public testdbContext context { get; private set; }
        #endregion

        [TestInitialize]
        public void Setup()
        {
            // Runs before each test. (Optional)
            DbContextOptions<testdbContext> options;
            var builder = new DbContextOptionsBuilder<testdbContext>();
            builder.UseInMemoryDatabase("TestDb");
            options = builder.Options;
            this.context =  new testdbContext(options);
        }
        [ClassCleanup]
        public static void TestFixtureTearDown()
        {
            // Runs once after all tests in this class are executed. (Optional)
            // Not guaranteed that it executes instantly after all tests from the class.
        }
        [TestCleanup]
        public void TearDown()
        {
            // Runs after each test. (Optional)
        }

        [TestMethod()]
        public void GetTest()
        {

            Assert.Fail();
        }
    }
}