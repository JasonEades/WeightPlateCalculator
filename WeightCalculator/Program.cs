namespace WeightCalculator
{
    public enum WeightUnit
    {
        Kilogram,
        Pound
    }

    public enum Plates
    {
        Plates_55,
        Plates_45,
        Plates_35,
        Plates_25,
        Plates_15,
        Plates_10,
        Plates_5,
        Plates_2_5
    }

    public class WeightPairInventory
    {
        public Dictionary<Plates, int> Inventory { get; set; } = new Dictionary<Plates, int>();
    }

    public class WeightCalculatorService
    {
        private readonly double _barWeight;
        private readonly WeightPairInventory _inventory;
        public WeightCalculatorService(double barWeight, WeightPairInventory inventory)
        {
            _barWeight = barWeight;
            _inventory = inventory;
        }

        public Dictionary<Plates, int> CalculateWeights(double target)
        {
            var roundedTarget = Math.Round(target / 5.0) * 5;
            var totalMinusBar = roundedTarget - _barWeight;
            var halfWeight = totalMinusBar / 2;

            var platesRequired = new Dictionary<Plates, int>();
            bool isComplete = false;
            double workingAmt = halfWeight;

            var workingInventory = new Dictionary<Plates, int>(_inventory.Inventory);

            while (!isComplete)
            {
                if (workingAmt >= 55 && (workingInventory.ContainsKey(Plates.Plates_55) && workingInventory[Plates.Plates_55] > 0))
                {
                    platesRequired[Plates.Plates_55] = platesRequired.ContainsKey(Plates.Plates_55) ? platesRequired[Plates.Plates_55] + 1 : 1;
                    workingAmt -= 55;
                    workingInventory[Plates.Plates_55] -= 1;
                    continue;
                }
                else if (workingAmt >= 45 && (workingInventory.ContainsKey(Plates.Plates_45) && workingInventory[Plates.Plates_45] > 0))
                {
                    platesRequired[Plates.Plates_45] = platesRequired.ContainsKey(Plates.Plates_45) ? platesRequired[Plates.Plates_45] + 1 : 1;
                    workingAmt -= 45;
                    workingInventory[Plates.Plates_45] -= 1;
                    continue;
                }
                else if (workingAmt >= 35 && (workingInventory.ContainsKey(Plates.Plates_35) && workingInventory[Plates.Plates_35] > 0))
                {
                    platesRequired[Plates.Plates_35] = platesRequired.ContainsKey(Plates.Plates_35) ? platesRequired[Plates.Plates_35] + 1 : 1;
                    workingAmt -= 35;
                    workingInventory[Plates.Plates_35] -= 1;
                    continue;
                }
                else if (workingAmt >= 25 && (workingInventory.ContainsKey(Plates.Plates_25) && workingInventory[Plates.Plates_25] > 0))
                {
                    platesRequired[Plates.Plates_25] = platesRequired.ContainsKey(Plates.Plates_25) ? platesRequired[Plates.Plates_25] + 1 : 1;
                    workingAmt -= 25;
                    workingInventory[Plates.Plates_25] -= 1;
                    continue;
                }
                else if (workingAmt >= 15 && (workingInventory.ContainsKey(Plates.Plates_15) && workingInventory[Plates.Plates_15] > 0))
                {
                    platesRequired[Plates.Plates_15] = platesRequired.ContainsKey(Plates.Plates_15) ? platesRequired[Plates.Plates_15] + 1 : 1;
                    workingAmt -= 15;
                    workingInventory[Plates.Plates_15] -= 1;
                    continue;
                }
                else if (workingAmt >= 10 && (workingInventory.ContainsKey(Plates.Plates_10) && workingInventory[Plates.Plates_10] > 0))
                {
                    platesRequired[Plates.Plates_10] = platesRequired.ContainsKey(Plates.Plates_10) ? platesRequired[Plates.Plates_10] + 1 : 1;
                    workingAmt -= 10;
                    workingInventory[Plates.Plates_10] -= 1;
                    continue;
                }
                else if (workingAmt >= 5 && (workingInventory.ContainsKey(Plates.Plates_5) && workingInventory[Plates.Plates_5] > 0))
                {
                    platesRequired[Plates.Plates_5] = platesRequired.ContainsKey(Plates.Plates_5) ? platesRequired[Plates.Plates_5] + 1 : 1;
                    workingAmt -= 5;
                    workingInventory[Plates.Plates_5] -= 1;
                    continue;
                }
                else if (workingAmt >= 2.5 && (workingInventory.ContainsKey(Plates.Plates_2_5) && workingInventory[Plates.Plates_2_5] > 0))
                {
                    platesRequired[Plates.Plates_2_5] = platesRequired.ContainsKey(Plates.Plates_2_5) ? platesRequired[Plates.Plates_2_5] + 1 : 1;
                    workingAmt -= 2.5;
                    workingInventory[Plates.Plates_2_5] -= 1;
                    continue;
                }
                else
                {
                    isComplete = true;
                }
            }

            return platesRequired;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                var myWeightInventory = new WeightPairInventory();
                myWeightInventory.Inventory.Add(Plates.Plates_55, 0);
                myWeightInventory.Inventory.Add(Plates.Plates_45, 2);
                myWeightInventory.Inventory.Add(Plates.Plates_35, 1);
                myWeightInventory.Inventory.Add(Plates.Plates_25, 2);
                myWeightInventory.Inventory.Add(Plates.Plates_15, 1);
                myWeightInventory.Inventory.Add(Plates.Plates_10, 2);
                myWeightInventory.Inventory.Add(Plates.Plates_5, 2);
                myWeightInventory.Inventory.Add(Plates.Plates_2_5, 3);
                var weightCalculatorService = new WeightCalculatorService(45, myWeightInventory);

                var result = weightCalculatorService.CalculateWeights(50);

                foreach (var kvp in result)
                {
                    Console.WriteLine($"Add these to the bar: {kvp.Key} : {kvp.Value}");
                }

                Console.ReadLine();

            }
        }
    }
}
