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
    public class BlogServiceTest
    {
        [TestClass]
        public class NonQueryTests
        {
            [TestMethod]
            public void CreateBlog_saves_a_blog_via_context()
            {
                var mockSet = new Mock<DbSet<Blog>>();

                var mockContext = new Mock<BloggingDbContext>();
                mockContext.Setup(m => m.Blogs).Returns(mockSet.Object);

                var service = new BlogService(mockContext.Object);
                service.AddBlog("ADO.NET Blog", "http://blogs.msdn.com/adonet");

                mockSet.Verify(m => m.Add(It.IsAny<Blog>()), Times.Once());
                mockContext.Verify(m => m.SaveChanges(), Times.Once());
            }
            [TestMethod]
            public void GetAllBlogs_orders_by_name()
            {
                Blog b = new Blog() { Name = "BBB" };
                var data = new List<Blog>
                            {
                                new Blog {  Name = "BBB" } ,
                                new Blog { Name = "ZZZ" },
                                new Blog{ Name = "AAA" },
                            }.AsQueryable();

                var mockSet = new Mock<DbSet<Blog>>();
                mockSet.As<IQueryable<Blog>>().Setup(m => m.Provider).Returns(data.Provider);
                mockSet.As<IQueryable<Blog>>().Setup(m => m.Expression).Returns(data.Expression);
                mockSet.As<IQueryable<Blog>>().Setup(m => m.ElementType).Returns(data.ElementType);
                mockSet.As<IQueryable<Blog>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

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
