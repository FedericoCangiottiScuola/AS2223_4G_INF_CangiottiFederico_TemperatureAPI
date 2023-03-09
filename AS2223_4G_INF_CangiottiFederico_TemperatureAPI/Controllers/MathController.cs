using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_CangiottiFederico_TemperatureAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/")]
    public class MathController : Controller
    {
        [HttpGet("GetAddition")]
        public JsonResult GetAddition(int n1, int n2)
        {
            MathResult outcome = new(Status.OK);
            return Json(new
            {
                result = n1 + n2,
                outcome,
            });
        }

        [HttpGet("GetMultiply")]
        public JsonResult GetMultiply(double n1, double n2)
        {
            MathResult outcome = new(Status.OK);
            return Json(new
            {
                result = n1 * n2,
                outcome,
            });
        }

        [HttpGet("GetDivision")]
        public JsonResult GetDivision(double numerator, double denominator)
        {
            MathResult outcome;

            if (denominator == 0)
            {
                outcome = new(Status.ERROR, "The denominator cannot be zero");
                return Json(new
                {
                    result = 0,
                    outcome,
                });
            }

            outcome = new(Status.OK);
            return Json(new
            {
                result = numerator / denominator,
                outcome,
            });
        }
    }
}
