using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public float price { get; set; }

        [JsonPropertyName("img")]
        public string img { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
