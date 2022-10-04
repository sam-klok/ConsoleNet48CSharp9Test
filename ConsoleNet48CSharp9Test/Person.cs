using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNet48CSharp9Test
{
    // record type exists in c# 9
    public record Person(string FirstName, string LastName)
    {
        //Person(string FirstName, string LastName);
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}
