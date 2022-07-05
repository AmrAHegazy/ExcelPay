using MerchantBackend.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MerchantBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class merchantController : ControllerBase
    {
        private readonly HttpClient httpClient = new HttpClient();

        public merchantController()
        {
            
        }
        [HttpGet]
        public async Task<IActionResult> CreateIntention(int amount)
        {
            string secretKey = "MIIBOwIBAAJBAKjD83Rq4DuQ0dczyLhcS94ev5vVoYEet1gCj21ZvnWbENt8eMHmyB2mAhbkSgDf3JXM5upBJtMJeV0rvNFznZ8CAwEAAQJAfzad+H5rolrq4pZFUjs4cSmqc5RYVpVJzQy5AsuoVssc6H6OHDpSaGTimR45d3yz0e6VgBLp4i4+bSj6TyJN6QIhAPDV3aaxMaQKLUQj6i2egCnjYn91/pwSXOhNZemgGnJVAiEAs2RbV3AHnEaiAHNlI3g8c/7isYtMHRAirb4J84ySDCMCIQC3bItmO6ptH3seXKQsnn1Kae5I2ZtTTwEHxHsMFm5OCQIhAI7ORjR992D9jXtEYW/yCFXiwv3JQQcl0CV1UiCyd5T3AiBdDPt0gotUwgI7MMdpaK0rmTiNlZZpkAGH+5Cu94XIZA==";
            httpClient.BaseAddress = new System.Uri("https://localhost:5001/");
            var content = new FormUrlEncodedContent(new[]
{
                new KeyValuePair<string, string>("amount", amount.ToString()),
                new KeyValuePair<string, string>("secretKey", secretKey)


            });
            var result = await httpClient.PostAsync("api/Intention", content);
            if (result.IsSuccessStatusCode)
            {
                return Ok(await result.Content.ReadAsStringAsync());
            }
            else
            {
                return BadRequest(await result.Content.ReadAsStringAsync());
            }
        }

    }
}
