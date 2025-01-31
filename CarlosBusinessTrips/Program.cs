using System;




namespace CarlosBusinessTrips
{
    class Trips
    {
        static void Main()
        {


            Console.WriteLine("Number of trips to Calgary:");
            int tripsCalgary = int.Parse(Console.ReadLine()); 

            if (tripsCalgary <= 0) // The input of number Trips calgary should be positive not negative
            {
                Console.WriteLine("Invalid input. Please must enter a positive number.");
                return;
            }


            Console.WriteLine("Number of trips to Vancouver:");
            int tripsVancouver = int.Parse(Console.ReadLine());

            if (tripsVancouver <= 0) // The input of number Trips Vancouver should be positive not negative
            {
                Console.WriteLine("Invalid input. Please must enter a positive number.");
                return;
            }


            Console.WriteLine("Number of trips to Montreal:");
            int tripsMontreal = int.Parse(Console.ReadLine());

            if (tripsMontreal <= 0) // The input of number Trips Montreal should be positive not negative
            {
                Console.WriteLine("Invalid input. Please must enter a positive number.");
                return;
            }


            // Calculate total and average with the round-trip cost because every time he needed to return to his native town before making the next trip.
            int priceCalgary = 1350 * 2;
            int priceVancouver = 1500 * 2;
            int priceMontreal = 575 * 2;


            int totalCost = (tripsVancouver * priceVancouver) + (tripsCalgary * priceCalgary) + 
                            (tripsMontreal * priceMontreal);


            int totalTrips = tripsCalgary + tripsVancouver + tripsMontreal;
            int averageCost = totalCost / totalTrips;


            // Showing results
            Console.WriteLine("Total spent money: $" + totalCost);
            Console.WriteLine("Average cost per each trip: $" + averageCost);


            Console.ReadLine();
        }
    }
}