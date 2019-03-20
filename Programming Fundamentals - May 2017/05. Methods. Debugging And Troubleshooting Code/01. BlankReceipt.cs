using System;

namespace BlankReceipt
{
    class Program
    {
        static void ReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni"); // u00A9 - Copyright sign
        }
        static void ReceiptBody()
        {
            Console.WriteLine("Charget to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void ReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintReceipt()
        {
            ReceiptHeader();
            ReceiptBody();
            ReceiptFooter();
        }
        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
