using System.Data;

public interface IFilterStrategy
{
    void ApplyFilter(DataTable data);
}