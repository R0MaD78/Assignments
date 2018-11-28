using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParkingFee_Assignment___P3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Adrian Romeo
               24/11/2018
               assigment parkingFee3 */
            
            //set constants
            const decimal HOURLY_RATE = 2.5m;
            const decimal MAX_FEE = 20.00m;
            const int MAX_ARRAY_SIZE = 50;
            
            //declare variables
            decimal parkingFee;
            decimal totalFee = 0;
            decimal averageParkingFee = 0;
            
            //copyright
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" ParkingFee3 program developed by: Adrian Romeo");
            Console.WriteLine("-----------------------------------------------\n");
            
            /*input - read data from "hours.txt" file and stored into memory positions by creating an array to store the 50 entries
            (assigned a constant to make the program adaptable for easy upgradeability) and using StreamReader class to read line by line 
            and assign their value to an array position until line value is null, then close the file to avoid errors
             */ 
            int[] hoursArray = new int[MAX_ARRAY_SIZE]; //array
            StreamReader fileSR = new StreamReader("hours.txt"); //file the entries are readed from
            int counter = 0; //array counter
            string line = ""; //declare an empty line
            line = fileSR.ReadLine(); //start reading file
            while (line != null) //while not end of file
            {
                hoursArray[counter] = int.Parse(line); //convert string into int and assign it to array position
                counter = counter + 1;
                line = fileSR.ReadLine(); //continue reading next line
            }
            fileSR.Close(); //finished reading file

            StreamWriter fileSW = new StreamWriter("hours.txt");
            for (int i = 0; i < counter; i++)
            {
                parkingFee = hoursArray[i] * HOURLY_RATE;
                if (parkingFee >= MAX_FEE) //calculates parking fee by multiplying hours by the hourly rate, then compares to MAX_FEE as the maximum value
                {
                    parkingFee = MAX_FEE;
                }
                totalFee = totalFee + parkingFee; //adding all parkingFee values
                averageParkingFee = totalFee / MAX_ARRAY_SIZE; //formula to calculate average
                fileSW.WriteLine("{0},{1}", hoursArray[i], parkingFee.ToString("N2"));  //writes into text file
            }
            fileSW.Close(); //finished writting to file
            //screen output
            Console.WriteLine();
            Console.WriteLine("Average parking fee: {0}", averageParkingFee.ToString("N2"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
