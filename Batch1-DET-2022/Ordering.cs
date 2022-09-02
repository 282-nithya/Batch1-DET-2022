using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Ordering
    {
        public static void Main()
        {
            //Sample_OrderBy_Lambda_Numbers();
            //Sample_OrderByDescending_Lambda();
            //Sample_Reverse_Lambda();
            //Sample_ThenBy_Lambda();
            //Sample_ThenByDescending_Lambda();

            //skip

            //Sample_Skip_Lambda();
            //Sample_SkipWhile_Lambda();
            //Sample_Take_Lambda();
            //Sample_TakeWhile_Lambda();


            //aggregation
            //Sample_Aggregate_Lambda_Simple();
            //Sample_Average_Lambda();
            //Sample_Count_Lambda();
            //Sample_Max_Lambda();
            //Sample_Min_Lamda();
            //Sample_Sum_Lamda();

            ////set
            //Sample_distint_lambda();
            //Sample_Except_lambda();
            //Sample_Intersect_lambda();
            //Sample_Union_lamda();


            ////elements
            //Sample_ElementAt_lamda();
            //Sample_ElementAtOrDefault_lamda();
            //Sample_First_lamda();
            //Sample_First_lamda_condition();
            //Sample_FirstOrDefault_lamda();
            //Sample_Last_Lambda();
            //Sample_LastOrDefault_Simple();
            //Sample_LastOrDefault_Conditional();
            //Sample_Single_Lambda();
            // Sample_SingleOrDefault_Lambda();

            //quantifiers
            //Sample_All_Lambda();
            //Sample_Contains_Lambda();


            //example 
            //Sample_Contains_Lambda();
            //string_groupby();

        }
        //    static void Sample_OrderBy_Lambda_Numbers()
        //    {
        //        int[] numbers = { 5 , 2, 9};

        //        var result = numbers.OrderBy(n => n);

        //        Console.WriteLine("Ordered list of numbers:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }

        ////decending
        //static void Sample_OrderByDescending_Lambda()
        //{
        //    string[] names = { "nithya", "thanmai", "Shilpa" , "monika" , "arusha", "sindhu"};

        //    var result = names.OrderByDescending(n => n);

        //    Console.WriteLine("Descending ordered list of names:");
        //    foreach (string name in result)
        //        Console.WriteLine(name);
        //}

        ////reverse
        //static void Sample_Reverse_Lambda()
        //{
        //    char[] characters = { 'c', 'l', 'o','s', 'e' };

        //    var result = characters.Reverse();

        //    Console.WriteLine("Characters in reverse order:");
        //    foreach (char character in result)
        //        Console.WriteLine(character);
        //}

        ////then by
        //static void Sample_ThenBy_Lambda()
        //{
        //    string[] capitals = { "cherry", "crazy", "lucky", "chintu", "honey",
        //                  "charloite", "Beijing", "Seoul" };

        //    var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

        //    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
        //    foreach (string capital in result)
        //        Console.WriteLine(capital);
        //}

        //static void Sample_ThenByDescending_Lambda()
        //{
        //    var dates = new DateTime[] {
        //new DateTime(2015, 3, 1),
        //new DateTime(2015, 7, 1),
        //new DateTime(2015, 5, 1),
        //new DateTime(2015, 1, 1),
        //new DateTime(2015, 7, 1)
        //     };

        //    var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

        //    Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
        //    foreach (DateTime dt in result)
        //        Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        //}


        //skip
        //static void Sample_Skip_Lambda()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.Skip(4);

        //    Console.WriteLine("Skips the first 4 words:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}

        //static void Sample_SkipWhile_Lambda()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.SkipWhile(w => w.Length == 3);

        //    Console.WriteLine("Skips words while the condition is met:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}

        //static void Sample_Take_Lambda()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.Take(9);

        //    Console.WriteLine("Takes the first 5 numbers only:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}
        //static void Sample_TakeWhile_Lambda()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.TakeWhile(n => n < 9);

        //    Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}



        // aggregation
        //private static void Sample_Aggregate_Lambda_Simple()
        //{
        //    var numbers = new int[] { 1, 2, 3, 4, 5 };

        //    var result = numbers.Aggregate((a, b) => a * b);

        //    Console.WriteLine("Aggregated numbers by multiplication:");
        //    Console.WriteLine(result);
        //}

        //static void Sample_Average_Lambda()
        //{
        //    int[] numbers = { 27, 26, 28, 27 };

        //    var result = numbers.Average();

        //    Console.WriteLine("Average is:");
        //    Console.WriteLine(result);
        //}

        //static void Sample_Count_Lambda()
        //{
        //    string[] names = { "Paris", "seoul", "viatnum" };

        //    var result = names.Count();

        //    Console.WriteLine("Counting names gives:");
        //    Console.WriteLine(result);
        //}

        //static void Sample_Max_Lambda()
        //{
        //    int[] numbers = { 27, 28, 29 };
        //    var result = numbers.Max();
        //    Console.WriteLine("higest number is :");
        //    Console.WriteLine(result);
        //}

        //static void Sample_Min_Lamda()
        //{
        //    int[] numbers = { 27, 28, 29 };
        //    var result = numbers.Min();
        //    Console.WriteLine("smallest number is :");
        //    Console.WriteLine(result);
        //}

        //static void Sample_Sum_Lamda()
        //{
        //    int[] numbers = { 3, 7, 6 };
        //    var result = numbers.Sum();
        //    Console.WriteLine("the sum of the numbers is:");
        //    Console.WriteLine(result);
        //}


        ////set
        //static void Sample_distint_lambda()
        //{
        //    int[] numbers = { 1, 2, 2, 3, 4, 5, 6, 7, 7, 8, 9, 9, };
        //    var result = numbers.Distinct();

        //    Console.WriteLine("the distinct numbers will be removed");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}

        //static void Sample_Except_lambda()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    int[] numbers1 = { 6, 7, 8, 8, 8, 8 };
        //    var result = numbers.Except(numbers1);

        //    Console.WriteLine("the excepted number is ");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}


        //static void Sample_Intersect_lambda()
        //{
        //    int[] numbers = { 1, 8, 6 };
        //    int[] numbers1 = { 6, 4, 8 };
        //    var result = numbers.Intersect(numbers1);

        //    Console.WriteLine("the excepted number is ");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}

        //static void Sample_Union_lamda()
        //{
        //    int[] numbers = { 1, 8, 6 };
        //    int[] numbers1 = { 6, 4, 8 };
        //    var result = numbers.Union(numbers1);

        //    Console.WriteLine("the excepted number is ");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}


        ////element
        //static void Sample_ElementAt_lamda()
        //{
        //    string[] words = { " can", "san", "tan", "van" };
        //    var result = words.ElementAt(3);
        //    Console.WriteLine("  the word is");
        //    Console.WriteLine(result);
        //}

        //static void Sample_ElementAtOrDefault_lamda()
        //{
        //    string[] words = { " can", "san", "tan", "van" };
        //    var result = words.ElementAtOrDefault(3);
        //    var resultIndex1 = words.ElementAtOrDefault(4);
        //    Console.WriteLine("  the word is");
        //    Console.WriteLine(result);

        //    Console.WriteLine("  the default  word is");
        //    Console.WriteLine(resultIndex1 == null);
        //}

        //static void Sample_First_lamda()
        //{
        //    string[] words = { " can", "san", "tan", "van" };
        //    var result = words.First();
        //    Console.WriteLine("  the  first word is");
        //    Console.WriteLine(result);

        //}

        //static void Sample_First_lamda_condition()
        //{
        //    string[] words = { " canet", "san", "tangle", "van" };
        //    var result = words.First(w => w.Length == 3);
        //    Console.WriteLine("  the  first word with length 3 is");
        //    Console.WriteLine(result);

        //}

        //static void Sample_FirstOrDefault_lamda()
        //{
        //    string[] words = { " canet", "san", "tangle", "van" };
        //    string[] Empty = { };
        //    var result = words.FirstOrDefault(w => w.Length == 3);
        //    var resultEmpty = Empty.FirstOrDefault();
        //    Console.WriteLine("  the  first word with length  is");
        //    Console.WriteLine(result);


        //    Console.WriteLine("  the default  word is");
        //    Console.WriteLine(resultEmpty == null);

        //}

        //static void Sample_Last_Lambda()
        //{
        //    int[] numbers = { 7, 3, 5 };

        //    var result = numbers.Last();

        //    Console.WriteLine("Last number in array is:");
        //    Console.WriteLine(result);
        //}


        //static void Sample_LastOrDefault_Simple()
        //{
        //    string[] words = { "one", "two", "three" };
        //    string[] empty = { };

        //    var result = words.LastOrDefault();

        //    var resultEmpty = empty.LastOrDefault();

        //    Console.WriteLine("Last element in the words array contains:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("Last element in the empty array does not exist:");
        //    Console.WriteLine(resultEmpty == null);
        //}


        //static void Sample_LastOrDefault_Conditional()
        //{
        //    string[] words = { "one", "two", "three" };

        //    var result = words.LastOrDefault(w => w.Length == 3);

        //    var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

        //    Console.WriteLine("Last element in the words array having a length of 3:");
        //    Console.WriteLine(result);

        //    Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
        //    Console.WriteLine(resultNoMatch == null);
        //}


        //static void Sample_Single_Lambda()
        //{
        //    string[] names1 = { "Peter" };
        //    string[] names3 = { "Peter", "Joe", "Wilma" };
        //    string[] empty = { };

        //    var result1 = names1.Single();

        //    Console.WriteLine("The only name in the array is:");
        //    Console.WriteLine(result1);

        //    try
        //    {
        //        // This will throw an exception because array contains no elements
        //        var resultEmpty = empty.Single();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    try
        //    {
        //        // This will throw an exception as well because array contains more than one element
        //        var result3 = names3.Single();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        //static void Sample_SingleOrDefault_Lambda()
        //{
        //    string[] names1 = { "Peter" };
        //    string[] names3 = { "Peter", "Joe", "Wilma" };
        //    string[] empty = { };

        //    var result1 = names1.SingleOrDefault();

        //    var resultEmpty = empty.SingleOrDefault();

        //    Console.WriteLine("The only name in the array is:");
        //    Console.WriteLine(result1);

        //    Console.WriteLine("As array is empty, SingleOrDefault yields null:");
        //    Console.WriteLine(resultEmpty == null);

        //    try
        //    {
        //        // This will throw an exception as well because array contains more than one element
        //        var result3 = names3.SingleOrDefault();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}


        //quantifiers
        //static void Sample_All_Lambda()
        //{
        //    string[] names = { "Bobn", "Ned", "Amyn", "Billn" };

        //    var result = names.All(n => n.Contains("n"));

        //    Console.WriteLine("Does all of the names start with the letter 'B':");
        //    Console.WriteLine(result);
        //}

        //static void Sample_Any_Lambda()
        //{
        //    string[] names = { "Bob", "Ned", "Amy", "Bill" };

        //    var result = names.Any(n => n.StartsWith("B"));

        //    Console.WriteLine("Does any of the names start with the letter 'B':");
        //    Console.WriteLine(result);
        //}

        //static void Sample_Contains_Lambda()
        //{
        //    int[] numbers = { 1, 3, 5, 7, 9 };

        //    var result = numbers.Contains(5);

        //    Console.WriteLine("sequence contains the value 5:");
        //    Console.WriteLine(result);
        //}


        //EXAMPLES
        //static void Sample_Contains_Lambda()
        //{



        //}

        //static void Elementslength()
        //{

        //    string[] words1 = { "believe", "relief", "receipt", "field" };

        //    var result = from word in words1
        //                 select word;


        //    foreach (var word in result)
        //        Console.WriteLine($"{word}--{word.Length}");
        //}

        //static void string_groupby()
        //{
        //    List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacus", "banana", "apple", "chesse" };
        //    var wordgroups = words.GroupBy(x => x[0]).Select(y => new { firstletter = y.Key, words = y });

        //    var result = words.OrderBy(x => x.Length).ThenBy(x => x);
           





        //    //foreach (var item in wordgroups )
        //    //{
        //    //    Console.WriteLine("words that start with the" + "letter '{0}':", item.firstletter);
        //    //    foreach (var w in item.words)
        //    //    {

        //            foreach (string wordgroups in result)
        //            {
        //                //Console.WriteLine(capital);
        //                Console.WriteLine(result);
        //            }
        //        //}
        //   // }
        //}
    }
}   
