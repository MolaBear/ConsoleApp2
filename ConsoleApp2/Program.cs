using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question1();
            Question2();
            Question3();
            Question4();
            Question5();



        }


        static void Question1()
        {
            string z;
            z = Console.ReadLine();
            char[] array1 = z.ToArray();

            Array.Reverse(array1);

            string reverseArray = new string(array1);

            Console.WriteLine("input: " + z);
            Console.WriteLine("Output: " + reverseArray);
        }
        static void Question2()
        {
            // Question 2
            string userInput;
            userInput = Console.ReadLine();

            char[] array1 = userInput.ToCharArray();

            Array.Reverse(array1);

            string reverseArray = new string(array1);

            if (userInput.Equals(reverseArray))
            {

                Console.WriteLine("input: " + userInput);
                Console.WriteLine("output: " + reverseArray + " this is a palindrome");
            }
            else
            {
                Console.WriteLine(userInput + " is not equal to " + reverseArray + " this is NOT a palindrome");
            }

        }
        static void Question3()
        {

            //question 3
            string z;

            z = Console.ReadLine();

            List<string> listWords = new List<string>();

            string output = "";

            string[] words = z.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                output += words[i] + " ";
            }

            listWords.Add(output);

            foreach (string reversewords in listWords)
            {

                Console.WriteLine("\nReverse output: " + reversewords);
            }
        }

        static void Question4()
        {
            //question 4
            string z;

            z = Console.ReadLine();

            List<string> listWords = new List<string>();

            string output = "";

            string[] words = z.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                output += words[i] + " ";
            }

            listWords.Add(output);

            foreach (string reversewords in listWords)
            {
                char[] array1 = reversewords.ToArray();

                Array.Reverse(array1);

                string reverseArray = new string(array1);

                Console.WriteLine("input: " + reversewords);
                Console.WriteLine("Output: " + reverseArray);

            }
        }
        static void Question5()
        {
            //question 5
            string z = Console.ReadLine();

            string message = z;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in message.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }
            Console.ReadKey();
        }




    }
}


