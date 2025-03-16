using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models.CoinDesk;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinDeskController(
    ILogger<CoinDeskController> logger,
    IHttpClientFactory httpClientFactory
) : ControllerBase
{
    private readonly ILogger<CoinDeskController> _logger = logger;

    private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

    private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

    [HttpGet(Name = "LatestTick")]
    public async Task<ActionResult<CoinDeskResponse>> Get()
    {
        HttpRequestMessage httpRequestMessage = new(
            HttpMethod.Get,
            "https://data-api.coindesk.com/index/cc/v1/latest/tick?instruments=BTC-USD,ETH-USD&apply_mapping=true&market=cadli");

        HttpClient httpClient = _httpClientFactory.CreateClient();
        HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            Stream contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
            try
            {
                CoinDeskResponse? response = JsonSerializer.Deserialize<CoinDeskResponse>(contentStream, _jsonSerializerOptions);
                return Ok(response);
            }
            catch (JsonException jsonEx)
            {
                _logger.LogError(jsonEx, "Error deserializing CoinDesk API response.");
                return BadRequest("Error deserializing CoinDesk API response.");
            }
        }
        return BadRequest("Failed to fetch data from CoinDesk API.");
    }
}
