using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Name: David Piatt
 * 
 * **/

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double costPerHour = 35.75;
            const int feetPerHour = 40;

            Console.WriteLine("David Piatt's Flooring Cost Estimator: ");
            //new line
            Console.Write(" ");

            //get floor length
            Console.Write("Enter floor length: ");
            String floorLengthString = Console.ReadLine();
            int floorLength = Convert.ToInt32(floorLengthString);

            //get floor width
            Console.Write("Enter floor width: ");
            String floorWidthString = Console.ReadLine();
            int floorWidth = Convert.ToInt32(floorWidthString);

            //get floor cost per sqft
            Console.Write("Enter cost per sqft: ");
            String costString = Console.ReadLine();
            double cost = Convert.ToDouble(costString);

            //floor size
            int floorSize = floorWidth * floorLength;

            //calculate the cost of materials

            double costOfMaterials = floorLength * floorWidth * cost;
            String formattedCostString = costOfMaterials.ToString("C");
            
            //calculate the hours needed to install floor
            double time = (double)(floorLength * floorWidth) / feetPerHour;
            String timeString = time.ToString("N2");

            //calculate the labor cost of installation 
            double labor = time * costPerHour;

            //calculate total cost = material cost + labor cost
            double totalCost = costOfMaterials + labor;
            String formattedTotalCostString = totalCost.ToString("C");

            Console.Write("For a total floor size of {0} ft " +
                "the flooring cost is: {1} " +
                "It will take {2} hours to install the floor at a " +
                "total cost of {3}", floorSize, formattedCostString, timeString, formattedTotalCostString);
            Console.ReadLine();
        }
    }
}
