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
            Assert.That(folder.FullPath, Is.EqualTo(@"C:\Test\Repo\onPrem"));
            Assert.That(folder.Target, Is.EqualTo(@"Test\Repo"));
            Assert.That(folder.DisplayName, Is.EqualTo(@"C:\Test\Repo\onPrem"));
        }
    }
}
