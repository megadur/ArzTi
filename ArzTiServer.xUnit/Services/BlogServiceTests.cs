using ArzTiServer.Models;
using ArzTiServer.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class BlogServiceTests
    {
        private MockRepository mockRepository;

        private Mock<BloggingDbContext> mockBloggingDbContext;

        public BlogServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockBloggingDbContext = this.mockRepository.Create<BloggingDbContext>();
        }

        private BlogService CreateService()
        {
            return new BlogService(
                this.mockBloggingDbContext.Object);
        }

        [Fact]
        public void AddBlog_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string name = null;
            string url = null;

            // Act
            var result = service.AddBlog(
                name,
                url);

            // Assert
            //Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetAllBlogs_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = service.GetAllBlogs();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetAllBlogsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = await service.GetAllBlogsAsync();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
