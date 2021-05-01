using ArzTiServer.Models;
using ArzTiServer.Repositories;
using ArzTiServer.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class xArzTiVerwaltungServiceTests
    {
        private MockRepository mockRepository;

        private Mock<IVerwaltungRepository> mockVerwaltungRepository;

        public xArzTiVerwaltungServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockVerwaltungRepository = this.mockRepository.Create<IVerwaltungRepository>();
        }

        private ArzTiVerwaltungService CreateService()
        {
            return null;// new ArzTiVerwaltungService(this.mockVerwaltungRepository.Object);
        }

        [Fact]
        public async void TestMethod1()
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
            mockVerwaltungRepository.Setup(a => a.GetApothekeList()).Returns(daten);
            mockVerwaltungRepository.Setup(a => a.GetApothekeDetails("")).Returns(daten[0]);
            //mockVerwaltungRepository.Setup(a => a.GetApothekeQueryable()).Returns(daten);
//            mockVerwaltungRepository.Setup(a => a.GetApothekeQueryable()).Returns<IQueryable<ErApotheke>>(daten);

            // Act
            var result = await service.GetApothekenListAsync();


            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
