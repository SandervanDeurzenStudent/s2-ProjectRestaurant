using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    class Dependecy
    {
        private IDB1 idb;

        public Dependecy(IDB1 _IDBP)
        {
            this.idb = _IDBP;
            this.idb.ReturnConnectionString();
        }
    }
}
