using ArzTiServer.OpenAPIService;
using ArzTiServer.Repositories;
using ArzTiServer.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class ArzTiDatenServiceRezIdTests
    {
        private MockRepository mockRepository;

        private Mock<IDatenERepository> mockDatenRepository;

        public ArzTiDatenServiceRezIdTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockDatenRepository = this.mockRepository.Create<IDatenERepository>();
        }

        private ArzTiDatenService CreateService()
        {
            return new ArzTiDatenService(
                this.mockDatenRepository.Object);
        }

        [Fact]
        public async Task DeleteRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            RezeptTyp reztyp = default(RezeptTyp);
            string rezid = null;

            // Act
            var result = await service.DeleteRezeptIdAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            RezeptTyp reztyp = default(RezeptTyp);
            string rezid = null;

            // Act
            var result = await service.GetRezeptIdAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            RezeptTyp reztyp = default(RezeptTyp);
            string rezid = null;

            // Act
            var result = await service.GetRezeptIdStatusAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            string rezid = null;
            RezeptStatus body = null;

            RezeptTyp reztyp = default;
            // Act
            var result = await service.PatchRezeptIdStatusAsync(
                apoik,
                reztyp,
                rezid,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

    }
}
