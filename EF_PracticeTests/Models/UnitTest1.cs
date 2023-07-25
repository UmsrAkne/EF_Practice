using EF_Practice.Models;

namespace EF_PracticeTests.Models
{
    public class SelectorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var datasource = new DatabaseMock();
            datasource.Add(new Record { Id = 0, Name = "aaa", });
            datasource.Add(new Record { Id = 1, Name = "bbb", });
            datasource.Add(new Record { Id = 2, Name = "ccc", });

            var selector = new Selector(datasource);
            var r = selector.GetRecordFromName("aaa");

            Assert.Multiple(() =>
            {
                Assert.That(r.Name, Is.EqualTo("aaa"));
                Assert.That(r.Id, Is.EqualTo(0));
            });
        }
    }
}