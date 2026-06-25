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
            var item = new DatabaseListItem("DbName", 1);
            Assert.That(item.Name, Is.EqualTo("DbName"));
            Assert.That(item.ID, Is.EqualTo(1));
        }
    }
}
