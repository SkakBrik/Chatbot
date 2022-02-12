using Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Chatbot.Controllers
{

    [RoutePrefix("api/tools")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ToolsController : ApiController
    {
        IDatabase db;
        public ToolsController()
        {
            db = new DB();
        }

        [Route("{tool}")]
        [HttpGet]
        public string GetTool(string tool)
        {
            return db.GetTool(tool);
        }
    }
}
