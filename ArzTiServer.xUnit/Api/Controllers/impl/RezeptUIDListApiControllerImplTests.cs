using ArzTiServer.Api.Controllers.impl;
using ArzTiServer.Api.Model;
using ArzTiServer.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Api.Controllers.impl
{
    public class RezeptUIDListApiControllerImplTests
    {
        private MockRepository mockRepository;

        private Mock<IArzTiDatenService> mockArzTiDatenService;

        public RezeptUIDListApiControllerImplTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockArzTiDatenService = this.mockRepository.Create<IArzTiDatenService>();
        }

        private RezeptUIDListApiControllerImpl CreateRezeptUIDListApiControllerImpl()
        {
            return new RezeptUIDListApiControllerImpl(
                this.mockArzTiDatenService.Object);
        }

        [Fact(Skip = "not implemented")]
        public async Task PatchRezeptUIdListAbholstatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptUIDListApiControllerImpl = this.CreateRezeptUIDListApiControllerImpl();
            List<RezeptUId> rezeptUId = null;

            // Act
            var result = await rezeptUIDListApiControllerImpl.PatchRezeptUIdListAbholstatus(
                rezeptUId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PatchRezeptUIdListStatus_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptUIDListApiControllerImpl = this.CreateRezeptUIDListApiControllerImpl();
            List<RezeptStatus> rezeptStatus = null;

            // Act
            var result = await rezeptUIDListApiControllerImpl.PatchRezeptUIdListStatus(
                rezeptStatus);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PutRezeptUidListPruefung_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var rezeptUIDListApiControllerImpl = this.CreateRezeptUIDListApiControllerImpl();
            List<RezeptUId> rezeptUId = null;

            // Act
            var result = await rezeptUIDListApiControllerImpl.PutRezeptUidListPruefung(
                rezeptUId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
