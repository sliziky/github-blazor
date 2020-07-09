using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Repo
    {
        public string Name { get; set; }
        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int Forks { get; set; }
        [JsonPropertyName("Commits")]
      
        public string CommitsUrl { get; set; }
    }
}
