using System.Text.Json;
using NtvFinanceWidget.Abstract;
using NtvFinanceWidget.Enums;
using NtvFinanceWidget.Models;

namespace NtvFinanceWidget;
public class NtvFinanceWidgetService : INtvFinanceWidgetService
{
    public async Task<WidgetResponse?> GetWidgetAsync()
    {
        const string ntvUrl = "https://www.ntv.com.tr";
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
        client.DefaultRequestHeaders.Add("Accept-Language","tr,en;q=0.9,en-GB;q=0.8,en-US;q=0.7");
        client.DefaultRequestHeaders.Add("Connection","keep-alive");
        client.DefaultRequestHeaders.Add("Origin", ntvUrl);
        client.DefaultRequestHeaders.Add("Referrer", ntvUrl);
        client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
        client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
        client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-site");
        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.75 Safari/537.36 Edg/100.0.1185.39");
        client.DefaultRequestHeaders.Add("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"100\", \"Microsoft Edge\";v=\"100\"");
        client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
        client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");

        using var responseMessage = await client.GetAsync(Urls.GenericWidgetUrl);
        responseMessage.EnsureSuccessStatusCode();
        await using var response = await responseMessage.Content.ReadAsStreamAsync();
        
        var result = await JsonSerializer.DeserializeAsync<WidgetResponse>(response);
        return result;
    }
}

