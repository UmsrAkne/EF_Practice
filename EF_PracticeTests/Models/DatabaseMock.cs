using EF_Practice.Models;

namespace EF_PracticeTests.Models
{
    public class DatabaseMock : IDataSource
    {
        private List<Record> Records { get; } = new ();

        public IEnumerable<Record> GetDataSource => Records;

        public void Add(Record rec)
        {
            Records.Add(rec);
        }
    }
}