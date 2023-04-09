using System.Data;

public interface IDataObserver
{
    void OnDataChanged(DataTable data);
}