using System.Security.Cryptography.X509Certificates;
using ApplicationBussines;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class InvestigadorRepository : IRepository<Investigador>
    {
        private readonly AppDbContext _dbContext;

        public InvestigadorRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Investigador investigador)
        {
            var investigadorModel = new InvestigadorModel()
            {
                Nombre = investigador.Nombre
            };

            await _dbContext.AddAsync(investigadorModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Investigador>> GetAllAsync()
        {
            return await _dbContext.Investigadores.Select(i => new Investigador
                {
                    Nombre = i.Nombre
                }).ToListAsync();
        }

        public async Task<Investigador> GetByIdAsync(int id)
        {
            var investigadorModel = await _dbContext.Investigadores.FindAsync(id);

            return new Investigador
            {
                IdInvestigador = investigadorModel.IDInvestigador,
                Nombre = investigadorModel.Nombre
            };
        }

        public async Task EditAsync(Investigador investigador)
        {
            var investigadorModel = await _dbContext.Investigadores.FindAsync(investigador.IdInvestigador);

            investigadorModel.Nombre = investigador.Nombre;
            _dbContext.Entry(investigadorModel).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var InvestigadorModel = await _dbContext.Investigadores.FindAsync(id);
            _dbContext.Investigadores.Remove(InvestigadorModel);
            await _dbContext.SaveChangesAsync();
        }

    }
}
