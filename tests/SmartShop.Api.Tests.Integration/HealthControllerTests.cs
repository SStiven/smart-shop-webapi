using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

using Xunit;

namespace SmartShop.Api.Tests.Integration;

public class HealthControllerTests : IClassFixture<WebApplicationFactory<IApiMarker>>
{
    private readonly HttpClient _httpClient;

    public HealthControllerTests(WebApplicationFactory<IApiMarker> applicationFactory)
    {
        _httpClient = applicationFactory.CreateClient();
    }

    [Fact]
    public async Task Get_ReturnsOK()
    {
        var response = await _httpClient.GetAsync("/api/health");

        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}