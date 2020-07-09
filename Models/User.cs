using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public string Login { get; set; }
        [JsonPropertyName("html_url")]
        public string Url { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("public_repos")]
        public int PublicRepos { get; set; }

        public int Followers { get; set; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        public override string ToString()
        {
            return $"Login {Login} Url {Url} Name {Name} PubRepo {PublicRepos}";
        }
    }
}
