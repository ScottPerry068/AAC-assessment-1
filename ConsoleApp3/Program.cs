using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Options();
        }
        static void BubbleSort(string[] Network, int size, int range)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (Convert.ToInt32(Network[j + 1]) < Convert.ToInt32(Network[j]))
                    {
                        var temp = Network[j];
                        Network[j] = Network[j + 1];
                        Network[j + 1] = temp;
                    }
                }
            }
            PrintNetwork(Network, size, range);
        }
        static void InsertionSort(string[] Network, int size, int range)
        {
            int number = 1; int element;

            while (number < size)
            {
                var temp = Network[number];
                for(element=number; element > 0; element--)
                {
                    if (Convert.ToInt32(temp) < Convert.ToInt32(Network[element - 1]))
                    {
                        Network[element] = Network[element - 1];
                    }
                    else
                    {
                        break;
                    }
                    
                }
                Network[element] = temp;
                number++;
            }
            PrintNetwork(Network, number, range);
        }
        static void LinearSearch(string[] Network, int size, int range)
        {
            Console.WriteLine("What number would you like to find?");
            var ReadUser = Console.ReadLine();
            int user = Convert.ToInt32(ReadUser);
            int user2 = Convert.ToInt32(ReadUser);
            int e1 = 0;
            int e2 = 0;
            for(e1 = 0; e1< size; e1++)
            {
                if (user == Convert.ToInt32(Network[e1]))
                {
                    e1 = e1 + 1;
                    Console.WriteLine("This is your number: " + user + " it was found on line number: " + e1);
                }
            }
            for (e1 = 0; e1 < size; e1++,e2++)
            {
                if (user - 1 == Convert.ToInt32(Network[e1]))
                {
                    if (user2 + 1 == Convert.ToInt32(Network[e2]))
                    {
                        e1 = e1 + 1;
                        e2 = e2 + 1;
                        Console.WriteLine("The closest number to your number was " + user + "and was found on line: " + e1 + "\nthe same distance appart there was the number " + user2 + " on line: " +e2);
                        break;
            
                    }
                    e1 = e1 + 1;
                    Console.WriteLine("The closest number to your number was " + user + " and was found on line " + e1);
                    break;
                }
                else if (user2 + 1 == Convert.ToInt32(Network[e2]))
                {
                    if (user - 1 == Convert.ToInt32(Network[e1]))
                    {
                        e1 = e1 + 1;
                        e2 = e2 + 1;
                        Console.WriteLine("The closest number to your number was " + user + " and was found on line: " + e1 + "\nthe same distance appart there was the number " + user2 + "on line: " + e2);
                        break;
            
                    }
                    e2 = e2 + 1;
                    Console.WriteLine("The closest number to your number was "  + user2 + " and was found on line " + e2);
                    break;
                }
            
            }
        }
        static void PrintNetwork(string[] Network, int size, int range)
        {
            int i;
            for (i = range; i < size; i += range)
            
                Console.WriteLine("Line number " + i + " :" + Network[i]);
                //i = i + range;
            
            Console.WriteLine("Press any key to end: ");
            Console.ReadKey(true);
        }
        static void Options()
        {
            Console.WriteLine("----Options----");
            Console.WriteLine("---------------");
            Console.WriteLine("--1:Net 1 256--");
            Console.WriteLine("--2:Net 2 256--");
            Console.WriteLine("--3:Net 3 256--");
            Console.WriteLine("---------------");
            Console.WriteLine("--4:Net 1 2048-");
            Console.WriteLine("--5:Net 2 2048-");
            Console.WriteLine("--6:Net 3 2048-");
            Console.WriteLine("---------------");
            Console.WriteLine("7:Net 1 256 and Net 3 256");
            Console.WriteLine("8:Net 1 2048 and Net 3 2048");
            Console.WriteLine("---------------");
            UserChoices();
        }
        static void UserChoices()
        {
            string filename;
            string filepath;
            filename = "Net_1_256.txt"; filepath = Path.GetFullPath(filename);
            string[] Net_1_256 = File.ReadAllLines(filepath); int Net_256_size = Net_1_256.Length; int Net_256_range = 10;
            filename = "Net_2_256.txt"; filepath = Path.GetFullPath(filename);
            string[] Net_2_256 = File.ReadAllLines(filepath); 
            filename = "Net_3_256.txt"; filepath = Path.GetFullPath(filename);
            string[] Net_3_256 = File.ReadAllLines(filepath); 
            filename = "Net_1_2048.txt"; filepath = Path.GetFullPath(filename);
            string[] Net_1_2048 = File.ReadAllLines(filepath); int Net_2048_size = Net_1_2048.Length; int Net_2048_range = 50;
            filename = "Net_2_2048.txt"; filepath = Path.GetFullPath(filename);
            string[] Net_2_2048 = File.ReadAllLines(filepath); 
            filename = "Net_3_2048.txt"; filepath = Path.GetFullPath(filename);
            string[] Net_3_2048 = File.ReadAllLines(filepath); 



            var user = Console.ReadLine();
            if (user == "1")
            {
                try
                {
                    UserOptions(Net_1_256, Net_256_size, Net_256_range);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }
            }
            if (user == "2")
            {
                try
                {

                    UserOptions(Net_2_256, Net_256_size, Net_256_range);

                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }
            }
            if (user == "3")
            {
                try
                {
                    UserOptions(Net_3_256, Net_256_size, Net_256_range);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }
            }
            if (user == "4")
            {
                try
                {
                    UserOptions(Net_1_2048, Net_2048_size, Net_2048_range);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }

            }
            if (user == "5")
            {
                try
                {
                    UserOptions(Net_2_2048, Net_2048_size, Net_2048_range);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }
            }
            if (user == "6")
            {
                try
                {
                    UserOptions(Net_3_2048, Net_2048_size, Net_2048_range);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }
            }
            if (user == "7")
            {
                try
                {
                    String[] Merged_256 = Net_1_256.Concat(Net_3_256).ToArray(); int Merged_256_size = Merged_256.Length;
                    UserOptions(Merged_256, Merged_256_size, Net_2048_range);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }
            }
            if (user == "8")
            {
                try
                {
                    String[] Merged_2048 = Net_1_2048.Concat(Net_3_2048).ToArray(); int Merged_2048_size = Merged_2048.Length;
                    UserOptions(Merged_2048, Merged_2048_size, Net_2048_range);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message);
                }
            }
        }
        static void UserOptions(string[] Network, int size, int range)
        {
            Console.WriteLine("-----Options----");
            Console.WriteLine("----------------");
            Console.WriteLine("-----Sort-------");
            Console.WriteLine("1:Bubble sort");
            Console.WriteLine("2:Insertion sort");
            Console.WriteLine("3:Selection sort");
            Console.WriteLine("-----Search-----");
            Console.WriteLine("----4:Linear----");
            Console.WriteLine("----5:Binary----");
            Console.WriteLine("----------------");
            var user = Console.ReadLine();

            if (user == "1")
            {
                BubbleSort(Network, size, range);
            }
            else if (user == "2")
            {
                InsertionSort(Network, size, range);
            }
            else if (user == "4")
            {
                LinearSearch(Network, size, range);
            }
            else
            {
                Console.WriteLine("not within parameter, again please");
                //UserOptions(Network, size, range);

            }
        }
    }
}
