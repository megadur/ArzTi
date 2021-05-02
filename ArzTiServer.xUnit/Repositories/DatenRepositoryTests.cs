using ArzTiServer.Models;
using ArzTiServer.Repositories;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Repositories
{
    public class DatenRepositoryTests
    {
        private MockRepository mockRepository;

        private Mock<ArzDBContext> mockArzDBContext;

        public DatenRepositoryTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockArzDBContext = this.mockRepository.Create<ArzDBContext>();
        }

        private DatenRepository CreateDatenRepository()
        {
            return new DatenRepository(
                this.mockArzDBContext.Object);
        }



        [Fact]
        public void GetMRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();

            // Act
            var result = datenRepository.GetMRezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetOffeneMRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = datenRepository.GetOffeneMRezeptList(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }


        [Fact]
        public void GetPRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();

            // Act
            var result = datenRepository.GetPRezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetOffenePRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = datenRepository.GetOffenePRezeptList(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }


        [Fact]
        public void GetERezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();

            // Act
            var result = datenRepository.GetERezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetOffeneERezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = datenRepository.GetOffeneERezeptList(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListByStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            string zeitraum = null;

            // Act
            var result = await datenRepository.GetERezeptIdListByStatusAsync(
                apoik,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListByTransferAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            string zeitraum = null;

            // Act
            var result = await datenRepository.GetERezeptIdListByTransferAsync(
                apoik,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            string rezid = null;

            // Act
            var result = await datenRepository.GetERezeptIdAsync(
                apoik,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            int? maxnum = null;
            string zeitraum = null;

            // Act
            var result = await datenRepository.GetERezeptIdListAsync(
                apoik,
                maxnum,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            string rezid = null;

            // Act
            var result = await datenRepository.DeleteERezeptIdAsync(
                apoik,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string ruid = null;

            // Act
            var result = await datenRepository.DeleteERezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
