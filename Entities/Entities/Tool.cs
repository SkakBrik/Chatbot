using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Tool
    {
        public string tool { get; set; }
        public string url { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public Tool(string tool, string url, double price, int stock)
        {
            this.tool = tool;
            this.url = url;
            this.price = price;
            this.stock = stock;
        }
    }
}
