using System.Collections.Generic;
using System.Threading.Tasks;

namespace wa01.Models {
    public interface IPeopleRepository {
        Task Create(Person person);
        Task Delete(int id);
        Task<List<Person>> GetAll();
        Task<Person> GetPersonById(int id);
        bool PersonExists(int id);
        Task Update(Person person);
    }
}