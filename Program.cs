using System;
using System.Linq;
using System.Collections.Generic;

namespace codecamp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //bai1();
            int[] numbers= {1,2,3,4,5};
            int[] squares = {1,4,9,16,25};
            //bai2(numbers, squares);

            string[] words= {"i", "you", "we", "they", "he", "she", "it"};
            
            System.Console.WriteLine(bai3(words));
        }

        static void bai1()
        {
            string[] cities = {"ROME", "ZURICH", "AMSTERDAM", "LONDON","HANOI","CALIFORNIA", "PARIS"};
            IEnumerable<string> temp = from city in cities
                            orderby city.Length, city.Substring(1,0) descending
                            select city;

            foreach (string result in temp)
                System.Console.WriteLine(result);
        }


        public static bool bai2(int[] numbers, int[] squares)
        {
            var check = from number in numbers
                                let sqr = number*number
                                select sqr;
            var result = squares.Intersect(check);
            if (result.Count()== squares.Length && result.Count()== numbers.Length)
            {
                System.Console.WriteLine("True");
                return true;
            } else {
                System.Console.WriteLine("False");
                return false;
            }
        }


        public static string bai3(string[] words)
        {
            var query = words.Where(word => word.Contains('e')).OrderBy(word=>word);
            if (query.Count()==0)
            {
                return "null";
            } else {
                
                return $"The last word is {query.Last()}";
        
            }

        }

    }
}
