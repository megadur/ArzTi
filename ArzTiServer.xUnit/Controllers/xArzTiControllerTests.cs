using ArzTiServer.Models;
using ArzTiServer.Services;
using System.Collections.Generic;
using System.Linq;
using ArzTiServer.DataAccess;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using System.Threading.Tasks;
using ArzTiServer.ArzTiService;

namespace ArzTiServer.Controllers.Tests
{
    public class xArzTiControllerTests
    {
        ArzTiController _controller;
        IArzTiDatenService _arzTiDatenService;
        IArzTiVerwaltungService _arzTiVerwaltungService;

        public xArzTiControllerTests()
        {
            _arzTiDatenService= new ArzTiDatenServiceFake();
             _arzTiVerwaltungService= new ArzTiVerwaltungService();
            _controller = new ArzTiController(_arzTiDatenService, _arzTiVerwaltungService);

        }



        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetApothekenListAsync();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetApothekenListAsync().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Patient>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
        [Fact()]
        public async Task Index_ReturnsAViewResult_WithAListOfBrainstormSessions()
        {
            // Arrange
            var mockRepo = new Mock<IArzTiVerwaltungService>();
            mockRepo
                .Setup(repo => repo.GetApothekenListAsync())
                .Returns(GetTestSessions())
                ;
            var controller = new ArzTiController(null, mockRepo.Object);

            // Act
            var okResult = (await controller.GetApothekenListAsync());

            // Assert
            var items = Assert.IsType<List<Patient>>(okResult);
            Assert.Equal(2, items.Count());
        }
        /*
        */
        private Task<ICollection<Apotheke>> GetTestSessions()
        {
            return _arzTiVerwaltungService.GetApothekenListAsync ();
            //return new ICollection<Apotheke>();
        }
    }
}