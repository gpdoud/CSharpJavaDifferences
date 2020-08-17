using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpJavaDifferences {

    // C# support unchecked exceptions only. Java supports checked and unchecked

    public class UncheckedExceptionsOnly {
        
        // Java requests this method be tagged with "throws Exception"

        public void WillThrowException() {
            throw new Exception("This exception is always thrown");
        }
    }
}
