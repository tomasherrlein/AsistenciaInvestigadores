using System.Security.Cryptography.X509Certificates;
using ApplicationBussines;
using Data;
using Entities;
using Models;

namespace Repository
{
    public class InvestigadorRepository : IRepository<Investigador>
    {

        public InvestigadorRepository(AppDbContext)

        public async Task AddAsync(Investigador investigador)
        {
            var investigadorModel = new InvestigadorModel()
            {
                Nombre = investigador.Nombre
            };

            
        }

        public async Task<IEnumerable<Investigador>> GetAllAsync()
        {
            
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
