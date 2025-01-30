namespace WeightPlateCalculator.Shared
{
    public class WeightPlateCalculatorService
    {
        public Dictionary<Plates, int> CalculateWeights(double barWeight, WeightPairInventory inventory, double target)
        {
            var roundedTarget = Math.Round(target / 5.0) * 5;
            var totalMinusBar = roundedTarget - barWeight;
            var halfWeight = totalMinusBar / 2;

            var platesRequired = new Dictionary<Plates, int>();
            bool isComplete = false;
            double workingAmt = halfWeight;

            var workingInventory = new Dictionary<Plates, int>(inventory.Inventory);

            while (!isComplete)
            {
                if (workingAmt >= 55 && (workingInventory.ContainsKey(Plates.PlatePairs_55) && workingInventory[Plates.PlatePairs_55] > 0))
                {
                    platesRequired[Plates.PlatePairs_55] = platesRequired.ContainsKey(Plates.PlatePairs_55) ? platesRequired[Plates.PlatePairs_55] + 1 : 1;
                    workingAmt -= 55;
                    workingInventory[Plates.PlatePairs_55] -= 1;
                    continue;
                }
                else if (workingAmt >= 45 && (workingInventory.ContainsKey(Plates.PlatePairs_45) && workingInventory[Plates.PlatePairs_45] > 0))
                {
                    platesRequired[Plates.PlatePairs_45] = platesRequired.ContainsKey(Plates.PlatePairs_45) ? platesRequired[Plates.PlatePairs_45] + 1 : 1;
                    workingAmt -= 45;
                    workingInventory[Plates.PlatePairs_45] -= 1;
                    continue;
                }
                else if (workingAmt >= 35 && (workingInventory.ContainsKey(Plates.PlatePairs_35) && workingInventory[Plates.PlatePairs_35] > 0))
                {
                    platesRequired[Plates.PlatePairs_35] = platesRequired.ContainsKey(Plates.PlatePairs_35) ? platesRequired[Plates.PlatePairs_35] + 1 : 1;
                    workingAmt -= 35;
                    workingInventory[Plates.PlatePairs_35] -= 1;
                    continue;
                }
                else if (workingAmt >= 25 && (workingInventory.ContainsKey(Plates.PlatePairs_25) && workingInventory[Plates.PlatePairs_25] > 0))
                {
                    platesRequired[Plates.PlatePairs_25] = platesRequired.ContainsKey(Plates.PlatePairs_25) ? platesRequired[Plates.PlatePairs_25] + 1 : 1;
                    workingAmt -= 25;
                    workingInventory[Plates.PlatePairs_25] -= 1;
                    continue;
                }
                else if (workingAmt >= 15 && (workingInventory.ContainsKey(Plates.PlatePairs_15) && workingInventory[Plates.PlatePairs_15] > 0))
                {
                    platesRequired[Plates.PlatePairs_15] = platesRequired.ContainsKey(Plates.PlatePairs_15) ? platesRequired[Plates.PlatePairs_15] + 1 : 1;
                    workingAmt -= 15;
                    workingInventory[Plates.PlatePairs_15] -= 1;
                    continue;
                }
                else if (workingAmt >= 10 && (workingInventory.ContainsKey(Plates.PlatePairs_10) && workingInventory[Plates.PlatePairs_10] > 0))
                {
                    platesRequired[Plates.PlatePairs_10] = platesRequired.ContainsKey(Plates.PlatePairs_10) ? platesRequired[Plates.PlatePairs_10] + 1 : 1;
                    workingAmt -= 10;
                    workingInventory[Plates.PlatePairs_10] -= 1;
                    continue;
                }
                else if (workingAmt >= 5 && (workingInventory.ContainsKey(Plates.PlatePairs_5) && workingInventory[Plates.PlatePairs_5] > 0))
                {
                    platesRequired[Plates.PlatePairs_5] = platesRequired.ContainsKey(Plates.PlatePairs_5) ? platesRequired[Plates.PlatePairs_5] + 1 : 1;
                    workingAmt -= 5;
                    workingInventory[Plates.PlatePairs_5] -= 1;
                    continue;
                }
                else if (workingAmt >= 2.5 && (workingInventory.ContainsKey(Plates.PlatePairs_2_5) && workingInventory[Plates.PlatePairs_2_5] > 0))
                {
                    platesRequired[Plates.PlatePairs_2_5] = platesRequired.ContainsKey(Plates.PlatePairs_2_5) ? platesRequired[Plates.PlatePairs_2_5] + 1 : 1;
                    workingAmt -= 2.5;
                    workingInventory[Plates.PlatePairs_2_5] -= 1;
                    continue;
                }
                else
                {
                    isComplete = true;
                }
            }

            if (isComplete && workingAmt > 0)
            {
                throw new NotEnoughPlatesException();
            }

            return platesRequired;
        }

    }
    
}
