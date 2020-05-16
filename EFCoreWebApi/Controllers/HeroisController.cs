using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreWebApi.Data;
using EFCoreWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroisController : ControllerBase
    {

        HeroiContext _context;

        public HeroisController(HeroiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Herois.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Heroi h)
        {
            _context.Add(h);
            _context.SaveChanges();
            return new ObjectResult(h);
        }
    }
}