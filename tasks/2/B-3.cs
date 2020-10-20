using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LB_4.tasks._2
{
    class B_3 : B
    {
        public B_3() : base("B_3") { }
        public override void Info()
        {
            Debug.WriteLine("This is class B_3");
        }
    }
}
