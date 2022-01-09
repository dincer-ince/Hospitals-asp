using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using covid_backend.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace covid_backend.Controllers
{
    [Route("api/hospitals")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private hospitalContext _context;
        public HospitalController(hospitalContext context)
        {
            _context=context;
        }

        [HttpGet]
        public ActionResult GetHospitals(){


            return Ok(_context.Hospitals.ToList());
        }

        [HttpGet("a")]
        public ActionResult GetHospitalBrief(){

            var brief= _context.Hospitals.Select(x => new{
            fid=x.Fid,
            name=x.Name,}).Take(1000).ToList();

            return Ok(brief);
        }




        // [HttpGet("{id}")]
        // public async Task<ActionResult<Hospital>> gender(string id)
        // {
        //     //if koşulu yapabilirsin ama baski yok acikcasi cok da onemli degil sonucta websitesinde buynu kisitlicaz sikinti yok devam
        //     //var ilce = await _context.ilces.FindAsync(id);
        //     var genderlist = await _context.SqlGenders.Select(x=>new{
        //         //state=x.State,
        //         date=x.Date,
        //         gender=x.Gender,
        //         cases=x.Cases,
        //         deaths=x.Deaths,
        //         recovered=x.Recovered
        //     }).Where(x=> x.gender==id).ToListAsync();



        //     if (genderlist == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok(genderlist);
        // }
        
    }
}