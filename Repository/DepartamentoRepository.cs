using ApplicationBussines;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class DepartamentoRepository : IRepository<Departamento>
    {
        public Task AddAsync(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Departamento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Departamento> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
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
