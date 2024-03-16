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
        static int Counter = 0; // this creates my counter to count the number of steps
        static void Main() // main file that starts the program
        {
            Options(); //this calls a series of prints of different options for the user to pick
        }
        static void BubbleSort(string[] Network, int size, int range) // this implements a bubble sort
        {
            Console.WriteLine("Options"); // this prints a header
            Console.WriteLine("1: Ascending");// this prints a choice to the user
            Console.WriteLine("2: Descending");// this prints a choice to the user
            var user = Console.ReadLine(); // this reads the users choice
            int User = Convert.ToInt32(user); //this converts the users choice to an int
            if (User == 1) // this chooses the ascending data when the user types 1 
            {
                for (int x = 0; x < size; x++) // this createas a loop within the range of the arrays length, and every loop adds one to the x value
                {
                    for (int y = 0; y < size - 1 - x; y++) // this createas a loop within the range of the arrays length, and every loop adds one to the y value
                    {
                        if (Convert.ToInt32(Network[y + 1]) < Convert.ToInt32(Network[y])) // this says that if 1 postion is greater than the other
                        {
                            Counter = Counter + 1; // this adds one to the step counter every swap it makes
                            var temp = Network[y]; // this isolates one value 
                            Network[y] = Network[y + 1]; // this swaps the value
                            Network[y + 1] = temp; // this isolates the other value 
                        }
                    }
                }
                PrintNetwork(Network, size, range, Counter); // this calls the print network
            }
            if(User == 2) // this chooses the descending data when the user types 2
            {
                for (int x = 0; x < size; x++) // this createas a loop within the range of the arrays length, and every loop adds one to the x value
                {
                    for (int y = 0; y < size - 1 - x; y++) // this createas a loop within the range of the arrays length, and every loop adds one to the y value
                    {
                        if (Convert.ToInt32(Network[y + 1]) > Convert.ToInt32(Network[y])) // this says that if 1 postion is smaller than the other
                        {
                            Counter = Counter + 1; // this adds one to the step counter every swap it makes
                            var temp = Network[y]; // this isolates one value
                            Network[y] = Network[y + 1]; // this swaps the value
                            Network[y + 1] = temp; // this isolates the other value 
                        }
                    }
                }
                PrintNetwork(Network, size, range, Counter); // this calls the print network
            }
            if(User > 2) // this makes any other input redo the selection process
            {
                BubbleSort(Network, size, range); // this calls bubble sort to redo the selection process
            }
        }
        static void InsertionSort(string[] Network, int size, int range) // this implements a insertion sort
        {
            int number = 1; int element; // this creates 2 values for the loops
            Console.WriteLine("Options"); // this prints a header
            Console.WriteLine("1: Ascending"); // this prints a choice to the user
            Console.WriteLine("2: Descending"); // this prints a choice to the user
            var user = Console.ReadLine(); // this reads the users choice
            int User = Convert.ToInt32(user); //this converts the users choice to an int
            if (User == 1) // this chooses the ascending data when the user types 1 
            {
                while (number < size) // this compares the value i created earlier and makes sure its lower than the arrays size
                {
                    var temp = Network[number]; // this assigns a temporary value to hold a postion in the network
                    for (element = number; element > 0; element--) // this instigates a loop which makes sure that element is above 0 and minus 1 each loop
                    {
                        if (Convert.ToInt32(temp) < Convert.ToInt32(Network[element - 1])) // this check to see if the held value in temp is greater than the current value being checked
                        {
                            Counter = Counter + 1; // this adds one to the step counter
                            Network[element] = Network[element - 1]; // this swaps two values
                        }
                        else
                        {
                            break; // this just breaks the loop
                        }

                    }
                    Network[element] = temp; // this swaps the temp value 
                    number++; // this adds one to the value number
                }
                PrintNetwork(Network, number, range, Counter); // this calls the print network
            }
            if (User == 2) // this chooses the descending data when the user types 2
            {
                while (number < size) // this compares the value i created earlier and makes sure its lower than the arrays size
                {
                    var temp = Network[number]; // this assigns a temporary value to hold a postion in the network
                    for (element = number; element > 0; element--) // this instigates a loop which makes sure that element is above 0 and minus 1 each loop
                    {
                        if (Convert.ToInt32(temp) > Convert.ToInt32(Network[element - 1])) // this check to see if the held value in temp is smaller than the current value being checked
                        {
                            Counter = Counter + 1; // this adds one to the step counter
                            Network[element] = Network[element - 1]; // this swaps two values
                        }
                        else
                        {
                            break; // this just breaks the loop
                        }

                    }
                    Network[element] = temp; // this swaps the temp value 
                    number++; // this adds one to the value number
                }
                PrintNetwork(Network, number, range, Counter); // this calls the print network
            }
            if(User > 2) // this means if the user puts a number over 2 it will re do the selection 
            {
                InsertionSort(Network, size, range); // this redo the selection process for the insertion sort 
            }
        }
        static void LinearSearch(string[] Network, int size) // this implements a linear search
        {
            Console.WriteLine("What number would you like to find?");
            var ReadUser = Console.ReadLine(); // this reads the users input
            int user = Convert.ToInt32(ReadUser); // this coverts the user to an integer
            int user2 = Convert.ToInt32(ReadUser); // this coverts the user to an integer
            int e2 = 0; // this creates an value for postion 
            for (int e1 = 0; e1 < size; ++e1, ++e2) // this creates a loop that makes sure that e1 is smaller than the length of the array and adds 1 to 2 postion values
            {
                Counter = Counter + 1; // this adds one to the step counter
                if (user == Convert.ToInt32(Network[e1])) // this checks the users input for a direct match within the network
                {
                    e1 = e1 + 1; // this adds one to the line counter 
                    Console.WriteLine("This is your number: " + user + " it was found on line number: " + e1); // this prints in the console the number they chose and the postion of the number within the network
                    Console.WriteLine("This search took " + Counter + " Steps"); // this shows how many steps it took to find the number
                    break; // this breaks the loop
                }
                else if (user - 1 == Convert.ToInt32(Network[e1])) // this checks the loop for 1 below the users input 
                {
                    if (user2 + 1 == Convert.ToInt32(Network[e2]))
                    {
                        Counter = Counter + 1; // this adds one to the step counter
                        e1 = e1 + 1; // this adds 1 to the postion values
                        e2 = e2 + 1; // this adds 1 to the postion values
                        Console.WriteLine("The closest number to your number was " + Network[e1 - 1] + "and was found on line: " + e1 + "\nthe same distance appart there was the number " + Network[e2 - 1] + " on line: " + e2); // this prints both values found if there is one above and one below the users data
                        Console.WriteLine("This search took " + Counter + " Steps"); // this shows how many steps the search took
                        break; // this breaks the loop

                    }
                    e1 = e1 + 1;
                    Counter = Counter + 1; // this adds one to the step counter
                    Console.WriteLine("The closest number to your number was " + Network[e1 - 1] + " and was found on line " + e1); // this prints the closest number to the users number
                    Console.WriteLine("This search took " + Counter + " Steps"); // this shows how many steps the search took
                    break; // this breaks the loop
                }
                else if (user2 + 1 == Convert.ToInt32(Network[e2])) // this checks the loop for 1 above the users input 
                {
                    Counter = Counter + 1; // this adds one to the step counter
                    if (user - 1 == Convert.ToInt32(Network[e1]))
                    {
                        e1 = e1 + 1; // this adds 1 to the postion values
                        e2 = e2 + 1; // this adds 1 to the postion values
                        Console.WriteLine("The closest number to your number was " + Network[e1 - 1] + " and was found on line: " + e1 + "\nAnd the same distance appart there was the number " + Network[e2 - 1] + "on line: " + e2); // this prints both values found if there is one above and one below the users data
                        Console.WriteLine("This search took " + Counter + " Steps"); // this shows how many steps the search took
                        break; // this breaks the loop

                    }
                    e2 = e2 + 1;
                    Console.WriteLine("The closest number to your number was " + Network[e2 - 1] + " and was found on line " + e2); // this prints the closest number to the users number
                    Console.WriteLine("This search took " + Counter + " Steps"); // this shows how many steps the search took
                    break; // this breaks the loop
                }
            }
        }
                
        static void PrintNetwork(string[] Network, int size, int range, int count) // this prints the network when the sort is completed
        {
            int i; // this creates a int value
            for (i = range; i < size; i += range) // this creates a loop that when i is equal to 10 or 50 and i is smaller than the length of the array it shall loop
            
                Console.WriteLine("Line number " + i + " :" + Network[i]); // this prints every 10 or 50th number depending on the network size
                Console.WriteLine("This took: " + count+ " Steps"); // this shows how many steps were taken        
            Console.WriteLine("Press any key to end: "); // this tells you how to quit
            Console.ReadKey(true); // this just reads the key the user pressed
        }
        static void Options() // this is just a series of prinatable lines of code so the user know the options they can choose 
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
            UserChoices(); // this calls the selection process
        }
        static void UserChoices() // this is where the users input is processed
        {
            string filename; // this creates two string values
            string filepath; // this creates two string values
            filename = "Net_1_256.txt"; filepath = Path.GetFullPath(filename); // this searches the debug bin for files that match the name of the filename value
            string[] Net_1_256 = File.ReadAllLines(filepath); int Net_256_size = Net_1_256.Length; int Net_256_range = 10; // this reads all lines of the file and puts it into an array, it also takes the arrays length and creates it a value that i can use later and also createas another value that creates the every value for later
            filename = "Net_2_256.txt"; filepath = Path.GetFullPath(filename); // this searches the debug bin for files that match the name of the filename value
            string[] Net_2_256 = File.ReadAllLines(filepath); // this reads all lines of the file and puts it into an array
            filename = "Net_3_256.txt"; filepath = Path.GetFullPath(filename); // this searches the debug bin for files that match the name of the filename value
            string[] Net_3_256 = File.ReadAllLines(filepath);// this reads all lines of the file and puts it into an array
            filename = "Net_1_2048.txt"; filepath = Path.GetFullPath(filename); // this searches the debug bin for files that match the name of the filename value
            string[] Net_1_2048 = File.ReadAllLines(filepath); int Net_2048_size = Net_1_2048.Length; int Net_2048_range = 50; // this reads all lines of the file and puts it into an array, it also takes the arrays length and creates it a value that i can use later and also createas another value that creates the every value for later
            filename = "Net_2_2048.txt"; filepath = Path.GetFullPath(filename); // this searches the debug bin for files that match the name of the filename value
            string[] Net_2_2048 = File.ReadAllLines(filepath);// this reads all lines of the file and puts it into an array
            filename = "Net_3_2048.txt"; filepath = Path.GetFullPath(filename); // this searches the debug bin for files that match the name of the filename value
            string[] Net_3_2048 = File.ReadAllLines(filepath);// this reads all lines of the file and puts it into an array



            var user = Console.ReadLine(); // this reads the users input
            int User = Convert.ToInt32(user); // this converts the users data to a int
            if (User == 1) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {
                    UserOptions(Net_1_256, Net_256_size, Net_256_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }
            }
            if (User == 2) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {

                    UserOptions(Net_2_256, Net_256_size, Net_256_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 

                }
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }
            }
            if (User == 3) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {
                    UserOptions(Net_3_256, Net_256_size, Net_256_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }
            }
            if (User == 4) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {
                    UserOptions(Net_1_2048, Net_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }

            }
            if (User == 5) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {
                    UserOptions(Net_2_2048, Net_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }
            }
            if (User == 6) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {
                    UserOptions(Net_3_2048, Net_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }
            }
            if (User == 7) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {
                    String[] Merged_256 = Net_1_256.Concat(Net_3_256).ToArray(); int Merged_256_size = Merged_256.Length; // this merges the networks together
                    UserOptions(Merged_256, Merged_256_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }
            }
            if (User == 8) // this checks to see if the users data is the same as the users input 
            {
                try // this trys the code within the try block and if it doesnt work then
                {
                    String[] Merged_2048 = Net_1_2048.Concat(Net_3_2048).ToArray(); int Merged_2048_size = Merged_2048.Length; // this merges the networks together
                    UserOptions(Merged_2048, Merged_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                } // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                catch (Exception exception) // then it is caught by the catch clause and will highlight the error
                {
                    Console.WriteLine("An error has occured please check: " + exception.Message); // this is how the error is printed
                }
            }
            if (User > 8 || User == 0) // this redos the selection 
            {
                Options(); // this calls the program again
            }

        }
        static void UserOptions(string[] Network, int size, int range) // this is how the user selects the type of algorithm they would like to use 
        {
            Console.WriteLine("Options");
            Console.WriteLine("----------------");
            Console.WriteLine("Sort");
            Console.WriteLine("1:Bubble sort");
            Console.WriteLine("2:Insertion sort");
            Console.WriteLine("----------------");
            Console.WriteLine("Search");
            Console.WriteLine("3:Linear");
            Console.WriteLine("----------------");
            var user = Console.ReadLine(); // this reads the users input

            if (user == "1") // this checks if the users input martches a choice
            {
                BubbleSort(Network, size, range); // this pushes the network, size and range through into an algorithm
            }
            else if (user == "2") // this checks if the users input martches a choice
            {
                InsertionSort(Network, size, range); // this pushes the network, size and range through into an algorithm
            }
            else if (user == "3") // this checks if the users input martches a choice
            {
                LinearSearch(Network, size); // this pushes the network and size through into an algorithm
            }
            else // if the user types something that isnt 1,2, or 3 
            {
                Console.WriteLine("not within parameter, again please");
                UserOptions(Network, size, range); // it repeats the selection

            }
        }
    }
}
