using Microsoft.AspNetCore.Mvc;

namespace g1.dummy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DummyController : ControllerBase
    {
        private readonly ILogger<DummyController> _logger;

        public DummyController(ILogger<DummyController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDummyData")]
        public IEnumerable<Dummy> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Dummy
            {
                Date = DateTime.Now.AddDays(index),
                DummyText = "Dummy Text " + index
            })
            .ToArray();
        }
    }
}