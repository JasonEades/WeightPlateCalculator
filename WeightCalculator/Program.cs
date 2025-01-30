using System.Numerics;
using WeightPlateCalculator.Shared;

namespace WeightCalculator
{
        internal class Program
        {
            static void Main(string[] args)
            {
                var myWeightInventory = new WeightPairInventory();
                myWeightInventory.Inventory.Add(Plates.PlatePairs_55, 0);
                myWeightInventory.Inventory.Add(Plates.PlatePairs_45, 2);
                myWeightInventory.Inventory.Add(Plates.PlatePairs_35, 1);
                myWeightInventory.Inventory.Add(Plates.PlatePairs_25, 2);
                myWeightInventory.Inventory.Add(Plates.PlatePairs_15, 1);
                myWeightInventory.Inventory.Add(Plates.PlatePairs_10, 2);
                myWeightInventory.Inventory.Add(Plates.PlatePairs_5, 2);
                myWeightInventory.Inventory.Add(Plates.PlatePairs_2_5, 3);
                var weightCalculatorService = new WeightPlateCalculatorService();

                var result = weightCalculatorService.CalculateWeights(45, myWeightInventory, 50);

                foreach (var kvp in result)
                {
                    Console.WriteLine($"Add these to the bar: {kvp.Key} : {kvp.Value}");
                }

                Console.ReadLine();

            }
        }
    
}
