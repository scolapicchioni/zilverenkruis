using System.Collections.Generic;
using System.Threading.Tasks;

namespace wa01.Models {
    public interface IAddressesRepository {
        bool AddressExists(int id);
        Task Create(Address address);
        Task Delete(int id);
        Task<Address> GetAddressById(int id);
        Task<List<Address>> GetAddressesByPersonId(int personId);
        Task<List<Address>> GetAll();
        Task Update(Address address);
    }
}