using NUnit.Framework;
using System;
using System.IO;
using System.Xml;
using PE_Tools;

namespace PE_Tools.Tests
{
    [TestFixture]
    public class FileManagerTests
    {
        [Test]
        public void Constructor_ThrowsOnNullPrefix()
        {
            Assert.Throws<ArgumentNullException>(() => new FileManager(null));
        }

        [Test]
        public void Constructor_ThrowsOnEmptyPrefix()
        {
            Assert.Throws<ArgumentException>(() => new FileManager("   "));
        }
        // More tests for FileManager would require mocking file system and config
    }
}
