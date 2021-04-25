using Xunit;
using ArzTiServer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArzTiServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArzTiServer.Controllers.Tests
{
    public class RezeptsControllerTests
    {
        RezeptsController _controller;
        ArzDBContext _service;

        public RezeptsControllerTests()
        {
            _service = new ArzContextFake();
            _controller = new RezeptsController(_service);

        }

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.GetRezepts();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult =(await _controller.GetRezepts()).Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Patient>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}