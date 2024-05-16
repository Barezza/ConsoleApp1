using System;

namespace SimplePaymentProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Payment Processor!");

            // Collect user information
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter the payment amount: ");
            string amountInput = Console.ReadLine();
            decimal paymentAmount;
            while (!decimal.TryParse(amountInput, out paymentAmount))
            {
                Console.Write("Invalid amount. Please enter a valid payment amount: ");
                amountInput = Console.ReadLine();
            }

            // Process payment
            Console.WriteLine($"Processing payment of {paymentAmount:C} for {userName}...");
            bool paymentSuccess = ProcessPayment(userName, paymentAmount);

            if (paymentSuccess)
            {
                Console.WriteLine("Payment processed successfully!");
            }
            else
            {
                Console.WriteLine("Payment failed. Please try again.");
            }

            Console.WriteLine("Thank you for using the Simple Payment Processor!");
        }

        static bool ProcessPayment(string userName, decimal amount)
        {
            // Simulate payment processing logic
            // In a real application, integrate with a payment gateway here
            Console.WriteLine($"Simulating payment processing for {userName}...");
            return true; // Simulate a successful payment
        }
    }
}
