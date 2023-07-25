using System.Collections.Generic;

namespace EF_Practice.Models
{
    public interface IDataSource
    {
        public IEnumerable<Record> GetDataSource { get; }

        void Add(Record rec);
    }
}