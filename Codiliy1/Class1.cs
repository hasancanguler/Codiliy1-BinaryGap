using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codiliy1
{
    public class A
    {
        public static void B()
        {
            A a = new A();
            a.C();
        }
        public void C()
        {
            B();
            string text1 = "aa";
            string text2 = "ab";
            if (text1 == text2)
            {

            }
        }
    }

  


}
