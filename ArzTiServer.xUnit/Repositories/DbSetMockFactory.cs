using ArzTiServer.Domain.Model;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArzTiServer.xUnit.Repositories
{
    class DbSetMockFactory
    {
        public static DbSet<ErSenderezepteErezeptStatus> getErSenderezepteErezeptStatus()
        {
            var data = FakeData.getErSenderezepteErezeptStatus();
            var mock = data.AsQueryable().BuildMockDbSet();
            mock.Setup(set => set.AddAsync(It.IsAny<ErSenderezepteErezeptStatus>(), It.IsAny<CancellationToken>()))
              .Callback((ErSenderezepteErezeptStatus entity, CancellationToken _) => data.Add(entity));
            return mock.Object;
        }
        public static DbSet<ErSenderezepteErezept> getErSenderezepteErezept()
        {
            var data = FakeData.getErSenderezepteErezept();

            var mock = data.AsQueryable().BuildMockDbSet();
            mock.Setup(set => set.AddAsync(It.IsAny<ErSenderezepteErezept>(), It.IsAny<CancellationToken>()))
              .Callback((ErSenderezepteErezept entity, CancellationToken _) => data.Add(entity));
            return mock.Object;

        }
    }
}
