using ArzTiServer.Api.Controllers.impl;
using ArzTiServer.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Api.Controllers.impl
{
    public class ApothekeApiImplTests
    {
        private MockRepository mockRepository;

        private Mock<IArzTiVerwaltungService> mockArzTiVerwaltungService;
        private ArzTiVerwaltungServiceFake arzTiVerwaltungServiceFake;

        public ApothekeApiImplTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockArzTiVerwaltungService = this.mockRepository.Create<IArzTiVerwaltungService>();

            this.arzTiVerwaltungServiceFake = new ArzTiVerwaltungServiceFake();
        }

        private ApothekeApiImpl CreateApothekeApiImpl()
        {
            return new ApothekeApiImpl(
                this.mockArzTiVerwaltungService.Object);
        }

        [Fact(Skip = "not implemented")]
        public async Task GetApothekeByIK_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var apothekeApiImpl = this.CreateApothekeApiImpl();
            string apoik = "123";
            mockArzTiVerwaltungService.Setup(x => x.GetApothekeByIKAsync(apoik)).Returns(arzTiVerwaltungServiceFake.GetApothekeByIKAsync(apoik));

            // Act
            var result = await apothekeApiImpl.GetApothekeByIK(
                apoik);

            // Assert
            //Assert.Equal("ik1", result.ExecuteResultAsync();
            this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "not implemented")]
        public async Task GetApothekenList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var apothekeApiImpl = this.CreateApothekeApiImpl();
            mockArzTiVerwaltungService.Setup(x => x.GetApothekenListAsync()).Returns(arzTiVerwaltungServiceFake.GetApothekenListAsync());

            // Act
            var result = await apothekeApiImpl.GetApothekenList();

            // Assert
            //Assert.Equal(3, result.ExecuteResultAsync().Count);
            this.mockRepository.VerifyAll();
        }
    }
}
