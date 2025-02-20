using FluentAssertions;
using Infrastructure.Web.Api.Common.Clients;
using Xunit;

namespace Infrastructure.Web.Api.Common.UnitTests.Clients;

[Trait("Category", "Unit")]
public class HttpResponseExtensionsSpec
{
    [Fact]
    public void WhenGetOrCreateRequestIdAndNoHeaders_ThenGeneratesValue()
    {
        var message = new HttpResponseMessage();

        var result = message.GetOrCreateRequestId();

        result.Should().NotBeEmpty();
    }

    [Fact]
    public void WhenGetOrCreateRequestIdAndRequestIdHeaderWithEmptyValue_ThenGeneratesValue()
    {
        var message = new HttpResponseMessage
        {
            Headers = { { HttpHeaders.RequestId, new List<string?>() } }
        };

        var result = message.GetOrCreateRequestId();

        result.Should().NotBeEmpty();
    }

    [Fact]
    public void WhenGetOrCreateRequestIdAndRequestIdHeaderWithMultipleValues_ThenReturnsHeaderFirstValue()
    {
        var message = new HttpResponseMessage
        {
            Headers = { { HttpHeaders.RequestId, new List<string?> { "arequestid1", "arequestid2" } } }
        };

        var result = message.GetOrCreateRequestId();

        result.Should().Be("arequestid1");
    }
}