using ArzTiServer.Models;
using ArzTiServer.Repositories;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;


namespace ArzTiServer.xUnit.Repositories
{
    public class DatenRepositoryTests
    {
        private MockRepository mockRepository;

        private Mock<ArzDBContext> mockArzDBContext;

        public DatenRepositoryTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Default );

            this.mockArzDBContext = this.mockRepository.Create<ArzDBContext>();
        }

        private DatenRepository CreateDatenRepository()
        {
            return new DatenRepository(
                this.mockArzDBContext.Object);
        }



        [Fact]
        public void GetMRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();

            // Act
            var result = datenRepository.GetMRezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetOffeneMRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = datenRepository.GetMRezeptListOffen(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }


        [Fact]
        public void GetPRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();

            // Act
            var result = datenRepository.GetPRezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetOffenePRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = datenRepository.GetPRezeptListOffen(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }


        [Fact]
        public async void GetERezeptList_StateUnderTest_ExpectedBehavior()
        {
            //arrange
            //var userEntities = new List<ErSenderezepteErezept>();
            var data = new List<ErSenderezepteErezept>
                            {
                                new ErSenderezepteErezept { ErezeptId =  "BBB", ApoIkNr= 1L} ,
                                new ErSenderezepteErezept { ErezeptId = "ZZZ", ApoIkNr= 2L },
                                new ErSenderezepteErezept { ErezeptId = "AAA", ApoIkNr= 3L },
                            };

            var mock = data.AsQueryable().BuildMockDbSet();
            mock.Setup(set => set.AddAsync(It.IsAny<ErSenderezepteErezept>(), It.IsAny<CancellationToken>()))
              .Callback((ErSenderezepteErezept entity, CancellationToken _) => data.Add(entity));

            var setup1 = mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(mock.Object);

            var datenRepository = this.CreateDatenRepository();

            // Act
            var result = await datenRepository.GetERezeptList();

            // Assert
            Assert.Equal(3, result.Count);
            this.mockArzDBContext.Verify(f => f.ErSenderezepteErezepts, Times.Once);

        }

        [Fact]
        public void GetOffeneERezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = datenRepository.GetERezeptListOffen(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListByStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            string zeitraum = null;
            var mockSet = new Mock<DbSet<ErSenderezepteErezept>>();
            
            mockArzDBContext.Setup(x => x.ErSenderezepteErezepts).Returns(mockSet.Object);
            // Act
            var result = await datenRepository.GetERezeptIdListByStatusAsync(
                apoik,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListByTransferAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ErSenderezepteErezept b = new ErSenderezepteErezept() { ErezeptId = "BBB" };
            var data = new List<ErSenderezepteErezept>
                            {
                                new ErSenderezepteErezept { ErezeptId =  "BBB", ApoIkNr= 1L} ,
                                new ErSenderezepteErezept { ErezeptId = "ZZZ", ApoIkNr= 2L },
                                new ErSenderezepteErezept { ErezeptId = "AAA", ApoIkNr= 3L },
                            }.AsQueryable();
            //Setup DbContext and DbSet mock  
            var dbSetMock = new Mock<DbSet<ErSenderezepteErezept>>();
            dbSetMock.As<IQueryable<ErSenderezepteErezept>>().Setup(m => m.Provider).Returns(data.Provider);
            dbSetMock.As<IQueryable<ErSenderezepteErezept>>().Setup(m => m.Expression).Returns(data.Expression);
            dbSetMock.As<IQueryable<ErSenderezepteErezept>>().Setup(m => m.ElementType).Returns(data.ElementType);
            dbSetMock.As<IQueryable<ErSenderezepteErezept>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            //dbSetMock.SetupGet(s => s.FindAsync(It.IsAny<Guid>())).Returns(ValueTask.FromResult(new ErSenderezepteErezept()));
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(dbSetMock.Object);
            var datenRepository = this.CreateDatenRepository();
            string apoik = "1";
            string zeitraum = "";
            
            // Act
            var result = await datenRepository.GetERezeptIdListByTransferAsync(
                apoik,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }


        [Fact]
        public async Task GetRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            //Setup DbContext and DbSet mock  
            var dbSetMock = new Mock<DbSet<ErSenderezepteErezept>>();
            dbSetMock.Setup(s => s.FindAsync(It.IsAny<Guid>())).Returns(ValueTask.FromResult(new ErSenderezepteErezept()));
            mockArzDBContext.Setup(s => s.Set<ErSenderezepteErezept>()).Returns(dbSetMock.Object);
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            string rezid = null;

            // Act
            var result = await datenRepository.GetERezeptIdAsync(
                apoik,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetRezeptIdListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            int? maxnum = null;
            string zeitraum = null;

            // Act
            var result = await datenRepository.GetERezeptIdListAsync(
                apoik,
                maxnum,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteRezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string apoik = null;
            string rezid = null;

            // Act
            var result = await datenRepository.DeleteERezeptIdAsync(
                apoik,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteRezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenRepository = this.CreateDatenRepository();
            string ruid = null;

            // Act
            var result = await datenRepository.DeleteERezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }


    }
}
