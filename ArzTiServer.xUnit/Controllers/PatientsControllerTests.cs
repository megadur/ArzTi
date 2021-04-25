using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArzTiServer.DataAccess;
using Moq;
using ArzTiServer.Models;
using Microsoft.AspNetCore.Mvc;
using ArzTiServer.xUnit;

namespace ArzTiServer.Controllers.Tests
{
    public class PatientsControllerTests
    {
        PatientsController _controller;
        IHospitalAccessProvider _service;

        public PatientsControllerTests()
        {
            _service = new HospitalAccessProviderFake();
            _controller = new PatientsController(_service);

        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Patient>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact()]
        public void Index_ReturnsAViewResult_WithAListOfBrainstormSessions()
        {
            // Arrange
            var mockRepo = new Mock<IHospitalAccessProvider>();
            mockRepo.Setup(repo => repo.GetPatientRecords()).Returns(GetTestSessions());
            var controller = new PatientsController(mockRepo.Object);

            // Act
            var okResult = controller.Get().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Patient>>(okResult.Value);
            Assert.Equal(2, items.Count());
        }

        private List<Patient> GetTestSessions()
        {
            return _service.GetPatientRecords();
        }
    }
}