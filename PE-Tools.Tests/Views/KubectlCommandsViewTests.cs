using NUnit.Framework;
using PE_Tools.Views;
using System;
using System.IO;

namespace PE_Tools.Tests.Views
{
    [TestFixture]
    public class KubectlCommandsViewTests
    {
        [Test]
        public void GenerateCommand_CopyTo_Simple()
        {
            var result = KubectlCommandsView.GenerateCommandText("my-ns", "my-pod", "", "Copy To", "file.txt", "/tmp/dest");
            var expected = "kubectl cp file.txt my-ns/my-pod:/tmp/dest";
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCommand_CopyTo_WithContainer()
        {
            var result = KubectlCommandsView.GenerateCommandText("my-ns", "my-pod", "my-container", "Copy To", "file.txt", "/tmp/dest");
            var expected = "kubectl cp file.txt my-ns/my-pod:/tmp/dest -c my-container";
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCommand_CopyTo_DefaultNamespace()
        {
            // If ns is empty, it uses pod directly
            var result = KubectlCommandsView.GenerateCommandText("", "my-pod", "", "Copy To", "file.txt", "/tmp/dest");
            var expected = "kubectl cp file.txt my-pod:/tmp/dest";
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCommand_CopyFrom_Simple()
        {
            var result = KubectlCommandsView.GenerateCommandText("my-ns", "my-pod", "", "Copy From", "/tmp/src", "local.txt");
            var expected = "kubectl cp my-ns/my-pod:/tmp/src local.txt";
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCommand_MissingPod_ReturnsError()
        {
            var result = KubectlCommandsView.GenerateCommandText("my-ns", "", "", "Copy To", "src", "dest");
            Assert.That(result, Is.EqualTo("Pod name required."));
        }

        [Test]
        public void GenerateCommand_NoAction_ReturnsError()
        {
             var result = KubectlCommandsView.GenerateCommandText("my-ns", "pod", "", null, "src", "dest");
             Assert.That(result, Is.EqualTo("Select an action."));
        }

        [Test]
        public void GenerateCommand_CopyTo_AbsoluteSource()
        {
            // We need a path that is considered rooted.
            // On Windows: C:\test.txt
            // On Linux: /test.txt
            
            string src;
            string expectedCd;
            string expectedSrc;
            
            if (Path.DirectorySeparatorChar == '\\') // Windows
            {
                src = @"C:\temp\file.txt";
                expectedCd = "cd C:\\temp" + Environment.NewLine;
            }
            else // Unix/Mac
            {
                src = "/tmp/file.txt";
                expectedCd = "cd /tmp" + Environment.NewLine;
            }
            expectedSrc = "./file.txt";

            var result = KubectlCommandsView.GenerateCommandText("ns", "pod", "", "Copy To", src, "dest");
            
            var expected = $"{expectedCd}kubectl cp {expectedSrc} ns/pod:dest";
            
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCommand_CopyFrom_AbsoluteDest()
        {
             string dest;
            string expectedCd;
            string expectedDest;
            
            if (Path.DirectorySeparatorChar == '\\') // Windows
            {
                dest = @"C:\temp\file.txt";
                expectedCd = "cd C:\\temp" + Environment.NewLine;
            }
            else // Unix/Mac
            {
                dest = "/tmp/file.txt";
                expectedCd = "cd /tmp" + Environment.NewLine;
            }
            expectedDest = "./file.txt";

            var result = KubectlCommandsView.GenerateCommandText("ns", "pod", "", "Copy From", "src", dest);
            
            var expected = $"{expectedCd}kubectl cp ns/pod:src {expectedDest}";
            
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCommand_CopyTo_AbsoluteSource_WithSpaces()
        {
            if (Path.DirectorySeparatorChar != '\\') 
            {
                Assert.Ignore("This test is for Windows paths with spaces");
                return;
            }
            
            var src = @"C:\Program Files\file.txt";
            var expectedCd = "cd \"C:\\Program Files\"" + Environment.NewLine;
            var expectedSrc = "./file.txt";
            
            var result = KubectlCommandsView.GenerateCommandText("ns", "pod", "", "Copy To", src, "dest");
            var expected = $"{expectedCd}kubectl cp {expectedSrc} ns/pod:dest";
            
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCommand_SpacesInPaths_AddsQuotes()
        {
            var result = KubectlCommandsView.GenerateCommandText("ns", "pod", "", "Copy To", "file name.txt", "dest path");
            // src: "file name.txt" (quoted)
            // dest: "dest path"
            // podDest: "ns/pod:dest path" (quoted)
            
            var expected = "kubectl cp \"file name.txt\" \"ns/pod:dest path\"";
            
            Assert.That(result, Is.EqualTo(expected));
        }
        
        [Test]
        public void SanitizePath_RemovesQuotesAndInvalidChars()
        {
            var input = "\"path/to/file\"";
            var result = KubectlCommandsView.SanitizePath(input);
            Assert.That(result, Is.EqualTo("path/to/file"));
        }
    }
}
