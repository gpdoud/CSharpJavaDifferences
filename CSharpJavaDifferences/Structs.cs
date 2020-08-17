using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpJavaDifferences {

    public static class Structs {

        // No structs in Java
        // No default constructor declaration (already provided)
        // value type
        // Cannot inherit, but can implement interfaces

        public struct AStruct {
            public int Id;
            public string Name;
            public bool Active;
        }

        public static AStruct CreateInstance() {
            AStruct astruct;
            astruct.Id = 1;
            astruct.Name = "A Struct";
            astruct.Active = true;
            return astruct;
        }

    }
}
