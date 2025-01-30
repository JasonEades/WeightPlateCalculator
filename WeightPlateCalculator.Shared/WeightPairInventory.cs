using System.Numerics;

namespace WeightPlateCalculator.Shared
{
    public class WeightPairInventory
    {
        public Dictionary<Plates, int> Inventory { get; set; } = new Dictionary<Plates, int>();
    }
}
