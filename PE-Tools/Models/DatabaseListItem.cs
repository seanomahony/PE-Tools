using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Tools.Models
{
    public class DatabaseListItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DatabaseListItem(string name, int index)
        {
            ID = index;
            Name = name;
        }
    }
}
