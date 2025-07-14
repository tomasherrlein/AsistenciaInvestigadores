using ApplicationBussines;
using ApplicationBussines.DTOs;
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
            var investigadorModel = new InvestigadorModel
            {
                Nombre = investigador.Nombre,
                Iddepartamentos = new List<DepartamentoModel>()
            };

            foreach (var departamento in investigador.Iddepartamentos)
            {
                var existingDepartamento = await _dbContext.Departamentos.FindAsync(departamento.IDDepartamento);
                if (existingDepartamento != null)
                {
                    investigadorModel.Iddepartamentos.Add(existingDepartamento);
                }
            }

            await _dbContext.Investigadores.AddAsync(investigadorModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Investigador>> GetAllAsync()
        {
            var investigadoresModels = await _dbContext.Investigadores
                                            .Include(i => i.Iddepartamentos)
                                            .Include(i => i.Asistencia)
                                            .Where(i => !i.Eliminado)
                                            .ToListAsync();

            var investigadores = new List<Investigador>();
            
            foreach (var i in investigadoresModels) 
            {
                investigadores.Add(_mapperToEntity.Map(i));
            }

            return investigadores; 
        }

        public async Task<Investigador> GetByIdAsync(int id)
        {
            var investigadorModel = await _dbContext.Investigadores
                .Include(i => i.Iddepartamentos)
                .FirstOrDefaultAsync(i => i.Idinvestigador == id);

            if (investigadorModel == null) return null;

            return _mapperToEntity.Map(investigadorModel);
        }

        public async Task EditAsync(Investigador investigador)
        {
            var investigadorModel = await _dbContext.Investigadores
                .Include(i => i.Iddepartamentos)
                .FirstOrDefaultAsync(i => i.Idinvestigador == investigador.IdInvestigador);

            if (investigadorModel == null) return;

            investigadorModel.Nombre = investigador.Nombre;
            investigadorModel.Iddepartamentos.Clear();

            foreach (var departamento in investigador.Iddepartamentos)
            {
                var existingDepartamento = await _dbContext.Departamentos.FindAsync(departamento.IDDepartamento);
                if (existingDepartamento != null)
                {
                    investigadorModel.Iddepartamentos.Add(existingDepartamento);
                }
            }

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

        public async Task SoftDeleteAsync(int id)
        {
            var investigadorModel = await _dbContext.Investigadores.FindAsync(id);
            if (investigadorModel == null)
            {
                throw new InvalidOperationException($"Investigador con ID {id} no encontrado para eliminación suave.");
            }

            investigadorModel.Eliminado = true; // Marcar como eliminado
            _dbContext.Entry(investigadorModel).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task SoftRestoreAsync(int id)
        {
            var investigadorModel = await _dbContext.Investigadores.FindAsync(id);
            if (investigadorModel == null)
            {
                throw new InvalidOperationException($"Investigador con ID {id} no encontrado para eliminación suave.");
            }

            investigadorModel.Eliminado = false; // Marcar como activo
            _dbContext.Entry(investigadorModel).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Investigador>> GetAllEliminadosAsync()
        {
            var investigadoresModels = await _dbContext.Investigadores
                                            .Include(i => i.Iddepartamentos)
                                            .Where(i => i.Eliminado)
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
