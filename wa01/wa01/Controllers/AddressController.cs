using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wa01.Models;

namespace wa01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressesRepository repo;

        public AddressController(IAddressesRepository repo) {
            this.repo = repo;
        }
        //GET api/Person/3/Address
        [HttpGet("/api/Person/{personId}/Address")]
        public async Task<List<Address>> GetAllAddressesOfAPerson(int personId) {
            List<Address> db = await repo.GetAddressesByPersonId(personId);
            return db.Where(a => a.PersonId == personId).ToList();
        }

        //GET api/Address/5
        [HttpGet("{id}",Name ="GetAddress")]
        public async Task<ActionResult<Address>> GetAddressById(int id) {
            Address address = await repo.GetAddressById(id);

            if (address == null) {
                return NotFound();
            }

            return address;
        }

        //POST api/Address
        [HttpPost]
        public async Task<IActionResult> Create(Address address) {
            //BadRequest if ModelState.Valid is false

            //add the item in the db
            await repo.Create(address);

            return CreatedAtRoute("GetAddress", new { id = address.Id }, address);
        }

        //PUT api/Address/2
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Address address) {
            //BadRequest if ModelState.Valid is false

            Address OldAddress = await repo.GetAddressById(id);

            if (OldAddress == null) {
                return NotFound();
            }

            //modify the item in the db
            await repo.Update(address);

            return NoContent();
        }

        //DELETE api/Address/2
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            Address OldAddress = await repo.GetAddressById(id);

            if (OldAddress == null) {
                return NotFound();
            }

            //delete the item in the db
            await repo.Delete(id);

            return NoContent();
        }
    }
}