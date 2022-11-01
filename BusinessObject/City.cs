using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessObject
{
    public static class City
    {
        public static string[]? Get()
        {
            var data = File.ReadAllText(@"cities.json");
            return JsonSerializer.Deserialize<string[]>(data);
        }
    }
}
