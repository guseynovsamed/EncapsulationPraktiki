using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Book : BaseEntity
    {
        public string Name { get; set; }
        public bool name { get; internal set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
    }
}
