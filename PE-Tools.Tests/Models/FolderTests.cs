using NUnit.Framework;
using PE_Tools.Models;

namespace PE_Tools.Tests.Models
{
    [TestFixture]
    public class FolderTests
    {
        [Test]
        public void Constructor_SetsProperties()
        {
            var folder = new Folder(@"C:\Test\Repo\onPrem");
            Assert.AreEqual(folder.FullPath, @"C:\Test\Repo\onPrem");
            Assert.AreEqual(folder.Target, @"Test\Repo");
            Assert.AreEqual(folder.DisplayName, @"C:\Test\Repo\onPrem");
        }
    }
}
