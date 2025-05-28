using ApplicationBussines;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class AsistenciaRepository : IRepository<Asistencia>
    {
        public Task AddAsync(Asistencia asistencia)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Asistencia>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Asistencia> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(Asistencia asistencia)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
