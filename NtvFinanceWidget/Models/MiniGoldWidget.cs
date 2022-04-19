using System.Text.Json.Serialization;

namespace NtvFinanceWidget.Models;

public class MiniGoldWidget
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("kayitTarihi")]
    public DateTime KayitTarihi { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = null!;

    [JsonPropertyName("tag")]
    public string Tag { get; set; } = null!;

    [JsonPropertyName("openValue")]
    public string OpenValue { get; set; } = null!;

    [JsonPropertyName("currentValue")]
    public string CurrentValue { get; set; } = null!;

    [JsonPropertyName("highValue")]
    public string HighValue { get; set; } = null!;

    [JsonPropertyName("lowValue")]
    public string LowValue { get; set; } = null!;

    [JsonPropertyName("diffDayNom")]
    public string DiffDayNom { get; set; } = null!;

    [JsonPropertyName("diffDayPer")]
    public string DiffDayPer { get; set; } = null!;

    [JsonPropertyName("average")]
    public string Average { get; set; } = null!;

    [JsonPropertyName("volume")]
    public string Volume { get; set; } = null!;

    [JsonPropertyName("dailyChangePercentageShort")]
    public string DailyChangePercentageShort { get; set; } = null!;

    [JsonPropertyName("upDownStatus")]
    public int UpDownStatus { get; set; }
}