// Express Shipping Cost Estimator
// Developer: Michael Chen
// Version: 1.0.3
using System;

namespace ShippingServices
{
    public class ExpressCalculator
    {
        static void Main(string[] args)
        {
            // Show program introduction
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Input validation for package weight
            Console.WriteLine("Please enter the package weight:");
            double parcelWeight = Convert.ToDouble(Console.ReadLine());

            // Maximum weight check
            if (parcelWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Gather package dimensions
            Console.WriteLine("Please enter the package width:");
            double parcelWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double parcelHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double parcelLength = Convert.ToDouble(Console.ReadLine());

            // Calculate combined dimensions
            double combinedSize = parcelWidth + parcelHeight + parcelLength;

            // Maximum size check
            if (combinedSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate shipping rate
            // Rate formula: (width * height * length * weight) / 100
            double shippingRate = (parcelWidth * parcelHeight * parcelLength * parcelWeight) / 100;

            // Output the shipping cost
            Console.WriteLine($"Your estimated total for shipping this package is: ${shippingRate:F2}");
            Console.WriteLine("Thank you!");
        }
    }
} 