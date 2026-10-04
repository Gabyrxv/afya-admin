namespace afya_admin.Data;

public class DashboardDataModel
{
    public List<KpiData> Kpis { get; set; } = new();
    public string[] Periodos { get; set; } = Array.Empty<string>();
    public string[] Meses { get; set; } = Array.Empty<string>();
    public double[] ReceitaMensal { get; set; } = Array.Empty<double>();
    public double[] MetaMensal { get; set; } = Array.Empty<double>();
    public int TotalClientes { get; set; }
}

public class KpiData
{
    public string Titulo { get; set; } = "";
    public string Valor { get; set; } = "";
    public string Variacao { get; set; } = "";
    public bool Positivo { get; set; }
    public string Icone { get; set; } = "";
    public string Cor { get; set; } = "";
    public string CorHex { get; set; } = "";
    public double[] Tendencia { get; set; } = Array.Empty<double>();
}