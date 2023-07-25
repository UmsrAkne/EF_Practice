using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace EF_Practice.Models
{
    public class DatabaseContext : DbContext, IDataSource
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DbSet<Record> Records { get; set; }

        public IEnumerable<Record> GetDataSource => Records;

        public void Add(Record rec)
        {
            Records.Add(rec);
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!File.Exists("EFWTest.sqlite"))
            {
                SQLiteConnection.CreateFile("EFWTest.sqlite"); // ファイルが存在している場合は問答無用で上書き。
            }

            var connectionString = new SqliteConnectionStringBuilder { DataSource = @"EFWTest.sqlite", }.ToString();

            optionsBuilder.UseSqlite(new SQLiteConnection(connectionString));
        }
    }
}