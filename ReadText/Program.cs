using System;
using System.IO;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadFiles();

        }
        static void GenerateDocuments()
        {

        }
        static void ReadFiles()
        {
            var document1 = File.ReadAllText(@"G:\dokumentytxt\doc1.txt");
            var document2 = File.ReadAllLines(@"G:\dokumentytxt\doc2.txt");

            Console.WriteLine("Document1");
            Console.WriteLine(document1);
            Console.WriteLine("Document2");
            Console.WriteLine(string.Join(@"\r\n", document2));
            Console.WriteLine("Document2");
            Console.WriteLine(string.Join(Environment.NewLine, document2));
        }
    }
}
