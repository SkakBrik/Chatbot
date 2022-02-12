using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities; 

namespace Database
{
    public class DB : IDatabase 
    {
        private Greetings _greetings;
        private Tools _tools; 
        public DB()
        {
            _greetings = new Greetings();
            _tools = new Tools();
        }

        public string GetGreetings()
        {
            return _greetings.GetGreetings();
        }

        public string GetGoodbye()
        {
            return _greetings.GetGoodbye(); 
        }

        public string GetAngryGoodbye()
        {
            return _greetings.GetAngryGoodbye();
        }

        public string GetTool(string tool)
        {
            if (tool.ToLower().Contains("hammer"))
            {
                return _tools.GetHammer(); 
            } else
            {
                return _tools.GetScrewdriver(); 
            }
        }
    }
}
