using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Subject Monday = Subject.PE;
            ReactOnSubject(Monday);
            ShowEnvironmentDetails();
            Console.ReadLine();
        }
        static void swap(ref string a, ref string b)
        {
            string c = a;
            a = b;
            b = c;
        }
        static double Average (params double[] values)
        {
            double sum = 0;
            foreach (double value in values)
                sum += value;
            return sum/values.Length;
        }
        static void MyMark(int number, int mark = 3)
        {
            Console.WriteLine("Your mark in subject {0} is {1}!", number, mark);
        }
        static void MyMark(int number, double mark)
        {
            Console.WriteLine("Your mark in subject {0} is {1}!", number, mark);
        }

        enum Subject
        {PE, Math, Physics, Chemistry}

        static void ReactOnSubject(Subject e)
        {
            switch ((int)e)
                {
                    case 0:
                        Console.WriteLine("Dat's cool, go play football!");
                    break;
                    case 1:
                        Console.WriteLine("How can u multiply 2 with 2?");
                    break;
                    case 2:
                        Console.WriteLine("Big Bang Theory, uhaa!");
                    break;
                    case 3:
                        Console.WriteLine("Gonna blow smth up!");
                    break;
                    default:
                        Console.WriteLine("Missing school today? Not good, dude.");
                    break;
                }
                
        }
        static void ShowEnvironmentDetails()
        {
            int[][] jaggedarr = new int[5][];
            for (int i = 0; i < jaggedarr.Length; i++)
                jaggedarr[i] = new int[i + 7];
            for (int i = 0; i < jaggedarr.Length;i++)
            {
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    jaggedarr[i][j] = j+1;
                    Console.Write(jaggedarr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Jaggedarray has {0} dimensions.", jaggedarr.Rank);
            //Console.ReadKey();
            var array = new[] {"goddamn", "please, no", "stop it", "ffs" };
            Console.WriteLine("Array is {0}!", array.ToString());
            string[] savearr = new string[4];
            array.CopyTo(savearr, 0);
            Array.Reverse(savearr);
            for (int i = 0; i < savearr.Length; i++)
                Console.Write(savearr[i] + " ");
            //Console.ReadKey();
            MyMark(mark: 5,number: 1);
            MyMark(2);
            MyMark(3, mark: 2.8);
            string str1 = "zalupa", str2 = "zalopa";
            Console.WriteLine("First string before swap is: {0}, second is: {1}", str1, str2);
            swap(ref str1, ref str2);
            Console.WriteLine("First string after swap is: {0}, second is: {1}", str1, str2);
            Console.WriteLine(Average(0));
            Console.WriteLine(Average(2.3, 4, 64.1, 34));
            Console.WriteLine(Average(2, 3, 4, 6, 4.1, 3, 4));
            //Console.ReadKey();
            ConsoleColor col = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version: {0}", Environment.Version);
            Console.WriteLine(Environment.Is64BitOperatingSystem ? "U have 64-bit operating system dude!" : "U have not 64-bit operating system.That's a pity!");
            Console.WriteLine("Your great PS's name is {0}", Environment.MachineName);
            Console.Title = "I'm bored.";
            Console.ForegroundColor = col;
            char symbol = 'a';
            Console.WriteLine("Is a symbol a letter? : {0}", char.IsLetter(symbol));
            Console.WriteLine("Is a symbol a number? : {0}", char.IsNumber(symbol));
            string line = "Top coder here dudes.";
            Console.WriteLine("Is a symbol a whitespave? : {0}", char.IsWhiteSpace(line, 3));
            Console.WriteLine("Is a symbol a whitespave? : {0}", char.IsWhiteSpace(line, 4));
            Console.WriteLine("Is ? a punctuation? {0}", char.IsPunctuation('?'));
            long numba = 10000000;
            BigInteger bigshit = new BigInteger(numba);
            string forverybignumba = "99999999999999999999999999999999999999999";
            BigInteger verybigshit = BigInteger.Parse(forverybignumba);
            Console.WriteLine("BigInteger number is: {0}", bigshit);
            Console.WriteLine("Another BigInteger number is: {0}", verybigshit);
            Console.WriteLine("Are those BigInteger numbers even? 1: {0}, 2: {1}",bigshit.IsEven, verybigshit.IsEven);
            Console.WriteLine("Are those BigInteger numbers powers of 2? 1: {0}, 2: {1}", bigshit.IsPowerOfTwo, verybigshit.IsPowerOfTwo);
            Console.WriteLine("The sum of those BigIntegers is: {0}", bigshit + verybigshit);
            string line2 = "оооОоооо, поезда!оооо";
            Console.WriteLine("Does line2 contain (!)?: " + line2.Contains('!'));
            //Console.WriteLine("Line2 w/o any (о)es: {0}", line2.Remove();
            Console.WriteLine("Line2 w/o any (о)es in the end and begining: "+line2.Trim('о'));
            Console.WriteLine("Line2 w/o any (о)es: {0}", line2.Replace("о",""));
            Console.WriteLine("I wonder if line2 changed 0_0: "+line2);
            Console.WriteLine("Ok, it didn't, fuck this life ;(((");
            Console.WriteLine("Ты че самый умный  \t Не, нифига ");
            Console.WriteLine(@"That guy said: ""U fucker""");
            Console.WriteLine("Is line2 == TOP CODER IS HERE DUDES.?: {0}",line2 =="TOP CODER IS HERE DUDES.");
            Console.WriteLine("Is line2 == TOP CODER IS HERE DUDES.?: " + (line2 == "TOP CODER IS HERE DUDES."));
            line = "You are stupid as shit!";
            Console.WriteLine(line);
            int x = 1;
            x <<= 32;
            Console.WriteLine(x);
        }
    }
}
