using ArzTiServer.Models;
using ArzTiServer.Repositories;
using ArzTiServer.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class ArzTiVerwaltungServiceTests
    {
        private MockRepository mockRepository;

        private Mock<IAsyncRepository<ErApotheke>> mockAsyncRepository;

        public ArzTiVerwaltungServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockAsyncRepository = this.mockRepository.Create<IAsyncRepository<ErApotheke>>();
        }

        private ArzTiVerwaltungService CreateService()
        {
            return new ArzTiVerwaltungService(
                this.mockAsyncRepository.Object);
        }

        [Fact]
        public async Task GetApothekenListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            //arrange
            var daten = new List<ErApotheke>
            {
                new ErApotheke{ ApoIkNr =1L, ApothekeName ="A1"},
                new ErApotheke{ ApoIkNr =12L, ApothekeName ="A2"},
                new ErApotheke{ ApoIkNr =123L, ApothekeName ="A3"},
                new ErApotheke{ ApoIkNr =1234L, ApothekeName ="A4"}

            };
            IEnumerable<ErApotheke> ena = daten;
            var responseTask = Task.FromResult(ena);
            mockAsyncRepository.Setup(a => a.GetAll()).Returns(responseTask);

            // Act
            var result = await service.GetApothekenListAsync();


            // Assert
            Assert.Equal(4, result.Count);
            this.mockRepository.VerifyAll();
        }
    

        [Fact]
        public async Task GetApothekeAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string apoik = null;

            // Act
            var result = await service.GetApothekeByIKAsync(
                apoik);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
