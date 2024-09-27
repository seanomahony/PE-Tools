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
            var searchTerm = "Initial Catalog=";
            var line = c1Config.FirstOrDefault(l => l.Length > searchTerm.Length && l.Contains(searchTerm));
            var databaseLineIndex = c1Config.IndexOf(line);
            var head = line.Substring(0, line.IndexOf(searchTerm));
            var tail = line.Substring(line.IndexOf(searchTerm));
            var end = tail.Substring(tail.IndexOf(';'));
            var newLine = head + searchTerm + database + end;
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

        public void UpdateDocFile(string docsDb, string c1Db)
        {
            var c1ConfigKey = "cms.c1.database.connection";
            var searchTerm = "Initial Catalog=";

            // Update cms.database.connection config setting
            var line = docConfig.FirstOrDefault(l => l.Length > searchTerm.Length && l.Contains(searchTerm) && !l.Contains(c1ConfigKey));
            var databaseLineIndex = docConfig.IndexOf(line);
            var head = line.Substring(0, line.IndexOf(searchTerm));
            var tail = line.Substring(line.IndexOf(searchTerm));
            var end = tail.Substring(tail.IndexOf(';'));
            var newLine = head + searchTerm + docsDb + end;
            docConfig[databaseLineIndex] = newLine;

            // Update cms.database.connection config setting if present
            line = docConfig.FirstOrDefault(l => l.Length > searchTerm.Length && l.Contains(searchTerm) && l.Contains(c1ConfigKey));
            if (line != null)
            {
                databaseLineIndex = docConfig.IndexOf(line);
                head = line.Substring(0, line.IndexOf(searchTerm));
                tail = line.Substring(line.IndexOf(searchTerm));
                end = tail.Substring(tail.IndexOf(';'));
                newLine = head + searchTerm + c1Db + end;
                docConfig[databaseLineIndex] = newLine;
            }
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
