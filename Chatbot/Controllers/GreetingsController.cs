using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;
using Database; 

namespace Chatbot.Controllers
{
    [RoutePrefix("api/greetings")]
    public class GreetingsController : ApiController
    {
        IDatabase db; 
        public GreetingsController()
        {
            db = new DB();
        }

        [Route("hello")]
        [HttpGet]
        public string GetGreeting()
        {
            return db.GetGreetings();
        }

        [Route("goodbye")]
        [HttpGet] 
        public string GetGoodbye()
        {
            return db.GetGoodbye();
        }

    }
}
