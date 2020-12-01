using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using System.IO;

namespace Practice.service
{
    public class JsonFileProduct
    {
        public JsonFileProduct(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
