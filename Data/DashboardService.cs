using System.Net.Http.Json;

namespace afya_admin.Data;

public class DashboardService : IDashboardService
{
    private readonly HttpClient _http;

    public DashboardService(HttpClient http)
    {
        _http = http;
    }

    public async Task<DashboardDataModel?> ObterDadosAsync()
    {
        return await _http.GetFromJsonAsync<DashboardDataModel>(
            "data/dashboard.json");
    }
}