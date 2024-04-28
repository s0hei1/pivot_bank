using Microsoft.AspNetCore.Mvc;
using Presentation.Controllers;
using FluentAssertions;

namespace UnitTests.Presentation.Controller;

public class CandlesTest
{
    [Fact]
    public async Task GetCandlesTestStatusCode200()
    {
        //Arrange
        var controller = new CandlesController();

        //Act
        var result = (OkObjectResult)await controller.GetCandles();
        
        //Assert
        result.StatusCode.Should().Be(200);
    }
}