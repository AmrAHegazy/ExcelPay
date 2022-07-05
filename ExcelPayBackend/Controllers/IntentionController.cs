using AutoMapper;
using ExcelPayBackend.context;
using ExcelPayBackend.Dtos;
using ExcelPayBackend.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExcelPayBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntentionController : ControllerBase
    {
        private readonly Context _ctx;
        private readonly IMapper mapper;

        public IntentionController(Context ctx,IMapper mapper)
        {
            _ctx = ctx;
            this.mapper = mapper;
        }
        [HttpPost]
        public ActionResult<IntentionDto> CreateIntention([FromForm]string secretKey,[FromForm]int amount)
        {
            var merchant = _ctx.Merchants.Where(m => m.SecretKey == secretKey).FirstOrDefault();
            if(merchant == null)
            {
                return BadRequest();
            }
            var intention = new Intention
            {
                Amount = amount,
                Merchant = merchant,
                ClientSecret = new ClientSecret
                {
                    Id = Guid.NewGuid(),
                    CreationDate = DateTime.Now,
                    IsUsed = false
                }

            };
            _ctx.Intentions.Add(intention);
            
            
            _ctx.SaveChanges();
            var intentionDto = this.mapper.Map<Intention, IntentionDto>(intention);
            return Ok(intentionDto);

        }
    }
}
