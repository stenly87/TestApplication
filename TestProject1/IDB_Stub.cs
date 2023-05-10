using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication;

namespace TestProject1
{
    internal class IDB_Stub<T> : IDB<T>
    {
        public int Count()
        {
            return 0;
        }

        public void Insert(T value)
        {
          
        }

        public void Update(TestMe testMe)
        {
            
        }
    }
}
