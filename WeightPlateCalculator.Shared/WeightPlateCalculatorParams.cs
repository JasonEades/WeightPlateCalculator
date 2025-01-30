namespace WeightPlateCalculator.Shared
{
    public class WeightPlateCalculatorParams
    {
        public WeightPlateCalculatorParams()
        {
            BarWeight = 45;
            WeightUnit = WeightUnit.Pound;
            TargetWeight = 0;
        }

        /// <summary>
        /// The weight of the barbell
        /// </summary>
        public double BarWeight { get; set; }

        /// <summary>
        /// The unit of meausrement for the weight. Default is pounds.
        /// </summary>
        public WeightUnit WeightUnit { get; set; } = WeightUnit.Pound;

        /// <summary>
        /// The target weight to calculate the plates for.
        /// </summary>
        public double TargetWeight { get; set; }

        /// <summary>
        /// The inventory of plates available to use.
        /// </summary>
        public WeightPairInventory Inventory { get; set; } = new WeightPairInventory();
    }
}
