using System.Data;

public class GenerateReportCommand : IReportCommand
{
    private readonly DataTable data;
    private readonly IExportStrategy exportStrategy;
    private readonly IFilterStrategy filterStrategy;
    private readonly IVisualizationStrategy visualizationStrategy;
    private readonly DataObserver dataObserver;

    public GenerateReportCommand(
        DataTable data,
        IExportStrategy exportStrategy,
        IFilterStrategy filterStrategy,
        IVisualizationStrategy visualizationStrategy,
        DataObserver dataObserver)
    {
        this.data = data;
        this.exportStrategy = exportStrategy;
        this.filterStrategy = filterStrategy;
        this.visualizationStrategy = visualizationStrategy;
        this.dataObserver = dataObserver;
    }

    public void Execute()
    {
        // Apply filter strategy to data
        filterStrategy.ApplyFilter(data);

        // Notify data observer of changes
        dataObserver.OnDataChanged(data);

        // Visualize data using visualization strategy
        visualizationStrategy.Visualize(data);

        // Export data using export strategy
        exportStrategy.Export(data, "report");
    }
}