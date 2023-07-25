namespace EF_Practice.Models;

public class Selector
{
    public Selector(IDataSource source)
    {
        DataSource = source;
    }

    private IDataSource DataSource { get; set; }
}