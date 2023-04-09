using System.Data;

public class CategoryFilterStrategy : IFilterStrategy
{
    private string category;

    public CategoryFilterStrategy(string category)
    {
        this.category = category;
    }

    public void ApplyFilter(DataTable data)
    {
        // Apply category filter to data
    }
}