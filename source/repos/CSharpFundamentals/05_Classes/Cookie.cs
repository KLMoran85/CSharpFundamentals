using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public Cookie(String name, string ingredient, string size, string direction, string shape, int batchSize)
        {
            Name = size;
            Ingredient = ingredient;
            Size = name;
            Direction = direction;
            Shape = shape;
            BatchSize = batchSize;
        }
        public Cookie()
        {

        }
        
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string Size { get; set; }
        public string Direction { get; set; }
        public string Shape { get; set; }
        public int BatchSize { get; set; }
        
    }
}
