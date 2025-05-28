using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines
{
    internal class AddAsistencia
    {
        private readonly IRepository<Asistencia> _repository;

        public AddAsistencia(IRepository<Asistencia> repository) 
        { 
            _repository = repository; 
        }

        public async Task ExecuteAsync (Asistencia asistencia)
        {
            await _repository.AddAsync(asistencia);
        }
    }
}
