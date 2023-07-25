using System.Linq;

namespace EF_Practice.Models;

public class Selector
{
    public Selector(IDataSource source)
    {
        DataSource = source;
    }

    private IDataSource DataSource { get; set; }

    public Record GetRecordFromName(string name)
    {
        return DataSource.GetDataSource.FirstOrDefault(r => r.Name == name);
    }

    public void Add(Record rec)
    {
        DataSource.Add(rec);
    }
}