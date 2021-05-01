using ArzTiServer.Models;
using ArzTiServer.OpenAPIService;
using ArzTiServer.Repositories;
using ArzTiServer.Services;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class xArzTiDatenServiceTests
    {
        private MockRepository mockRepository;

        private Mock<ApoDatenDBContext> mockApoDatenDBContext;

        public xArzTiDatenServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockApoDatenDBContext = this.mockRepository.Create<ApoDatenDBContext>();
        }

        private IArzTiDatenService CreateService()
        {
            return null;// new ArzTiDatenService(                this.mockRepository);
        }

        [Fact]
        public async Task TestGetRezepteOffen()
        {
            //arrange
            var datenEmuster16 = new List<ErSenderezepteEmuster16>
            {
                new ErSenderezepteEmuster16{ ApoIkNr =123456, Muster16Id =1L},
                new ErSenderezepteEmuster16{ ApoIkNr =123456, Muster16Id =2L},
                new ErSenderezepteEmuster16{ ApoIkNr =123456, Muster16Id =3L},
                new ErSenderezepteEmuster16{ ApoIkNr =123456, Muster16Id =4L},
                new ErSenderezepteEmuster16{ ApoIkNr =123456, Muster16Id =5L}
            };
            var mock = datenEmuster16.AsQueryable().BuildMockDbSet();
            var datenRepository = new DatenRepository(mock.Object, null, null);
            var service = new IArzTiDatenService(datenRepository);
            //act
            var result = await service.GetRezepteOffen (RezeptTyp.ERezept, "123456", 1, "");
            //assert
            Assert.Equal(1, result.Count);
        }

    }
}