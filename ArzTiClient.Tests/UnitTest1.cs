using IO.Swagger.Api;
using IO.Swagger.Client;
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
            var configuration = new Configuration();
            var apothekeApi = new ApothekeApi(configuration);

            //Act
            var result = await apothekeApi.GetApothekenListAsync();

            //Assert
            Assert.Equal(7, result?.Count);
        }
    }
}
