using Microsoft.AspNetCore.Mvc;

namespace LowestCommonMultiple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LCMController : ControllerBase
    {
        [HttpGet]
        public String LCM(int x, int y) {
            if (x >= 0 && y >= 0) {
                int i = 1;
                while ((x * i) % y != 0) {
                    i++;
                }
                return (x * i).ToString();
            }
            return "NaN";
        }
       
    }
}
