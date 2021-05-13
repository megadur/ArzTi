using ArzTiServer.Controllers;
using ArzTiServer.OpenAPIService;
using ArzTiServer.Services;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Controllers
{
    public class ArzTiControllerTests
    {
        private MockRepository mockRepository;

        private Mock<IArzTiDatenService> mockArzTiDatenService;
        private Mock<IArzTiVerwaltungService> mockArzTiVerwaltungService;

        private VerwaltungRepositoryFake verwaltungRepositoryFake;
        private ArzTiVerwaltungServiceFake arzTiVerwaltungServiceFake;

        public ArzTiControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockArzTiDatenService = this.mockRepository.Create<IArzTiDatenService>();
            this.mockArzTiVerwaltungService = this.mockRepository.Create<IArzTiVerwaltungService>();
            this.verwaltungRepositoryFake = new VerwaltungRepositoryFake();
            this.arzTiVerwaltungServiceFake = new ArzTiVerwaltungServiceFake();
        }

        private ArzTiController CreateArzTiController()
        {
            return new ArzTiController(
                this.mockArzTiDatenService.Object,
                this.mockArzTiVerwaltungService.Object);
        }

        [Fact]
        public async Task GetApothekeByIKAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = "123";
            mockArzTiVerwaltungService.Setup(x => x.GetApothekeByIKAsync(apoik)).Returns(arzTiVerwaltungServiceFake.GetApothekeByIKAsync(apoik));

            // Act
            var result = await arzTiController.GetApothekeByIKAsync(
                apoik);

            // Assert
            Assert.Equal("ik1", result.Ik);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetApothekenListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            mockArzTiVerwaltungService.Setup(x => x.GetApothekenListAsync()).Returns(arzTiVerwaltungServiceFake.GetApothekenListAsync());

            // Act
            var result = await arzTiController.GetApothekenListAsync();

            // Assert
            Assert.Equal(3, result.Count);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp reztyp = default(global::ArzTiServer.OpenAPIService.RezeptTyp);
            string rezid = null;

            // Act
            var result = await arzTiController.GetRezeptIdAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string ruid = null;

            // Act
            var result = await arzTiController.GetRezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp reztyp = default(global::ArzTiServer.OpenAPIService.RezeptTyp);
            string rezid = null;

            // Act
            var result = await arzTiController.GetRezeptIdStatusAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptUIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string ruid = null;

            // Act
            var result = await arzTiController.GetRezeptUIdStatusAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp? reztyp = null;
            int? maxnum = null;
            string zeitraum = null;
            List<string> status = null;

            // Act
            var result = await arzTiController.GetRezeptIdListAsync(
                apoik,
                reztyp,
                maxnum,
                zeitraum,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp? reztyp = null;
            string zeitraum = null;

            // Act
            var result = await arzTiController.GetRezeptIdListAbholstatusAsync(
                apoik,
                reztyp,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdStatusListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp? reztyp = null;
            string zeitraum = null;

            // Act
            var result = await arzTiController.GetRezeptIdStatusListAsync(
                apoik,
                reztyp,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListPruefResAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp? reztyp = null;
            string zeitraum = null;
            List<string> status = null;

            // Act
            var result = await arzTiController.GetRezeptIdListPruefResAsync(
                apoik,
                reztyp,
                zeitraum,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutRezeptIdListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            List<RezeptId> body = null;

            // Act
            await arzTiController.PutRezeptIdListPruefungAsync(
                apoik,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutRezeptUidListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            List<RezeptUId> body = null;

            // Act
            await arzTiController.PutRezeptUidListPruefungAsync(
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp reztyp = default(global::ArzTiServer.OpenAPIService.RezeptTyp);
            string rezid = null;
            String status = null;

            // Act
            var result = await arzTiController.PatchRezeptIdStatusAsync(
                apoik,
                reztyp,
                rezid,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptUIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string ruid = null;
            string status = null;

            // Act
            var result = await arzTiController.PatchRezeptUIdStatusAsync(
                ruid,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptIdListStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            List<RezeptStatus> body = null;

            // Act
            var result = await arzTiController.PatchRezeptIdListStatusAsync(
                apoik,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptUIdListStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            List<RezeptStatus> body = null;

            // Act
            var result = await arzTiController.PatchRezeptUIdListStatusAsync(
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            List<RezeptId> body = null;

            // Act
            var result = await arzTiController.PatchRezeptIdListAbholstatusAsync(
                apoik,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptUIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            List<RezeptUId> body = null;

            // Act
            var result = await arzTiController.PatchRezeptUIdListAbholstatusAsync(
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string apoik = null;
            RezeptTyp reztyp = default(global::ArzTiServer.OpenAPIService.RezeptTyp);
            string rezid = null;

            // Act
            var result = await arzTiController.DeleteRezeptIdAsync(
                apoik,
                reztyp,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var arzTiController = this.CreateArzTiController();
            string ruid = null;

            // Act
            var result = await arzTiController.DeleteRezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
