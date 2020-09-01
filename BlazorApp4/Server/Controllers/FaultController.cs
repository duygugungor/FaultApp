using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using BlazorApp4.Server.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using BlazorApp4.Shared.Models;


namespace BlazorApp4.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FaultController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public FaultController(ApplicationDBContext context) => _context = context;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var faults = await _context.Faults.ToListAsync();

            //var _fault = new Fault();
            //var _faults = new List<Fault>();
            //_fault = _context.Faults.Where(p => p.Id == 1).SingleOrDefault();
            //_faults = _context.Faults.ToList();
            //_context.Entry(_fault).State = EntityState.Added;
            //_context.Entry(_fault).State = EntityState.Modified;
            //_context.Entry(_fault).State = EntityState.Deleted;
            //_context.SaveChanges();

            return Ok(faults);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var fault = await GetFaults().FirstOrDefaultAsync(a => a.Id == id);
            return Ok(fault);
        }

        [HttpGet]
        [Route("query")] // <- no route parameters specified
        public IActionResult filterByParameters([FromQuery] long afterTimestamp,
                                              [FromQuery] long beforeTimestamp)
        {

            DateTime after = DateTimeOffset.FromUnixTimeMilliseconds(afterTimestamp).DateTime;
            DateTime before = DateTimeOffset.FromUnixTimeMilliseconds(beforeTimestamp).DateTime;
            // will be matched by e.g.
            // /api/1.0/availabilities?xCoordinate=34.3444&yCoordinate=66.3422

            //var _fault = new Fault();
            var _faults = new List<Fault>();
            //_fault = _context.Faults.Where(p => p.Id == 1).SingleOrDefault();
            _faults = _context.Faults.Where(p => DateTime.Compare(p.CreatedTime, after) > 0 && DateTime.Compare(p.CreatedTime, before) < 0).ToList();
            //_context.Entry(_fault).State = EntityState.Added;
            //_context.Entry(_fault).State = EntityState.Modified;
            //_context.Entry(_fault).State = EntityState.Deleted;
            //_context.SaveChanges();
            return Ok(_faults);

            //.Start.Date >= startDate.Date
            //            where a.Start.Date <= endDate.Date



        }

        private DbSet<Fault> GetFaults()
        {
            return _context.Faults;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Fault fault)
        {
            _context.Add(fault);
            await _context.SaveChangesAsync();
            return Ok(fault.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Fault fault)
        {
            _context.Entry(fault).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditFault(int id, Fault fault)
        {
            if (id != fault.Id)
            {
                return BadRequest();
            }
            _context.Entry(fault).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();


        


        }






        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var fault = new Fault { Id = id };
            _context.Remove(fault);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        protected DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            return dtDateTime;
        }
    }
}
