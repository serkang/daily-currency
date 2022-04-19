using Currency.Helper.Models;
using NtvFinanceWidget.Models;

namespace Currency.Helper;

public static class ResponseConverter
{
    public static List<SummaryResponse> ConvertToSummary(this List<HeaderBarWidget> headerBarWidgets)
    {
        var result = new List<SummaryResponse>();

        foreach (var widget in headerBarWidgets)
        {
            if(widget.Title.StartsWith("BI") || widget.Title.Contains("ONS")) continue;
            if (widget.Title == "ALTIN(GRAM)") widget.Title = "Gram Altın";

            var item = new SummaryResponse
            {
                KayitTarihi = widget.KayitTarihi,
                Title = widget.Title,
                Tag = widget.Tag,
                CurrentValue = decimal.Round(decimal.Parse(widget.CurrentValue), 2),
                DailyChangePercentageShort = widget.DailyChangePercentageShort
            };

            result.Add(item);
        }

        return result;
    }
}
