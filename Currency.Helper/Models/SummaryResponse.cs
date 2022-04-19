using System.Text.Json.Serialization;

namespace Currency.Helper.Models;
public class SummaryResponse
{
    [JsonPropertyName("kayitTarihi")]
    public DateTime KayitTarihi { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("tag")]
    public string Tag { get; set; } = null!;

    [JsonPropertyName("currentValue")]
    public decimal CurrentValue { get; set; }

    [JsonPropertyName("dailyChangePercentageShort")]
    public string DailyChangePercentageShort { get; set; } = null!;
}
