using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IDatabase
    {
        string GetGreetings();
        string GetGoodbye();
        string GetAngryGoodbye();
        string GetTool(string tool);
    }
}
