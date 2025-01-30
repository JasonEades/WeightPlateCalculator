using Microsoft.AspNetCore.Mvc;
using WeightPlateCalculator.Shared;

namespace WeightPlateCalculator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeightPlateCalculatorController : ControllerBase
    {
        private readonly ILogger<WeightPlateCalculatorController> _logger;
        private readonly WeightPlateCalculatorService _service;

        public WeightPlateCalculatorController(ILogger<WeightPlateCalculatorController> logger, WeightPlateCalculatorService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post(WeightPlateCalculatorParams @params)
        {
            try
            {
                var result = _service.CalculateWeights(@params.BarWeight, @params.Inventory, @params.TargetWeight);

                if (result == null)
                {
                    return null;
                }

                return Ok(result);
            }
            catch (NotEnoughPlatesException)
            {
                return BadRequest("Not enough plates in inventory to reach target weight");
            }
        }
    }
}
