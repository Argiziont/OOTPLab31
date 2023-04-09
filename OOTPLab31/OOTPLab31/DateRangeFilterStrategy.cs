using System.Data;

public class DateRangeFilterStrategy : IFilterStrategy
{
    private DateTime startDate;
    private DateTime endDate;

    public DateRangeFilterStrategy(DateTime startDate, DateTime endDate)
    {
        this.startDate = startDate;
        this.endDate = endDate;
    }

    public void ApplyFilter(DataTable data)
    {
        // Apply date range filter to data
    }
}