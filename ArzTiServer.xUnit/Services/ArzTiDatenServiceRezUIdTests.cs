using ArzTiServer.Api.Model;
using ArzTiServer.Domain.Model;
using ArzTiServer.Domain.Repositories;
using ArzTiServer.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class ArzTiDatenServiceRezUIdTests
    {
        private MockRepository mockRepository;

        private Mock<IDatenERepository> mockDatenRepository;

        public ArzTiDatenServiceRezUIdTests()
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
        public async Task DeleteRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ruid = null;

            // Act
            var result = await service.DeleteRezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ruid = null;

            // Act
            var result = await service.GetRezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PatchRezeptUIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ruid = null;

            string body = null;
            // Act
            var result = await service.PatchRezeptUIdStatusAsync(
                ruid,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

    }
}
