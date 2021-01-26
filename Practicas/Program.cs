using System;
using System.Linq;
using System.Diagnostics;

namespace vscode
{


    class Program
    {

        static int Sumar (int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            return result;

        }

        static int CountWords(string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }

        static void Main(string[] args)
        {
            /*int a = 20;
            int b = 50;
            int result = Multiply(a, b);
            Console.WriteLine(result);
            if (result %2 == 0){
                Console.WriteLine("The number is even");
            }else{
                Console.WriteLine("The number is uneven");
            }*/
            Console.WriteLine("Enter a sentence");
            string sentence;
            sentence = Console.ReadLine();
            Console.WriteLine(sentence);
            int wordCount = CountWords(sentence);
            Console.WriteLine("There are" + wordCount + " in that sentence");
            Console.WriteLine("probando");
            Console.ReadKey();

            /*var processList = Process.GetProcesses();
            var process = processList.Where(p=> p.ProcessName == "dotnet").First();
            Console.WriteLine("Processing your feelings is " + process.PriorityClass);*/

        }
    }
}
