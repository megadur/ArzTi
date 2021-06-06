
using ArzTiServer.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using ArzTiServer.Api.Controllers.impl;
using ArzTiServer.Api.Model;

namespace ArzTiServer.xUnit.Api.Controllers.impl
{
    public class RezeptIDApiControllerImplTests
    {
        private MockRepository mockRepository;

        private Mock<IArzTiDatenService> mockArzTiDatenService;

        public RezeptIDApiControllerImplTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockArzTiDatenService = this.mockRepository.Create<IArzTiDatenService>();
        }

        private RezeptIDApiControllerImpl CreateRezeptIDApiControllerImpl()
        {
            return new RezeptIDApiControllerImpl(
                this.mockArzTiDatenService.Object);
        }

        [Fact(Skip = "not implemented")]
        public async Task DeleteRezeptId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDApiControllerImpl = this.CreateRezeptIDApiControllerImpl();
            string apoik = null;
            RezeptTyp reztyp = default(RezeptTyp);
            string rezid = null;

            // Act
            var result = await rezeptIDApiControllerImpl.DeleteRezeptId(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDApiControllerImpl = this.CreateRezeptIDApiControllerImpl();
            string apoik = null;
            RezeptTyp reztyp = default(RezeptTyp);
            string rezid = null;

            // Act
            var result = await rezeptIDApiControllerImpl.GetRezeptId(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptIdStatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDApiControllerImpl = this.CreateRezeptIDApiControllerImpl();
            string apoik = null;
            RezeptTyp reztyp = default(RezeptTyp);
            string rezid = null;

            // Act
            var result = await rezeptIDApiControllerImpl.GetRezeptIdStatus(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PatchRezeptIdStatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDApiControllerImpl = this.CreateRezeptIDApiControllerImpl();
            string apoik = null;
            RezeptTyp reztyp = default(RezeptTyp);
            string rezid = null;
            string status = null;

            // Act
            var result = await rezeptIDApiControllerImpl.PatchRezeptIdStatus(
                apoik,
                reztyp,
                rezid,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
