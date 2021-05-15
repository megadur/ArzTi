using ArzTiClient.OpenAPIService;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Xunit;

namespace ArzTiClient.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task should_be_able_to_get_forecast_for_week()
        {
            //Arrange
            using var applicationFactory = new WebApplicationFactory<ArzTiClient.Program>();
            var httpClient = applicationFactory.CreateClient();
            var client = new Client(httpClient);

            //Act
            var result = await client.ApothekeGetAsync ();

            //Assert
            Assert.Equal(7, result?.Count);
        }
    }
}
