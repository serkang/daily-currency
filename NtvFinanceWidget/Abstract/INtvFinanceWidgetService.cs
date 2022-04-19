using NtvFinanceWidget.Models;

namespace NtvFinanceWidget.Abstract
{
    public interface INtvFinanceWidgetService
    {
        Task<WidgetResponse?> GetWidgetAsync();
    }
}
