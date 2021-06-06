using ArzTiServer.Api.Model;
using ArzTiServer.Domain.Model;
using ArzTiServer.Domain.Repositories;
using ArzTiServer.Services;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class ArzTiDatenServiceRezUIdListTests
    {
        private MockRepository mockRepository;

        private Mock<IDatenERepository> mockDatenRepository;

        public ArzTiDatenServiceRezUIdListTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockDatenRepository = this.mockRepository.Create<IDatenERepository>();
        }

        private ArzTiDatenService CreateService()
        {
            return new ArzTiDatenService(
                this.mockDatenRepository.Object);
        }


        [Fact(Skip = "not implemented")]
        public async Task PutRezeptUIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            IEnumerable<RezeptUId> body = null;

            // Act
            var result = await service.PatchRezeptUIdListAbholstatusAsync(
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PutRezeptUidListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            List<RezeptUId> body = null;
            // Act
            await service.PutRezeptUidListPruefungAsync(
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
