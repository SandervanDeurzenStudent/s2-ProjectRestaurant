using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DB : IDB1
    {
        public string ReturnConnectionString()
        {
            return "server=localhost;Uid=root;database=testwithtemplatesdb";
        }
    }
}
