using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightPlateCalculator.Shared
{
    /// <summary>
    /// Represents the unit of weight
    /// </summary>
    public enum WeightUnit
    {
        /// <summary>
        /// Kilogram
        /// </summary>
        Kilogram,

        /// <summary>
        /// Pound
        /// </summary>
        Pound
    }

    public enum Plates
    {
        PlatePairs_55,
        PlatePairs_45,
        PlatePairs_35,
        PlatePairs_25,
        PlatePairs_15,
        PlatePairs_10,
        PlatePairs_5,
        PlatePairs_2_5
    }
}
