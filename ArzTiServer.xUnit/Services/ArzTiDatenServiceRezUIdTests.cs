﻿using ArzTiServer.ArzTiService;
using ArzTiServer.Repositories;
using ArzTiServer.Services;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Services
{
    public class ArzTiDatenServiceRezUIdTests
    {
        private MockRepository mockRepository;

        private Mock<IDatenRepository> mockDatenRepository;

        public ArzTiDatenServiceRezUIdTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockDatenRepository = this.mockRepository.Create<IDatenRepository>();
        }

        private ArzTiDatenService CreateService()
        {
            return new ArzTiDatenService(
                this.mockDatenRepository.Object);
        }

        [Fact]
        public async Task DeleteRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ruid = null;

            // Act
            var result = await service.DeleteRezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ruid = null;

            // Act
            var result = await service.GetRezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchRezeptUIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();
            string ruid = null;
            RezeptStatus body = null;

            // Act
            var result = await service.PatchRezeptUIdStatusAsync(
                ruid,
                body);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

    }
}
