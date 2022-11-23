using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_Tools
{
    public class FileManager
    {
        public List<string> c1Config { get; set; }
        public List<string> docConfig { get; set; }

        string c1Path { get; set; }
        string docPath { get; set; }

        const string c1ConfigFilename = @"\integration\bin\Debug\Config\Database.config";
        const string docConfigFilename = @"\integration\bin\Debug\Server\bin\CMSService.exe.config";

        public FileManager(string prefix)
        {
            c1Path = prefix + c1ConfigFilename;
            c1Config = File.ReadAllLines(c1Path).ToList();

            docPath = prefix + docConfigFilename;
            docConfig = File.ReadAllLines(docPath).ToList();
        }

        public void UpdateC1File(string database)
        {
            var databaseLineIndex = 2;
            var line = c1Config[databaseLineIndex];
            var head = line.Substring(0, line.IndexOf("Initial Catalog="));
            var tail = line.Substring(line.IndexOf("Initial Catalog="));
            var startOfEnd = tail.IndexOf(';');
            var end = tail.Substring(startOfEnd);
            var newLine = head + "Initial Catalog=" + database + end;
            c1Config[databaseLineIndex] = newLine;
        }
        public bool SaveC1File()
        {
            try
            {
                File.WriteAllLines(c1Path, c1Config);
            }
            catch (Exception e){
                MessageBox.Show(e.Message, "Error");
            }
            return true;
        }

        public void UpdateDocFile(string database)
        {
            var databaseLineIndex = 37;
            var line = docConfig[databaseLineIndex];
            var head = line.Substring(0, line.IndexOf("Initial Catalog="));
            var tail = line.Substring(line.IndexOf("Initial Catalog="));
            var startOfEnd = tail.IndexOf(';');
            var end = tail.Substring(startOfEnd);
            var newLine = head + "Initial Catalog=" + database + end;
            docConfig[databaseLineIndex] = newLine;
        }

        public bool SaveDocFile()
        {
            try 
            { 
            File.WriteAllLines(docPath, docConfig);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error" );
            }
            return true;
        }
    }
}
