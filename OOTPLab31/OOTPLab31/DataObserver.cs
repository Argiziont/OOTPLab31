using System.Data;

public class DataObserver : IDataObserver
{
    private readonly List<IDataObserver> observers;

    public DataObserver()
    {
        observers = new List<IDataObserver>();
    }

    public void AddObserver(IDataObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IDataObserver observer)
    {
        observers.Remove(observer);
    }

    public void OnDataChanged(DataTable data)
    {
        foreach (IDataObserver observer in observers) observer.OnDataChanged(data);
    }
}