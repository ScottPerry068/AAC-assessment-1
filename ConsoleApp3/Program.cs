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
        static void Main(string[] args)
        {
            //int[] array = { 10, 4, 6, 8, 111, 555, 678, 9, 0 };
            //bubblesort(array);
            //printArray(array);
            Options();
            UserChoices();

        }
        static void BubbleSort(string[] array, int size, int range)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (Convert.ToInt32(array[j + 1]) < Convert.ToInt32(array[j]))
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            printArray(array, size, range);
        }
        static void printArray(string[] array, int size, int range)
        {
            int i;
            for (i = range; i < size; i+= range)
                Console.WriteLine("Line number "+i + " :"+array[i]);
                i = i+range;
            //Console.WriteLine("Press");
            //Console.ReadKey(true);
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
                //InsertionSort(Network);
            }


            else if (user == "3")
            {
                //SelectionSort(Network);
            }


            else if (user == "4")
            {
                //LinearSearch(Network);
            }


            else if (user == "5")
            {
                //BinarySearch(Network);
            }
            else
            {
                Console.WriteLine("not within parameter, again please");

            }
        }
    }
}
