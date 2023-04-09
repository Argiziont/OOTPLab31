using System.Data;

public interface IExportStrategy
{
    void Export(DataTable data, string outputPath);
}