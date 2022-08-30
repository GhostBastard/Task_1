using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        public class StringLengthComparer : IComparer<string>
            {
                public int Compare(string x, string y)
                {
                    if (x.Length > y.Length)
                        return 1;
                    else if (x.Length == y.Length)
                        return 0;
                    else
                        return -1;
                }
        }
        static void Main(string[] args)
        {

                string text = "The “C# Professional” course includes the topics I discuss in my CLR via C# book and "
                + "teaches how the CLR works thereby showing you how to develop applications and "
                + "reusable components for the .NET Framework.";

                string[] arr = text.Split(' ');
                Array.Sort(arr, new StringLengthComparer());

                List<string> listOfWords = new List<string>();
                int amountOfLetters = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    while (i < arr.Length && arr[i].Length == amountOfLetters)
                    {
                        if (!listOfWords.Contains(arr[i]))
                            listOfWords.Add(arr[i]);
                        i++;
                    }

                    if (listOfWords.Any())
                        Console.WriteLine($"Words of length: {amountOfLetters}, Count:{listOfWords.Count}");
                    foreach (var item in listOfWords)
                        Console.WriteLine(item);

                    listOfWords.Clear();
                    amountOfLetters++;
                    i--;
                }



                Console.ReadKey();



        }
    }
}
