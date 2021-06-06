
using ArzTiServer.Api.Model;
using ArzTiServer.Domain.Model;
using ArzTiServer.Domain.Repositories;
using ArzTiServer.Services;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class ArzTiDatenServiceRezIdListTests
    {
        private MockRepository mockRepository;

        private Mock<IDatenERepository> mockDatenRepository;
        private IDatenERepository fake;
        public ArzTiDatenServiceRezIdListTests()
        {
            //            this.mockRepository = new MockRepository(MockBehavior.Strict);
            this.mockRepository = new MockRepository(MockBehavior.Default);

            this.mockDatenRepository = this.mockRepository.Create<IDatenERepository>();
            this.fake = new DatenRepositoryFake();
        }

        private ArzTiDatenService CreateService()
        {
            return new ArzTiDatenService(
                this.mockDatenRepository.Object);
        }

        [Fact]
        public async Task GetRezeptIdListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string apoik = null;
            RezeptTyp? reztyp = RezeptTyp.ERezeptEnum;
            int? maxnum = null;
            string zeitraum = null;
            mockDatenRepository.Setup(d => d.GetERezeptIdListAsync(apoik, maxnum, zeitraum, null)).Returns(fake.GetERezeptIdListAsync(apoik, 0, null, null));
            var service = this.CreateService();


            // Act
            var result = await service.GetRezeptIdListAsync(
                apoik,
                reztyp,
                maxnum,
                zeitraum);

            // Assert
            Assert.Equal(4, result.Count());
            this.mockRepository.VerifyAll();
        }


        [Fact]
        public async Task GetRezeptIdListByTransferAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = "123456";
            RezeptTyp? reztyp = RezeptTyp.ERezeptEnum;
            string zeitraum = null;

            mockDatenRepository.Setup(d => d.xGetERezeptIdListByTransferAsync(apoik, zeitraum)).Returns(fake.GetERezeptIdListAsync(apoik, 0, null, null));

            // Act
            var result = await service.GetRezeptIdListByTransferAsync(
                apoik,
                reztyp,
                zeitraum);

            // Assert
            Assert.Equal(4, result.Count());
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            RezeptTyp reztyp = RezeptTyp.ERezeptEnum;
            string rezid = null;
            ErSenderezepteErezept x = fake.GetERezeptIdListAsync(apoik, 0, null, null).Result[0];
            mockDatenRepository.Setup(d => d.GetERezeptIdStatusAsync(apoik, rezid)).ReturnsAsync(x);

            // Act
            var result = await service.GetRezeptIdStatusAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.Equal("XML1", result.Data);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PutRezeptIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            IEnumerable<RezeptId> body = null;

            // Act
            await service.PatchRezeptIdListAbholstatusAsync(
                apoik,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task PutRezeptIdListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            List<RezeptId> body = null;
            // Act
            await service.PutRezeptIdListPruefungAsync(
                apoik,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

    }
}
