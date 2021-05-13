
using ArzTiServer.OpenAPIService;
using ArzTiServer.Repositories;
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

        private Mock<IDatenRepository> mockDatenRepository;

        public ArzTiDatenServiceRezUIdListTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockDatenRepository = this.mockRepository.Create<IDatenRepository>();
        }

        private ArzTiDatenService CreateService()
        {
            return new ArzTiDatenService(
                this.mockDatenRepository.Object);
        }


        [Fact]
        public async Task PutRezeptUIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            IEnumerable<Abholstatus> body = null;

            // Act
            var result = await service.PutRezeptUIdListAbholstatusAsync(
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutRezeptUidListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            IEnumerable<RezeptUId> body = null;
            // Act
            var result = await service.PutRezeptUidListPruefungAsync(
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
