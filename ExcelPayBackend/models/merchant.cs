using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExcelPayBackend.models
{
    public class merchant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PublicKey { get; set; }
        public string SecretKey { get; set; }
        public ICollection<Iframe> Iframes { get; set; }
        [JsonIgnore]
        public ICollection<Intention> Intentions { get; set; }

    }
}
