using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PE_Tools.Models
{
    public class Folder
    {
        private static int CurrentIndex = 0;
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public string FullPath { get; set; }

        public Folder(string fullPath)
        {
            //var pattern = @"[^\\]+\\?$";
            FullPath = fullPath;
            DisplayName = fullPath;// Regex.Match(fullPath, pattern).Value;
            ID = CurrentIndex++;


        }
    }
}
