using ArzTiServer.ArzTiService;
using ArzTiServer.Models;
using ArzTiServer.Repositories;
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

        private Mock<IDatenRepository> mockDatenRepository;
        private IDatenRepository dr;
        public ArzTiDatenServiceRezIdListTests()
        {
//            this.mockRepository = new MockRepository(MockBehavior.Strict);
            this.mockRepository = new MockRepository(MockBehavior.Default );

            this.mockDatenRepository = this.mockRepository.Create<IDatenRepository>();
            this.dr = new DatenRepositoryFake();
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
            var service = this.CreateService();
            string apoik = null;
            RezeptTyp? reztyp = RezeptTyp.ERezept ;
            int? maxnum = null;
            string zeitraum = null;

            mockDatenRepository.Setup(d => d.GetERezeptIdListAsync(apoik, maxnum, zeitraum)).Returns(dr.GetERezeptList() );

            // Act
            var result = await service.GetRezeptIdListAsync(
                apoik,
                reztyp,
                maxnum,
                zeitraum);

            // Assert
            Assert.Equal (3, result.Count() );
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListByStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            RezeptTyp? reztyp = null;
            string zeitraum = null;
            mockDatenRepository.Setup(d => d.GetERezeptIdListByStatusAsync(apoik, zeitraum)).ReturnsAsync(dr.GetERezeptList());

            // Act
            var result = await service.GetRezeptIdListByStatusAsync(
                apoik,
                reztyp,
                zeitraum);

            // Assert
            Assert.Equal(3, result.Count());
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListByTransferAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = "123456";
            RezeptTyp? reztyp = RezeptTyp.ERezept;
            string zeitraum = null;

            mockDatenRepository.Setup(d => d.GetERezeptIdListByTransferAsync(apoik, zeitraum)).ReturnsAsync(dr.GetERezeptList());
         
            // Act
            var result = await service.GetRezeptIdListByTransferAsync(
                apoik,
                reztyp,
                zeitraum);

            // Assert
            Assert.Equal(3, result.Count());
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            RezeptTyp reztyp = RezeptTyp.ERezept ;
            string rezid = null;
            mockDatenRepository.Setup(d => d.GetERezeptIdStatusAsync(apoik, rezid)).Returns(dr.GetERezeptList());

            // Act
            var result = await service.GetRezeptIdStatusAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.Equal(3, result.Count());
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutRezeptIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            IEnumerable<Abholstatus> body = null;

            // Act
            var result = await service.PutRezeptIdListAbholstatusAsync(
                apoik,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutRezeptIdListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;
            Rezept body = null;

            // Act
            var result = await service.PutRezeptIdListPruefungAsync(
                apoik,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

    }
}
