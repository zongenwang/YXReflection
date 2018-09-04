using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YX.DB.Interface;

namespace YX.DB.SqlServer
{
    public class SqlServerHelper : IDBHelper
    {
        public SqlServerHelper()
        {
            Console.WriteLine("{0}被构造",this.GetType().Name);
        }

        public void Query()
        {
            Console.WriteLine("{0}.Query",this.GetType().Name);
        }
    }
}
