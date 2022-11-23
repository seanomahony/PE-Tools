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
        public string DisplayName { get; set; }
        public string FullPath { get; set; }

        public Folder(string fullPath)
        {
            var pattern = @"[^\\]+\\?$";
            FullPath = fullPath;
            DisplayName = Regex.Match(fullPath, pattern).Value;
        }
    }
}
