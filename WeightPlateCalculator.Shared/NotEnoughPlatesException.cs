using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightPlateCalculator.Shared
{
    public class NotEnoughPlatesException : Exception
    {
        public NotEnoughPlatesException() : base("Not enough plates to reach target weight")
        {
        }
    }
}
