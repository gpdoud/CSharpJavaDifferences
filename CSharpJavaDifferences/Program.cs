using System;

namespace CSharpJavaDifferences {
    class Program {
        static void Main(string[] args) {
            Pointers.Run();
        }
        static void OperatorOverloading() {
            ProductBin pbWidgets1 = new ProductBin { Contents = "Widgets", Count = 5 };
            ProductBin pbWidgets2 = new ProductBin { Contents = "Widgets", Count = 6 };
            ProductBin pbSpecialWidgets = new ProductBin { Contents = "SpecialWidgets", Count = 3 };
            var pbFail = pbSpecialWidgets + pbWidgets1;
            var pbSuccess = pbWidgets1 + pbWidgets2;
        }
    }
}
