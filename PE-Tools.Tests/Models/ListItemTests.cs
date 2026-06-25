using NUnit.Framework;
using PE_Tools.Models;

namespace PE_Tools.Tests.Models
{
    [TestFixture]
    public class ListItemTests
    {
        [Test]
        public void Constructor_SetsNameAndId()
        {
            var item = new ListItem("TestName", 0);
            Assert.That(item.Name, Is.EqualTo("TestName"));
            Assert.That(item.ID, Is.EqualTo(0));
        }
    }
}
