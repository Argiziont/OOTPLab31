using System.Data;

public interface IVisualizationStrategy
{
    void Visualize(DataTable data);
}