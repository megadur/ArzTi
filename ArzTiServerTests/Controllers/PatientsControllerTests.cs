using ArzTiServer.Controllers;
using ArzTiServer.DataAccess;
using Moq;
using NUnit.Framework;
using System;

namespace ArzTiServerTests.Controllers
{
    [TestFixture]
    public class PatientsControllerTests
    {
        private MockRepository mockRepository;

        private Mock<IHospitalAccessProvider> mockHospitalAccessProvider;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockHospitalAccessProvider = this.mockRepository.Create<IHospitalAccessProvider>();
        }

        private PatientsController CreatePatientsController()
        {
            return new PatientsController(
                this.mockHospitalAccessProvider.Object);
        }

        [Test]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var patientsController = this.CreatePatientsController();

            // Act
            var result = patientsController.Get();

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Create_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var patientsController = this.CreatePatientsController();
            Patient patient = null;

            // Act
            var result = patientsController.Create(
                patient);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Details_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var patientsController = this.CreatePatientsController();
            string id = null;

            // Act
            var result = patientsController.Details(
                id);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Edit_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var patientsController = this.CreatePatientsController();
            Patient patient = null;

            // Act
            var result = patientsController.Edit(
                patient);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void DeleteConfirmed_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var patientsController = this.CreatePatientsController();
            string id = null;

            // Act
            var result = patientsController.DeleteConfirmed(
                id);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
