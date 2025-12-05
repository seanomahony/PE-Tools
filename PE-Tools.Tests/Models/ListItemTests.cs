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
            ListItem.CurrentIndex = 0;
            var item = new ListItem("TestName");
            Assert.AreEqual("TestName", item.Name);
            Assert.AreEqual(0, item.ID);
        }
    }
}
