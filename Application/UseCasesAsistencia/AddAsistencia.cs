using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.UseCasesAsistencia
{
    public class AddAsistencia
    {
        private readonly IAsistenciaRepository _repository;

        public AddAsistencia(IAsistenciaRepository repository) 
        { 
            _repository = repository; 
        }

        public async Task ExecuteAsync (Asistencia asistencia)
        {
            await _repository.AddAsync(asistencia);
        }
    }
}
