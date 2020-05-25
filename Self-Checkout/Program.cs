using System;

namespace Self_Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Self-Checkout");
            Console.WriteLine("Hello, we are going to calculate your item totals.");

            Console.WriteLine("Please enter the price of the first item:");
            double firstItemPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the quantity:");
            int firstItemQuantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of the second item:");
            double secondItemPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the quantity:");
            int secondItemQuantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of the third item:");
            double thirdItemPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the quantity:");
            int thirdtemQuantity = Int32.Parse(Console.ReadLine());

            //calculate each item subtotal
            double firstItemSubtotal = firstItemPrice * firstItemQuantity;
            double secondItemSubtotal = secondItemPrice * secondItemQuantity;
            double thirdItemSubtotal = thirdItemPrice * thirdtemQuantity;
            //calculate subtotal of all items
            double subtotal = firstItemSubtotal + secondItemSubtotal + thirdItemSubtotal;
            //calculate tax on all items
            double tax = subtotal * 0.055;
            //calculate final total
            double total = subtotal + tax;

            Console.WriteLine($"Subtotal: {subtotal} Tax: {tax} Total: {total}");



        }
    }
}
