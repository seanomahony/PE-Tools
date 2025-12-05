using NUnit.Framework;
using PE_Tools.Models;

namespace PE_Tools.Tests.Models
{
    [TestFixture]
    public class DatabaseListItemTests
    {
        [Test]
        public void Constructor_SetsNameAndId()
        {
            DatabaseListItem.CurrentIndex = 0;
            var item = new DatabaseListItem("DbName");
            Assert.Equals("DbName", item.Name);
            Assert.Equals(0, item.ID);
        }
    }
}
