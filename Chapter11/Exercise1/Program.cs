using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var ballsports = xdoc.Root.Elements()
                .Select(x => new {
                 Name = x.Element("name").Value,
                 Teammembers = x.Element("teammembers").Value,

                });
            foreach(var ballsport in ballsports) {
                Console.WriteLine("{0} {1}", ballsport.Name, ballsport.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var ballsports = xdoc.Root.Elements()               
                .Select(x => new {
                    Name = (string)x.Element("name").Attribute("kanji"),
                    Year = (int)x.Element("firstplayed"),

                })
                .OrderBy(x => ("firstplayed"));
            foreach (var ballsport in ballsports) {
                Console.WriteLine("{0} ({1})", ballsport.Name, ballsport.Year);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("sample.xml");
            
        }

        private static void Exercise1_4(string file, string newfile) {
            
        }
    }
}
