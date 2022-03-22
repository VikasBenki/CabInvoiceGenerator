using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Cabinvoice generataor problem");
            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator(RideType.NORMAL);
            Console.WriteLine(cabInvoiceGenerator.CalculateFare(10, 15));         
            Console.ReadLine();
        }
    }
}
