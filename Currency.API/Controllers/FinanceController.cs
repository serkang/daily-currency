using Currency.Helper;
using Microsoft.AspNetCore.Mvc;
using NtvFinanceWidget.Abstract;

namespace Currency.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceController : ControllerBase
{
    private readonly INtvFinanceWidgetService _ntvFinance;

    public FinanceController(INtvFinanceWidgetService ntvFinance)
    {
        _ntvFinance = ntvFinance;
    }

    [HttpGet]
    [Route("latest")]
    [ResponseCache(Duration = 300)]
    public async Task<IActionResult> GetLastFinanceData()
    {
        var result = await _ntvFinance.GetWidgetAsync();
        return Ok(result);
    }

    [HttpGet]
    [Route("latest/summary")]
#if !DEBUG
    [ResponseCache(Duration = 300)]
#endif
    public async Task<IActionResult> GetLastFinanceDataSummary()
    {
        var result = await _ntvFinance.GetWidgetAsync();
        return Ok(result?.HeaderBarWidget.ConvertToSummary());
    }
}
