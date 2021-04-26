using ArzTiServer.Models;
using ArzTiServer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace ArzTiServer.Tests
{
    [TestClass]
    public class UnitTest_Blog
    {
        [TestClass]
        public class NonQueryTests
        {
            [TestMethod]
            public void CreateBlog_saves_a_blog_via_context()
            {
                var mockSet = new Mock<DbSet<BloggingDbContext>>();

                var mockContext = new Mock<BloggingDbContext>();
                mockContext.Setup(m => m.Blogs).Returns(mockSet.Object);

                var service = new BlogService(mockContext.Object);
                service.AddBlog("ADO.NET Blog", "http://blogs.msdn.com/adonet");

                mockSet.Verify(m => m.Add(It.IsAny<BloggingDbContext>()), Times.Once());
                mockContext.Verify(m => m.SaveChanges(), Times.Once());
            }
            [TestMethod]
            public void GetAllBlogs_orders_by_name()
            {
                var data = new List<BloggingDbContext>
        {
            new BloggingDbContext { Name = "BBB" },
            new BloggingDbContext { Name = "ZZZ" },
            new BloggingDbContext { Name = "AAA" },
        }.AsQueryable();

                var mockSet = new Mock<DbSet<BloggingDbContext>>();
                mockSet.As<IQueryable<BloggingDbContext>>().Setup(m => m.Provider).Returns(data.Provider);
                mockSet.As<IQueryable<BloggingDbContext>>().Setup(m => m.Expression).Returns(data.Expression);
                mockSet.As<IQueryable<BloggingDbContext>>().Setup(m => m.ElementType).Returns(data.ElementType);
                mockSet.As<IQueryable<BloggingDbContext>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

                var mockContext = new Mock<BloggingDbContext>();
                mockContext.Setup(c => c.Blogs).Returns(mockSet.Object);

                var service = new BlogService(mockContext.Object);
                var blogs = service.GetAllBlogs();

                Assert.AreEqual(3, blogs.Count);
                Assert.AreEqual("AAA", blogs[0].Name);
                Assert.AreEqual("BBB", blogs[1].Name);
                Assert.AreEqual("ZZZ", blogs[2].Name);
            }
        }

    }
}
