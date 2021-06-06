using ArzTiServer.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using ArzTiServer.Api.Controllers.impl;
using ArzTiServer.Api.Model;

namespace ArzTiServer.xUnit.Api.Controllers.impl
{
    public class RezeptIDListApiControllerImplTests
    {
        private MockRepository mockRepository;

        private Mock<IArzTiDatenService> mockArzTiDatenService;

        public RezeptIDListApiControllerImplTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockArzTiDatenService = this.mockRepository.Create<IArzTiDatenService>();
        }

        private RezeptIDListApiControllerImpl CreateRezeptIDListApiControllerImpl()
        {
            return new RezeptIDListApiControllerImpl(
                this.mockArzTiDatenService.Object);
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptIdList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDListApiControllerImpl = this.CreateRezeptIDListApiControllerImpl();
            string apoik = null;
            RezeptTyp? reztyp = null;
            int? maxnum = null;
            string zeitraum = null;
            List<string> status = null;

            // Act
            var result = await rezeptIDListApiControllerImpl.GetRezeptIdList(
                apoik,
                reztyp,
                maxnum,
                zeitraum,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptIdListAbholstatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDListApiControllerImpl = this.CreateRezeptIDListApiControllerImpl();
            string apoik = null;
            RezeptTyp? reztyp = null;
            string zeitraum = null;

            // Act
            var result = await rezeptIDListApiControllerImpl.GetRezeptIdListAbholstatus(
                apoik,
                reztyp,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptIdListPruefRes_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDListApiControllerImpl = this.CreateRezeptIDListApiControllerImpl();
            string apoik = null;
            RezeptTyp? reztyp = null;
            string zeitraum = null;
            List<string> status = null;

            // Act
            var result = await rezeptIDListApiControllerImpl.GetRezeptIdListPruefRes(
                apoik,
                reztyp,
                zeitraum,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptIdStatusList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDListApiControllerImpl = this.CreateRezeptIDListApiControllerImpl();
            string apoik = null;
            RezeptTyp? reztyp = null;
            string zeitraum = null;
            bool? abgeholt = null;

            // Act
            var result = await rezeptIDListApiControllerImpl.GetRezeptIdStatusList(
                apoik,
                reztyp,
                zeitraum,
                abgeholt);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PatchRezeptIdListAbholstatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDListApiControllerImpl = this.CreateRezeptIDListApiControllerImpl();
            string apoik = null;
            List<RezeptId> rezeptId = null;

            // Act
            var result = await rezeptIDListApiControllerImpl.PatchRezeptIdListAbholstatus(
                apoik,
                rezeptId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PatchRezeptIdListStatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDListApiControllerImpl = this.CreateRezeptIDListApiControllerImpl();
            string apoik = null;
            List<RezeptStatus> rezeptStatus = null;

            // Act
            var result = await rezeptIDListApiControllerImpl.PatchRezeptIdListStatus(
                apoik,
                rezeptStatus);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PutRezeptIdListPruefung_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptIDListApiControllerImpl = this.CreateRezeptIDListApiControllerImpl();
            string apoik = null;
            List<RezeptId> rezeptId = null;

            // Act
            var result = await rezeptIDListApiControllerImpl.PutRezeptIdListPruefung(
                apoik,
                rezeptId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
