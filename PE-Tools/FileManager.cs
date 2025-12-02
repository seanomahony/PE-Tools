using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PE_Tools
{
    public class FileManager
    {
        public XmlDocument c1Config { get; set; }
        public XmlDocument docConfig { get; set; }

        string c1Path { get; set; }
        string docPath { get; set; }

        string c1ConfigFilename;
        string docConfigFilename;

        public FileManager(string prefix)
        {
            c1ConfigFilename = ConfigurationManager.AppSettings["c1ConfigFilename"];
            if (string.IsNullOrEmpty(c1ConfigFilename))
            {
                throw new ConfigurationErrorsException("C1 config filename not found in app settings.");
            }
            
            docConfigFilename = ConfigurationManager.AppSettings["docConfigFilename"];
            if (string.IsNullOrEmpty(docConfigFilename))
            {
                throw new ConfigurationErrorsException("Doc config filename not found in app settings.");
            }
            
            c1Path = prefix + c1ConfigFilename;
            if (!File.Exists(c1Path))
            {
                throw new FileNotFoundException($"C1 configuration file not found: {c1Path}");
            }
            
            c1Config = new XmlDocument();
            c1Config.Load(c1Path);

            docPath = prefix + docConfigFilename;
            if (!File.Exists(docPath))
            {
                throw new FileNotFoundException($"Doc configuration file not found: {docPath}");
            }
            
            docConfig = new XmlDocument();
            docConfig.Load(docPath);
        }

        public void UpdateC1File(string database)
        {
            var node = c1Config.SelectSingleNode("//connectionStrings/add/@connectionString");
            if (node == null)
            {
                throw new InvalidOperationException("Connection string not found in C1 configuration file.");
            }
            
            var connStr = node.Value;
            var parts = connStr.Split(';');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Trim().StartsWith("Database="))
                {
                    parts[i] = "Database=" + database;
                    break;
                }
            }
            node.Value = string.Join(";", parts);
        }
        public bool SaveC1File()
        {
            try
            {
                c1Config.Save(c1Path);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }
        }

        public void UpdateDocFile(string docsDb, string c1Db)
        {
            var c1ConfigKey = "cms.c1.database.connection";
            var searchTerm = "Database=";

            // Update cms.database.connection config setting
            var node = docConfig.SelectSingleNode("//appSettings/add[@key='cms.database.connection']/@value");
            if (node != null)
            {
                var connStr = node.Value;
                var parts = connStr.Split(';');
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Trim().StartsWith(searchTerm))
                    {
                        parts[i] = searchTerm + docsDb;
                        break;
                    }
                }
                node.Value = string.Join(";", parts);
            }

            // Update cms.c1.database.connection config setting if present
            node = docConfig.SelectSingleNode("//appSettings/add[@key='cms.c1.database.connection']/@value");
            if (node != null)
            {
                var connStr = node.Value;
                var parts = connStr.Split(';');
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Trim().StartsWith(searchTerm))
                    {
                        parts[i] = searchTerm + c1Db;
                        break;
                    }
                }
                node.Value = string.Join(";", parts);
            }
        }

        public bool SaveDocFile() 
        {
            try 
            { 
                docConfig.Save(docPath);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error" );
                return false;
            }
        }
    }
}
