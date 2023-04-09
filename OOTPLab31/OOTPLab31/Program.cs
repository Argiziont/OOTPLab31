// Define the strategy interface for exporting data

using System.Data;


DataTable data = new DataTable();

DateTime startDate = DateTime.Now;

DateTime endDate = DateTime.Now.AddDays(5);

DataObserver dataObserver = new DataObserver();

ReportGenerator reportGenerator = new ReportGenerator(data, dataObserver);

CsvExportStrategy exportStrategy = new CsvExportStrategy();
DateRangeFilterStrategy filterStrategy = new DateRangeFilterStrategy(startDate, endDate);
BarChartVisualizationStrategy visualizationStrategy = new BarChartVisualizationStrategy();

reportGenerator.GenerateReport(exportStrategy, filterStrategy, visualizationStrategy);