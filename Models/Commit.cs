using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Commit
    {
        public Commiter Commiter { get; set; }
        public string Message { get; set; }
    }
}
