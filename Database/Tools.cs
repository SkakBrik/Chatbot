using Entities.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Database
{
    public class Tools
    {
        public string GetHammer()
        {
            Tool hammer = new Tool("Hammer", "Bewhaos.co.uk/hammer", 4.95);
            return JsonConvert.SerializeObject(hammer); 
        }
        public string GetScrewdriver()
        {
            Tool hammer = new Tool("Screwdriver", "Bewhaos.co.uk/screwdriver", 3.95);
            return JsonConvert.SerializeObject(hammer);
        }
    }
}
