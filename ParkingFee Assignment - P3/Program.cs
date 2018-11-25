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
            int hours = 0;
            decimal averageParkingFee = 0;
            //int counter = 0;
            //string line ="";
            //copyright
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" ParkingFee3 program developed by: Adrian Romeo");
            Console.WriteLine("-----------------------------------------------\n");
            //input - data read from hours.txt file and stored into array hours 
            int[] hoursArray = new int[MAX_ARRAY_SIZE]; //array
            StreamReader fileSR = new StreamReader("hours.txt"); //file the entries are readed from
            int counter = 0;
            string line = "";
            line = fileSR.ReadLine();
            while (line != null) //while not end of file
            {
                hoursArray[counter] = int.Parse(line);
                counter = counter++;
                line = fileSR.ReadLine();        
            }
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(hoursArray[i]);
            }
            fileSR.Close(); //finished reading file

            /*StreamWriter fileSW = new StreamWriter("hours.txt"); 
            for (int i = 0; i < counter; i++)
                {
                //fileSW.WriteLine(hoursArray[index]);
                parkingFee = hoursArray[i] * HOURLY_RATE;
                 if (parkingFee >= MAX_FEE) //calculates parking fee by multiplying hours by the hourly rate, then compares to MAX_FEE as the maximum value
                    {
                    parkingFee = MAX_FEE;
                    }
                fileSW.WriteLine("{0},{1}", hoursArray[i], parkingFee.ToString("N2"));
                }
            fileSW.Close();*/

            /*
            Console.WriteLine();
            for (int index = 0; index < counter; index++)
                {
                    hours = hours + hoursArray[index];
                }
            averageParkingFee = (decimal) hours / hoursArray.Length;
            fileSR.Close();
            //screen output
            Console.WriteLine("Average parking fee: {0}", averageParkingFee.ToString("N2"));*/
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
