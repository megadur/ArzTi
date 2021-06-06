using ArzTiServer.Api.Controllers.impl;
using ArzTiServer.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Api.Controllers.impl
{
    public class RezeptUIDApiControllerImplTests
    {
        private MockRepository mockRepository;

        private Mock<IArzTiDatenService> mockArzTiDatenService;

        public RezeptUIDApiControllerImplTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockArzTiDatenService = this.mockRepository.Create<IArzTiDatenService>();
        }

        private RezeptUIDApiControllerImpl CreateRezeptUIDApiControllerImpl()
        {
            return new RezeptUIDApiControllerImpl(
                this.mockArzTiDatenService.Object);
        }

        [Fact(Skip = "not implemented")]
        public async Task DeleteRezeptUId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptUIDApiControllerImpl = this.CreateRezeptUIDApiControllerImpl();
            string ruid = null;

            // Act
            var result = await rezeptUIDApiControllerImpl.DeleteRezeptUId(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptUId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptUIDApiControllerImpl = this.CreateRezeptUIDApiControllerImpl();
            string ruid = null;

            // Act
            var result = await rezeptUIDApiControllerImpl.GetRezeptUId(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptUIdStatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptUIDApiControllerImpl = this.CreateRezeptUIDApiControllerImpl();
            string ruid = null;

            // Act
            var result = await rezeptUIDApiControllerImpl.GetRezeptUIdStatus(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PatchRezeptUIdStatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptUIDApiControllerImpl = this.CreateRezeptUIDApiControllerImpl();
            string ruid = null;
            string status = null;

            // Act
            var result = await rezeptUIDApiControllerImpl.PatchRezeptUIdStatus(
                ruid,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
