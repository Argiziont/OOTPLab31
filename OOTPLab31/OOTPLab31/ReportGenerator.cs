using System.Data;

public class ReportGenerator
{
    private readonly DataTable data;
    private readonly DataObserver dataObserver;

    public ReportGenerator(DataTable data, DataObserver dataObserver)
    {
        this.data = data;
        this.dataObserver = dataObserver;
    }

    public void GenerateReport(
        IExportStrategy exportStrategy,
        IFilterStrategy filterStrategy,
        IVisualizationStrategy visualizationStrategy)
    {
        GenerateReportCommand command = new GenerateReportCommand(
            data,
            exportStrategy,
            filterStrategy,
            visualizationStrategy,
            dataObserver);

        // Execute the command
        command.Execute();
    }
}