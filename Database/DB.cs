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
        public DB()
        {
            _greetings = new Greetings();
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
    }
}
