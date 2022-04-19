using System.Text.Json.Serialization;

namespace NtvFinanceWidget.Models;

//public class BistLowWidget
//{
//    [JsonPropertyName("id")]
//    public int Id { get; set; }

//    [JsonPropertyName("symbol")]
//    public string Symbol { get; set; }

//    [JsonPropertyName("name")]
//    public string Name { get; set; }

//    [JsonPropertyName("diffDayPer")]
//    public string DiffDayPer { get; set; }

//    [JsonPropertyName("lastPrice")]
//    public string LastPrice { get; set; }

//    [JsonPropertyName("diffLastPrice")]
//    public string DiffLastPrice { get; set; }

//    [JsonPropertyName("firstPrice")]
//    public string FirstPrice { get; set; }

//    [JsonPropertyName("highPrice")]
//    public string HighPrice { get; set; }

//    [JsonPropertyName("lowPrice")]
//    public string LowPrice { get; set; }

//    [JsonPropertyName("upDownStatus")]
//    public int UpDownStatus { get; set; }

//    [JsonPropertyName("updateDateTime")]
//    public DateTime UpdateDateTime { get; set; }
//}

//public class BistHightWidget
//{
//    [JsonPropertyName("id")]
//    public int Id { get; set; }

//    [JsonPropertyName("symbol")]
//    public string Symbol { get; set; }

//    [JsonPropertyName("name")]
//    public string Name { get; set; }

//    [JsonPropertyName("diffDayPer")]
//    public string DiffDayPer { get; set; }

//    [JsonPropertyName("lastPrice")]
//    public string LastPrice { get; set; }

//    [JsonPropertyName("diffLastPrice")]
//    public string DiffLastPrice { get; set; }

//    [JsonPropertyName("firstPrice")]
//    public string FirstPrice { get; set; }

//    [JsonPropertyName("highPrice")]
//    public string HighPrice { get; set; }

//    [JsonPropertyName("lowPrice")]
//    public string LowPrice { get; set; }

//    [JsonPropertyName("upDownStatus")]
//    public int UpDownStatus { get; set; }

//    [JsonPropertyName("updateDateTime")]
//    public DateTime UpdateDateTime { get; set; }
//}

public class WidgetResponse
{
    [JsonPropertyName("headerBarWidget")]
    public List<HeaderBarWidget> HeaderBarWidget { get; set; } = null!;

    [JsonPropertyName("miniExhangeWidget")]
    public List<MiniExchangeWidget> MiniExchangeWidget { get; set; } = null!;

    [JsonPropertyName("miniGoldWidget")]
    public List<MiniGoldWidget> MiniGoldWidget { get; set; } = null!;

    //[JsonPropertyName("bistLowWidget")]
    //public List<BistLowWidget> BistLowWidget { get; set; } = null!;

    //[JsonPropertyName("bistHightWidget")]
    //public List<BistHightWidget> BistHightWidget { get; set; } = null!;

    //[JsonPropertyName("allGoldWidget")]
    //public object AllGoldWidget { get; set; }

    //[JsonPropertyName("exchangesWidget")]
    //public object ExchangesWidget { get; set; }

    //[JsonPropertyName("exchangesPariteWidget")]
    //public object ExchangesPariteWidget { get; set; }

    //[JsonPropertyName("allKriptoWidget")]
    //public object AllKriptoWidget { get; set; }

    //[JsonPropertyName("allBistWidget")]
    //public object AllBistWidget { get; set; }

    //[JsonPropertyName("top3GoldWidget")]
    //public object Top3GoldWidget { get; set; }

    //[JsonPropertyName("top3ExchangeWidget")]
    //public object Top3ExchangeWidget { get; set; }

    //[JsonPropertyName("bistWidget")]
    //public object BistWidget { get; set; }

    //[JsonPropertyName("categoryInfo")]
    //public object CategoryInfo { get; set; }
}



