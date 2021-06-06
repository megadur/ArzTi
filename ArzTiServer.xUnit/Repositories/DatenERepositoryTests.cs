
using ArzTiServer.Domain.Model;
using ArzTiServer.Domain.Repositories;
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

        private Mock<ArzDbContext> mockArzDBContext;

        public DatenERepositoryTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Default);

            this.mockArzDBContext = this.mockRepository.Create<ArzDbContext>();
        }

        private DatenERepository CreateDatenERepository()
        {
            return new DatenERepository(
                this.mockArzDBContext.Object);
        }

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "Setup DbContext and DbSet mock  ")]
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
            bool? abgeholt = null;

            // Act
            var result = await datenERepository.GetERezeptIdListAsync(
                apoik,
                maxnum,
                zeitraum,
                abgeholt);

            // Assert
            Assert.Single(result);
            this.mockArzDBContext.Verify(f => f.ErSenderezepteErezepts, Times.Once);
            //this.mockRepository.VerifyAll();
        }

        [Fact(Skip = "Setup DbContext and DbSet mock  ")]
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
            string apoik = "1";
            string zeitraum = null;

            // Act
            var result = await datenERepository.xGetERezeptIdListByTransferAsync(
                apoik,
                zeitraum);

            // Assert
            Assert.Single(result);
            this.mockArzDBContext.Verify(f => f.ErSenderezepteErezepts, Times.Once);
            //this.mockRepository.VerifyAll();
        }


        [Fact]
        public async Task GetERezeptList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(DbSetMockFactory.getErSenderezepteErezept());
            var datenERepository = this.CreateDatenERepository();

            // Act
            var result = await datenERepository.GetERezeptList();

            // Assert
            Assert.Equal(4, result.Count);
            //this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetERezeptListOffen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(DbSetMockFactory.getErSenderezepteErezept());
            var datenERepository = this.CreateDatenERepository();
            string apoik = "1";
            int MaxNum = 10;

            // Act
            var result = await datenERepository.GetERezeptListOffen(
                apoik,
                MaxNum);

            // Assert
            Assert.Single(result);
            Assert.Equal("A1Id1", result.First().ErezeptId);
        }

        [Fact]
        public async Task GetERezeptIdListByStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(DbSetMockFactory.getErSenderezepteErezept());
            var datenERepository = this.CreateDatenERepository();
            string apoik = "1";
            string zeitraum = null;
            List<string> status = new List<string> { "Status1", };
            // Act
            var result = await datenERepository.GetERezeptIdListByStatusAsync(
                apoik,
                zeitraum,
                status);

            // Assert
            Assert.Single(result);
            Assert.Equal("Status1", result.First().ErSenderezepteErezeptStatuses.First().RezeptStatus);
            this.mockArzDBContext.Verify(f => f.ErSenderezepteErezepts, Times.Once);
        }

        [Fact(Skip = "not implemented")]
        public async Task GetERezeptIdListPruefResAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var datenERepository = this.CreateDatenERepository();
            string apoik = "1";
            string zeitraum = null;
            int MaxNum = 10;
            bool? abgeholt = null;

            // Act
            var result = await datenERepository.GetERezeptIdListAsync(
                apoik,
                MaxNum,
                zeitraum,
                abgeholt
                );

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task PutERezeptIdListPruefungAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mock = DbSetMockFactory.getErSenderezepteErezept();
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(mock);
            var datenERepository = this.CreateDatenERepository();
            string apoik = "3";
            List<string> rezeptlist = new List<string> { "A3Id1", };

            // Act
            var result = await datenERepository.PutERezeptIdListPruefungAsync(
                apoik,
                rezeptlist);

            // Assert
            Assert.True(result.GetValueOrDefault("A3Id1"));
            var x = mock.Where(x => x.ErezeptId == "A3Id1").FirstOrDefault();
            Assert.Equal("VOR_PRUEFUNG", x.ErSenderezepteErezeptStatuses.First().RezeptStatus);
        }

        [Fact(Skip = "not implemented")]
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
            var mock = DbSetMockFactory.getErSenderezepteErezeptStatus();
            mockArzDBContext.Setup(s => s.ErSenderezepteErezeptStatuses).Returns(mock);
            var datenERepository = this.CreateDatenERepository();
            int id = 0;
            string status = "VOR_PRUEFUNG";

            // Act
            var result = await datenERepository.PatchERezeptStatusAsync(
                id,
                status);

            // Assert
            var x = mock.Where(x => x.IdSenderezepteErezept == id).FirstOrDefault();
            Assert.Equal(status, x.RezeptStatus);
        }


        [Fact]
        public async Task PatchERezeptIdListStatusAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mock = DbSetMockFactory.getErSenderezepteErezept();
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(mock);
            var datenERepository = this.CreateDatenERepository();
            string apoik = "1";
            Dictionary<string, string> rezeptlist = new()
            {
                { "A1Id1", "value1" },
                { "A1Id2", "value2" }
            };
            // Act
            var result = await datenERepository.PatchERezeptIdListStatusAsync(
                apoik,
                rezeptlist);

            // Assert
            Assert.Equal(rezeptlist.GetValueOrDefault("A3Id1"), result.GetValueOrDefault("A3Id1"));
            Assert.Equal(rezeptlist.GetValueOrDefault("A3Id2"), result.GetValueOrDefault("A3Id2"));
            //this.mockArzDBContext.Verify(f => f.ErSenderezepteErezepts, Times.Once);
        }

        [Fact(Skip = "not implemented")]
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
            var mock = DbSetMockFactory.getErSenderezepteErezept();
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(mock);
            var datenERepository = this.CreateDatenERepository();
            string apoik = "1";
            List<string> rezeptlist = new List<string> { "A1Id1", };

            // Act
            var result = await datenERepository.PatchERezeptIdListAbholstatusAsync(
                apoik,
                rezeptlist);

            // Assert
            var x = mock.Where(x => x.ErezeptId == "A1Id1").FirstOrDefault();
            Assert.True(x.ErSenderezepteErezeptDatens.First().TransferArz);
        }

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "strange result")]
        public async Task DeleteERezeptIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mock = DbSetMockFactory.getErSenderezepteErezept();
            mockArzDBContext.Setup(s => s.ErSenderezepteErezepts).Returns(mock);
            var datenERepository = this.CreateDatenERepository();
            string apoik = "1";
            string rezid = "A1Id1";

            // Act
            var result = await datenERepository.DeleteERezeptIdAsync(
                apoik,
                rezid);

            // Assert
            var x = mock.Where(x => x.ErezeptId == "A1Id1").FirstOrDefault();
            Assert.Null(x);
        }

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "not implemented")]
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

        [Fact(Skip = "not implemented")]
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
