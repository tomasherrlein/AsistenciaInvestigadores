using ApplicationBussines;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DepartamentoRepository : IRepository<Departamento>
    {
        readonly AppDbContext _dbContext;

        public DepartamentoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Departamento departamento)
        {
            await _dbContext.AddAsync(departamento); 
        }

        public Task<IEnumerable<Departamento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Departamento> GetByIdAsync(int id)
        {
            var departamento = await _dbContext.Departamentos.FindAsync(id);

            return new Departamento
            {
                IDDepartamento = departamento.Iddepartamento,
                Nombre = departamento.Nombre,
            };
        }

        public Task EditAsync(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
