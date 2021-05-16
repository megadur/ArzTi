using ArzTiServer.Models;
using ArzTiServer.Repositories;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiServer.xUnit.Repositories
{
    public class DatenERepositoryTests
    {
        private MockRepository mockRepository;

        private Mock<ArzDBContext> mockArzDBContext;

        public DatenERepositoryTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Default);

            this.mockArzDBContext = this.mockRepository.Create<ArzDBContext>();
        }

        private DatenERepository CreateDatenERepository()
        {
            return new DatenERepository(
                this.mockArzDBContext.Object);
        }

        [Fact]
        public async Task GetERezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            string rezid = null;

            // Act
            var result = await datenERepository.GetERezeptIdAsync(
                apoik,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string ruid = null;

            // Act
            var result = await datenERepository.GetERezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            string rezid = null;

            // Act
            var result = await datenERepository.GetERezeptIdStatusAsync(
                apoik,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptIdListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string apoik = "1";
            int? maxnum = null;
            string zeitraum = null;
            var datens = new List<ErSenderezepteErezeptDaten>
            {
                new ErSenderezepteErezeptDaten{ RezeptUuid ="UUID1", TransferArz =false, XmlRequest="XML1"}
            };
            var statuses = new List<ErSenderezepteErezeptStatus>
            {
                new ErSenderezepteErezeptStatus{ ErezeptId ="Id1", RezeptStatus="Status1"}
            };
            var data = new List<ErSenderezepteErezept>
                            {
                                new ErSenderezepteErezept { ErezeptId =  "BBB", ApoIkNr= 1L, ErSenderezepteErezeptDatens=datens , ErSenderezepteErezeptStatuses=statuses  } ,
                                new ErSenderezepteErezept { ErezeptId = "ZZZ", ApoIkNr= 2L, ErSenderezepteErezeptDatens=datens , ErSenderezepteErezeptStatuses=statuses  },
                                new ErSenderezepteErezept { ErezeptId = "AAA", ApoIkNr= 3L, ErSenderezepteErezeptDatens=datens , ErSenderezepteErezeptStatuses=statuses  },
                            };

            var mock = data.AsQueryable().BuildMockDbSet();
            mock.Setup(set => set.AddAsync(It.IsAny<ErSenderezepteErezept>(), It.IsAny<CancellationToken>()))
              .Callback((ErSenderezepteErezept entity, CancellationToken _) => data.Add(entity));

            var setup1 = mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(mock.Object);

            var datenERepository = this.CreateDatenERepository();

            // Act
            var result = await datenERepository.GetERezeptIdListAsync(
                apoik,
                maxnum,
                zeitraum);

            // Assert
            Assert.Single(result);
            this.mockArzDBContext.Verify(f => f.ErSenderezepteErezepts, Times.Once);
            //this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptIdListByTransferAsync_StateUnderTest_ExpectedBehavior()
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
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            string zeitraum = null;

            // Act
            var result = await datenERepository.GetERezeptIdListByTransferAsync(
                apoik,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptIdStatusListAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            string zeitraum = null;

            // Act
            var result = await datenERepository.GetERezeptIdStatusListAsync(
                apoik,
                zeitraum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();

            // Act
            var result = await datenERepository.GetERezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptListOffen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = await datenERepository.GetERezeptListOffen(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptIdListByStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            string zeitraum = null;
            List<string> status = null;

            // Act
            var result = await datenERepository.GetERezeptIdListByStatusAsync(
                apoik,
                zeitraum,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptIdListPruefResAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            string zeitraum = null;
            List<string> status = null;

            // Act
            var result = await datenERepository.GetERezeptIdListPruefResAsync(
                apoik,
                zeitraum,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutERezeptIdListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            List<string> rezeptlist = null;

            // Act
            var result = await datenERepository.PutERezeptIdListPruefungAsync(
                apoik,
                rezeptlist);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutERezeptUidListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            List<string> rezeptlist = null;

            // Act
            var result = await datenERepository.PutERezeptUidListPruefungAsync(
                rezeptlist);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchERezeptIdStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            int id = 0;
            string status = null;

            // Act
            var result = await datenERepository.PatchERezeptStatusAsync(
                id,
                status);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }


        [Fact]
        public async Task PatchERezeptIdListStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            Dictionary<string, string> rezeptlist=null;
            // Act
            var result = await datenERepository.PatchERezeptIdListStatusAsync(
                apoik,
                rezeptlist);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchERezeptUIdListStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            Dictionary<string, string> rezeptlist = null;

            // Act
            var result = await datenERepository.PatchERezeptUIdListStatusAsync(
                rezeptlist);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchERezeptIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            List<string> rezeptlist = null;

            // Act
            var result = await datenERepository.PatchERezeptIdListAbholstatusAsync(
                apoik,
                rezeptlist);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PatchERezeptUIdListAbholstatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            List<string> rezeptlist = null;

            // Act
            var result = await datenERepository.PatchERezeptUIdListAbholstatusAsync(
                rezeptlist);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteERezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = null;
            string rezid = null;

            // Act
            var result = await datenERepository.DeleteERezeptIdAsync(
                apoik,
                rezid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task DeleteERezeptUIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string ruid = null;

            // Act
            var result = await datenERepository.DeleteERezeptUIdAsync(
                ruid);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetMRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();

            // Act
            var result = await datenERepository.GetMRezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetMRezeptListOffen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = await datenERepository.GetMRezeptListOffen(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetPRezeptListOffen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            String apoik = null;
            int MaxNum = 0;

            // Act
            var result = await datenERepository.GetPRezeptListOffen(
                apoik,
                MaxNum);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetPRezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();

            // Act
            var result = await datenERepository.GetPRezeptList();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
