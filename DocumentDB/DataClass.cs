using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentDB
{
    public class DataClass
    {
        public string Name { get; set; }
        public Guid UniqueId { get; set; }
        public DateTime Date { get; set; }
        public int ObjectKey { get; set; }
    }
}
