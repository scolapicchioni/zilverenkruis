using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa01.Models {
    public class AddressesRepository : IAddressesRepository {
        private readonly ApplicationContext _context;

        public AddressesRepository(ApplicationContext context) {
            _context = context;
        }

        public async Task<List<Address>> GetAll() {
            return await _context.Address.ToListAsync();
        }

        public async Task<List<Address>> GetAddressesByPersonId(int personId) {
            return await _context.
                Address.
                Where(a=>a.PersonId==personId)
                .ToListAsync();
        }

        public async Task<Address> GetAddressById(int id) {
            return await _context.Address
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Create(Address address) {
            _context.Add(address);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Address address) {
            try {
                _context.Update(address);
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!AddressExists(address.Id)) {
                    throw new NotFoundException();
                } else {
                    throw new UpdateException();
                }
            }
        }

        public async Task Delete(int id) {
            var address = await _context.Address.FindAsync(id);
            _context.Address.Remove(address);
            await _context.SaveChangesAsync();
        }

        public bool AddressExists(int id) {
            return _context.Address.Any(e => e.Id == id);
        }
    }
}
