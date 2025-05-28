using ApplicationBussines;
using Entities;

namespace Repository
{
    public class InvestigadorRepository : IRepository<Investigador>
    {
        public async Task AddAsync(Investigador investigador)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Investigador>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Investigador> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(Investigador investigador)
        {
            throw new NotImplementedException();
        }

    }
}
