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
        public string Target { get; set; }

        public Folder(string fullPath)
        {
            FullPath = fullPath;            
            var groups = fullPath.Split(new Char[] {'\\'});  
            Target = groups.Length == 1 ? groups[0] : String.Join(@"\",groups.Skip(1).Take(groups.Length - 2));
            DisplayName = FullPath;
            ID = CurrentIndex++;
        }
    }
}
