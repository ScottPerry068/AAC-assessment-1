using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    internal class Program
    {
        static int Counter = 0; // this creates my counter to count the number of steps
        static string TypeString;
        static void Main() // main file that starts the program
        {
            try
            {

                Options(); //this calls a series of prints of different options for the user to pick
            }
            catch
            {
                Options();

            }
        }
        static void SelectionSort(string[] Network, int size, int range)
        {
            Console.WriteLine("Options"); // this prints a header
            Console.WriteLine("1: Ascending");// this prints a choice to the user
            Console.WriteLine("2: Descending");// this prints a choice to the user
            Console.WriteLine("Press enter to go back!");
            var user = Console.ReadLine(); // This reads the users input
            var User = Convert.ToInt32(user);
            try
            {
                if (User == 1) // if users input = 1 then runs code
                {
                    for (int x = 0; x < size - 1; x++) // this createas a loop within the range of the arrays length, and every loop adds one to the x value
                    {
                        Counter = Counter + 1; // this adds one to the step counter
                        int minimum = x; // this creates the minimun value
                        for (int y = x + 1; y < size; y++) // this loop adds one to the min value and checks that y is below the array length

                            if (Convert.ToInt32(Network[y]) < Convert.ToInt32(Network[minimum])) // finds min
                                minimum = y; // assigns min to Y
                                             //swaps the min with first element
                        Counter = Counter + 1;
                        var temp = Network[minimum];// this holds the min value
                        Network[minimum] = Network[x];// this changes the min
                        Network[x] = temp;// this changes the temp 
                    }
                    PrintNetwork(Network, size, range, Counter); // calls print network
                }
                if (User == 2) // if users input = 1 then runs code
                {
                    for (int x = 0; x < size - 1; x++) // this createas a loop within the range of the arrays length, and every loop adds one to the x value
                    {
                        Counter = Counter + 1; // this adds one to the step counter
                        int minimum = x; // this creates the minimun value
                        for (int y = x + 1; y < size; y++) // this loop adds one to the min value and checks that y is below the array length

                            if (Convert.ToInt32(Network[y]) > Convert.ToInt32(Network[minimum])) // finds min
                                minimum = y; // assigns min to Y
                                             //swaps the min with first element
                        Counter = Counter + 1; // this adds one to the step counter
                        var temp = Network[minimum]; // this holds the min value
                        Network[minimum] = Network[x]; // this changes the min
                        Network[x] = temp; // this changes the temp 
                    }
                    PrintNetwork(Network, size, range, Counter); // calls print network
                }
            }
            catch
            {
                Console.WriteLine("That is the incorrect input please try again");
                SelectionSort(Network, size, range);
            }
            try
            {
                if (User > 3 || User == 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(User));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number was out of range!");
                InsertionSort(Network, size, range);
            }
        }
        static void BubbleSort(string[] Network, int size, int range) // this implements a bubble sort
        {
            Console.WriteLine("Options"); // this prints a header
            Console.WriteLine("1: Ascending");// this prints a choice to the user
            Console.WriteLine("2: Descending");// this prints a choice to the user
            Console.WriteLine("Press enter to go back!");
            var user = Console.ReadLine(); // this reads the users choice
            int User = Convert.ToInt32(user); //this converts the users choice to an int
            try
            {
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
                if (User == 2) // this chooses the descending data when the user types 2
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
            }
            catch // this makes any other input redo the selection process
            {

                Console.WriteLine("invalid input, please try agin!");
                BubbleSort(Network, size, range); // this calls bubble sort to redo the selection process

            }
            try
            {
                if (User > 3 || User == 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(User));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number was out of range!");
                InsertionSort(Network, size, range);
            }
        }
        static void InsertionSort(string[] Network, int size, int range) // this implements a insertion sort
        {
            int number = 1; int element; // this creates 2 values for the loops
            Console.WriteLine("Options"); // this prints a header
            Console.WriteLine("1: Ascending"); // this prints a choice to the user
            Console.WriteLine("2: Descending"); // this prints a choice to the user
            Console.WriteLine("Press enter to go back!");
            var user = Console.ReadLine(); // this reads the users choice
            int User = Convert.ToInt32(user); //this converts the users choice to an int
            try
            {
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
                        Counter = Counter + 1; // this adds one to the step counter
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
            }
            catch // this means if the user puts a number over 2 it will re do the selection 
            {
                Console.WriteLine("invalid input, please try agin!");
                InsertionSort(Network, size, range); // this redo the selection process for the insertion sort 
            }
            try
            {
                if (User > 3 || User == 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(User));
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number was out of range!");
                InsertionSort(Network, size, range);
            }
        }
        static void LinearSearch(string[] Network, int size) // this implements a linear search
        {
            Console.WriteLine("Press enter to go back, if you want another algorithm!");
            Console.WriteLine("What number would you like to find?");
            var ReadUser = Console.ReadLine(); // this reads the users input
            int user = Convert.ToInt32(ReadUser); // this coverts the user to an integer
            bool Found = false;
            try
            {
                for (int e1 = 0; e1 < size; ++e1) // this creates a loop that makes sure that e1 is smaller than the length of the array and adds 1 to 2 postion values
                {
                    Counter = Counter + 1; // this adds one to the step counter
                    if (user == Convert.ToInt32(Network[e1])) // this checks the users input for a direct match within the network
                    {
                        e1 = e1 + 1; // this adds one to the line counter 
                        Console.WriteLine("This is your number: " + user + " it was found on line number: " + e1); // this prints in the console the number they chose and the postion of the number within the network
                        Console.WriteLine("This search took " + Counter + " Steps"); // this shows how many steps it took to find the number
                        Found = true; // this tells the system a match was found 
                        continue; // this continues the loop to check for other possablities
                    }
                    if (e1 > size - 2) // this tells the search it has reached the end
                    {
                        if (Found == false) // this is for if a match wasnt found
                        {
                            Console.WriteLine("Your number is not in the data set ");
                            Environment.Exit(0); //this exits the code
                        }
                        Environment.Exit(0); //this exits the code
                    }
                }
            }
            catch
            {
                Console.WriteLine("That is the incorrect input please try again");
                LinearSearch(Network, size);
            }
        }
        static void BinarySearch(string[] Network, int size)
        {
            for (int x = 0; x < size; x++) // this createas a loop within the range of the arrays length, and every loop adds one to the x value
            {
                for (int y = 0; y < size - 1 - x; y++) // this createas a loop within the range of the arrays length, and every loop adds one to the y value
                {
                    if (Convert.ToInt32(Network[y + 1]) < Convert.ToInt32(Network[y])) // this says that if 1 postion is greater than the other
                    {
                        var temp = Network[y]; // this isolates one value 
                        Network[y] = Network[y + 1]; // this swaps the value
                        Network[y + 1] = temp; // this isolates the other value 
                    }
                }
            }
            Console.WriteLine("Press enter to go back, if you want another algorithm!");
            Console.WriteLine("What number would you like to find?");
            var ReadUser = Console.ReadLine(); // this reads the users input
            int user = Convert.ToInt32(ReadUser); // this coverts the user to an integer
            bool Found = false; // this is a bool value i use to tell if the data inst in the dataset 
            int number = 0; //this is just an empty value for the while loop
            int length = size - 1;// - 1; // this is to make the range
            try
            {
                while (number <= length) // this while loop loops till the end of the dataset
                {
                    int midpoint = (number + length) / 2; // this finds the midpoint of the data 
                    if (Convert.ToInt32(Network[midpoint]) == user) // this checks if the midpoint of the data is the number the user searched for
                    {
                        Console.WriteLine(Network[midpoint]);
                        Counter = Counter + 1; // this is a step counter
                        int Line = midpoint + 1; // this adds one to the midpoint to give me the line number of the sorted network 
                        Console.WriteLine("Your number: " + user + " Was found in the sorted list at line: " + Line);
                        Console.WriteLine("This search took " + Counter + " Steps");
                        Found = true; // this is so the console doesnt say the number isnt in the list

                        //this block of code finds if there is another location of the same value 
                        if (Convert.ToInt32(Network[midpoint - 1]) == user) // this ignores the left hand side if the users number is larger than then the network
                        {
                            Counter = Counter + 1; // this is a step counter
                            Line = midpoint - 1; // this just creates the line number of the sorted list
                            Console.WriteLine("This search took " + Counter + " Steps");
                            Console.WriteLine("Your number: " + user + " Was found in the sorted list at line: " + Line);
                        }
                        if (Convert.ToInt32(Network[midpoint + 1]) == user) // this ignores the right hand side
                        {
                            Counter = Counter + 1; // this adds one to the step counter
                            Line = midpoint; // this just creates the line number of the sorted list
                            Console.WriteLine("This search took " + Counter + " Steps");
                            Console.WriteLine("Your number: " + user + " Was found in the sorted list at line: " + Line);
                        }
                        Environment.Exit(0); //this exits the code
                        break;
                    }
                    if (Convert.ToInt32(Network[midpoint]) < user) // this ignores the left hand side if the users number is larger than then the network
                    {
                        Counter = Counter + 1; // this is a step counter
                        number = midpoint + 1; // this increases the midpoint
                    }
                    if (Convert.ToInt32(Network[midpoint]) > user) // this ignores the right hand side
                    {
                        Counter = Counter + 1; // this adds one to the step counter
                        length = midpoint - 1; // this changes the length so the right handside is ignored
                    }
                }
                if (Found == false) // this tells the user that there number wasnt found
                {
                    Console.WriteLine("Your number wasn't found");
                    Environment.Exit(0); //this exits the code
                }
            }
            catch // this catches an erronious input and makes the user input again
            {
                Console.WriteLine("That is the incorrect input please try again");
                BinarySearch(Network, size);
            }
        }
        static void PrintNetwork(string[] Network, int size, int range, int count) // this prints the network when the sort is completed
        {
            int i; // this creates a int value
            for (i = range; i < size; i += range) // this creates a loop that when i is equal to 10 or 50 and i is smaller than the length of the array it shall loop

                Console.WriteLine("Line number " + i + " :" + Network[i]); // this prints every 10 or 50th number depending on the network size
            Console.WriteLine("This took: " + count + " Steps"); // this shows how many steps were taken        
            Environment.Exit(0);
        }
        static void Options() // this is just a series of prinatable lines of code so the user know the options they can choose 
        {
            try
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
                throw new Exception();
            }
            catch (Exception) // this catches an erronious input and makes the user input again
            {
                Options();
            }
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
            try
            {
                if (User == 1) // this checks to see if the users data is the same as the users input 
                {
                    UserOptions(Net_1_256, Net_256_size, Net_256_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                if (User == 2) // this checks to see if the users data is the same as the users input 
                {
                    UserOptions(Net_2_256, Net_256_size, Net_256_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                if (User == 3) // this checks to see if the users data is the same as the users input 
                {
                    UserOptions(Net_3_256, Net_256_size, Net_256_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other
                }
                if (User == 4) // this checks to see if the users data is the same as the users input 
                {
                    UserOptions(Net_1_2048, Net_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                if (User == 5) // this checks to see if the users data is the same as the users input 
                {
                    UserOptions(Net_2_2048, Net_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                if (User == 6) // this checks to see if the users data is the same as the users input 
                {
                    UserOptions(Net_3_2048, Net_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                if (User == 7) // this checks to see if the users data is the same as the users input 
                {
                    String[] Merged_256 = Net_1_256.Concat(Net_3_256).ToArray(); int Merged_256_size = Merged_256.Length; // this merges the networks together
                    UserOptions(Merged_256, Merged_256_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                if (User == 8) // this checks to see if the users data is the same as the users input 
                {
                    String[] Merged_2048 = Net_1_2048.Concat(Net_3_2048).ToArray(); int Merged_2048_size = Merged_2048.Length; // this merges the networks together
                    UserOptions(Merged_2048, Merged_2048_size, Net_2048_range); // this calls user options and brings through the networks, size and range of the arrays to be used in other aspects 
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException) // this redos the selection if input is a string or other
            {
                Console.WriteLine("That is invalid input please try again");
                UserChoices(); // this calls the program again
            }

        }
        static void UserOptions(string[] Network, int size, int range) // this is how the user selects the type of algorithm they would like to use 
        {
            Console.WriteLine("Options");
            Console.WriteLine("----------------");
            Console.WriteLine("Sort");
            Console.WriteLine("1:Bubble sort");
            Console.WriteLine("2:Insertion sort");
            Console.WriteLine("3:Selection sort");
            Console.WriteLine("----------------");
            Console.WriteLine("Search");
            Console.WriteLine("4:Linear");
            Console.WriteLine("5:Binary");
            Console.WriteLine("----------------");
            Console.WriteLine("Press enter to go back!");
            Console.WriteLine("----------------");
            var User = Console.ReadLine(); // this reads the users input
            int user = Convert.ToInt32(User);
            try
            {
                if (user == 1) // this checks if the users input martches a choice
                {
                    BubbleSort(Network, size, range); // this pushes the network, size and range through into an algorithm
                }
                else if (user == 2) // this checks if the users input martches a choice
                {
                    InsertionSort(Network, size, range); // this pushes the network, size and range through into an algorithm
                }
                else if (user == 3) // this checks if the users input martches a choice
                {
                    SelectionSort(Network, size, range); // this pushes the network, size and range through into an algorithm
                }
                else if (user == 4) // this checks if the users input martches a choice
                {
                    LinearSearch(Network, size); // this pushes the network and size through into an algorithm
                }
                else if (user == 5) // this checks if the users input martches a choice
                {
                    BinarySearch(Network, size); // this pushes the network and size through into an algorithm
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception) // if the user types something that isnt a string
            {
                UserOptions(Network, size, range); // it repeats the selection
            }
           //try // this catches an erronious input and makes the user input again
           //{
           //    if (user > 5 || user == 0)
           //    {
           //        throw new ArgumentOutOfRangeException(nameof(User));
           //    }
           //}
           //catch (ArgumentOutOfRangeException) // this catches an erronious input and makes the user input again
           //{
           //    Console.WriteLine("Your number was out of range!");
           //    UserOptions(Network, size, range);
           //}
        }
    }
}
