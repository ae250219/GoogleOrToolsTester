using Google.OrTools.ConstraintSolver;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using static Google.OrTools.LinearSolver.Solver;

namespace GoogleOrToolsTesterDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolverController : ControllerBase
    {

        private readonly ILogger<SolverController> _logger;

        public SolverController(ILogger<SolverController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var solver = new Solver("MyMax");
            }
            catch (System.Exception ex)
            {
                _logger.LogCritical(ex, "failed create solver");
                throw;
            }
            return Ok("solver created");
        }
    }
}
