using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain;
using WebApi.Model;

namespace WebApi.Controllers
{
    /// <summary>
    /// Handles all crud action vehicle's realted
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private IVehicleRepository _repository;

        public VehiclesController(IVehicleRepository repo)
        {
            _repository = repo;
        }

        [HttpGet("plain")]
        public IEnumerable<Vehicle> Get()
        {
            var vehicles = _repository.Load();

            return vehicles;
        }

        [HttpGet("object")]
        public ActionResult GetX()
        {
            var vehicles = _repository.Load();

            return Ok(vehicles);
        }

        [HttpGet("{id}", Name = "Get")] // url: api/Vehicles/15
        public ActionResult Get(int id)
        {
            var vehicle = _repository.Get(id);

            if (vehicle == null)
            { 
                return NotFound();
            }

            return Ok(vehicle);
        }

        [HttpPost]
        public ObjectResult Create([FromBody] VehicleCreateRequest newItem)
        {
            var vehicle = _repository.Add(newItem.ToDomain());

            return Ok(vehicle);
        }

        [HttpPost("hiddenCreate")]
        public ObjectResult HiddenCreate([FromBody] string newItem)
        {
            return Ok("nothing");
        }

        // PUT: api/Crud/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
