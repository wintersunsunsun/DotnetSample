namespace TodoApi.Models.CoinDesk;

public class CoinDeskResponse
{
    public Dictionary<string, CoinDeskResponseData> Data { get; set; } = [];
    public CoinDeskResponseErr Err { get; set; } = new CoinDeskResponseErr();
}

public class CoinDeskResponseData
{
    public decimal VALUE { get; set; }
    public string VALUE_FLAG { get; set; } = string.Empty;
}

public class CoinDeskResponseErr
{
    public int? Type { get; set; } = null!;
    public string Message { get; set; } = null!;
}