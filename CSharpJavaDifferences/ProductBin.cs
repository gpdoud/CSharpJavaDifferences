using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpJavaDifferences {

    // C# allows operators to be overloaded

    public class ProductBin {

        public string Contents  { get; set; }
        public int Count { get; set; }

        public static ProductBin operator +(ProductBin pb1, ProductBin pb2) {
            if(pb1.Contents != pb2.Contents) {
                Console.WriteLine("ERROR: Cannot mix bins of different contents");
                return null;
            }
            var newPb = new ProductBin { Contents = pb1.Contents, Count = pb1.Count + pb2.Count };
            Console.WriteLine("SUCCESS: Consolidated bin created");
            return newPb;
        }
    }
}
