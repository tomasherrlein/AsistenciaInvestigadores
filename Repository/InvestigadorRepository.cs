using System.Security.Cryptography.X509Certificates;
using ApplicationBussines;
using ApplicationBussines.Mappers;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class InvestigadorRepository : IInvestigadorRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper<InvestigadorModel, Investigador> _mapperToEntity;

        public InvestigadorRepository(AppDbContext dbContext, 
            IMapper<InvestigadorModel, Investigador> mapperToEntity)
        {
            _dbContext = dbContext;
            _mapperToEntity = mapperToEntity;
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
            var investigadoresModels = await _dbContext.Investigadores.Include(i => i.Iddepartamentos).ToListAsync();
            var investigadores = new List<Investigador>();
            
            foreach (var i in investigadoresModels) 
            {
                investigadores.Add(_mapperToEntity.Map(i));
            }

            return investigadores; 
        }

        public async Task<Investigador> GetByIdAsync(int id)
        {
            var investigadorModel = await _dbContext.Investigadores.FindAsync(id);

            return new Investigador
            {
                IdInvestigador = investigadorModel.Idinvestigador,
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

        public async Task<IEnumerable<Investigador>> GetAllByDepartamentoNombreAsync(string nombreDepartamento)
        {
            var investigadoresModels = await _dbContext.Investigadores
                                    .Include(i => i.Iddepartamentos)
                                    .Where(i => i.Iddepartamentos.Any(d => d.Nombre == nombreDepartamento))
                                    .ToListAsync();

            var investigadores = new List<Investigador>();

            foreach (var i in investigadoresModels)
            {
                investigadores.Add(_mapperToEntity.Map(i));
            }

            return investigadores;
        }
    }
}
