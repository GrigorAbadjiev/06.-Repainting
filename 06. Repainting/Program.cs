using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int nylon = int.Parse(Console.ReadLine()) + 2;
            int paintInLiters = int.Parse(Console.ReadLine());
            double paintInLitersWhithBonus = paintInLiters + (paintInLiters * 0.1);
            int diluent = int.Parse(Console.ReadLine());
            int workingHouers = int.Parse(Console.ReadLine());
            // calculate
            double nylonPrice = nylon * 1.50;
            double paintPrice = paintInLitersWhithBonus * 14.50;
            double diluentPrice = diluent * 5.0;
            double totalPriceForMaterials = nylonPrice + paintPrice + diluentPrice + 0.40;
            double workersPay = totalPriceForMaterials * 0.3 * workingHouers;

            // output
            Console.WriteLine(totalPriceForMaterials + workersPay);
        }
    }
}
