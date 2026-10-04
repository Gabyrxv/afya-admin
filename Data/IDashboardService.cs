namespace afya_admin.Data;

public interface IDashboardService
{
    Task<DashboardDataModel?> ObterDadosAsync();
}