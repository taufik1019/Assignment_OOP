using System;

namespace Reimbesrment_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Datareimbusrtment datareimbusrment = new Datareimbusrtment(1, "Taufik", "Spidol", 5, 15000);
            datareimbusrment.totalharga(5, 15000);

            Console.WriteLine();
        }
    }
}
