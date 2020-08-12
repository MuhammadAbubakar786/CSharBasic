using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    class Variables
    {
        //**Thee Types of Variable**
        // 1=> static variable ()
        // 2=> readonly variable (runtime const)
        // 3=> const variable (compiletime const )

        public static int Kilo { get; set;}
        public const float PI = 3.14f;
        public readonly string Name = "Ali";
    }
}
