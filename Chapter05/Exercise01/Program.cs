using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("文字列１を入力");
            var inputstring1 = Console.ReadLine();
            Console.WriteLine("文字列２を入力");
            var inputstring2 = Console.ReadLine();

            if (String.Compare(inputstring1, inputstring2,ignoreCase: true) == 0) {
                Console.WriteLine("等しい");
            }else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
