using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpJavaDifferences {
    
    public class Pointers {

        // C# pointers are variable that hold an address; they are dangerous

        public static void Run() {

            unsafe {

                int i = 5;
                int* ip = &i;

                Console.WriteLine($"i is {i} and *ip is {*ip}");

                *ip = 7;

                Console.WriteLine($"i is {i} and ip is {*ip}");
            }
        }
    }
}
