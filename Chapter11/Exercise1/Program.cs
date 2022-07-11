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
            //Exercise1_4(file, newfile);

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
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
                    Name = x.Element("name").Attribute("kanji").Value,
                    Firstplayed = x.Element("firstplayed").Value,

                })
                .OrderBy(x => int.Parse(x.Firstplayed));
            foreach (var ballsport in ballsports) {
                Console.WriteLine("{0} ({1})", ballsport.Name, ballsport.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var ballsport = xdoc.Root.Elements()
                .Select(x => new {
                    Name = x.Element("name").Value,
                    Teammembers = x.Element("teammembers").Value,

                }).OrderByDescending(x => int.Parse(x.Teammembers)).First();           
                Console.WriteLine("{0} {1}", ballsport.Name, ballsport.Teammembers);
        }

        private static void Exercise1_4(string file, string newfile) {

            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsport",
                             new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                             new XElement("teammembers", "11"),
                             new XElement("firstplayed", "1863"));
            xdoc.Root.Add(element);
            xdoc.Save("sports.xml");
        }
    }
}
