using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Greetings
    {

        public string GetGreetings()
        {
            return "Hello and welcome to Bewhaos automatic Chatbot. \n My name is Charles. \n What can I help you with?";
        }

        public string GetGoodbye()
        {
            return "Bye bye, See you next time"; 
        }

        public string GetAngryGoodbye()
        {
            return "Bye bye! I'll see you soon, I promise"; 
        }
    }
}
