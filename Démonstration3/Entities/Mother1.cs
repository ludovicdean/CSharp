using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démonstration3.Entities
{
    public abstract class Mother1
    {
        public abstract void DoSmt1();

        public int DoSmt2()
        {
            return 2;
        }

        public void DoSmt3()
        {
            Console.WriteLine("DoSmt3 - Mother1");
        }

        public virtual void DoSmt4()
        {
            Console.WriteLine("DoSmt4 - Mother1");
        }
    }
}
