using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.UseCasesAsistencia
{
    public class DeleteAsistencia
    {
        private readonly IAsistenciaRepository _repository;

        public DeleteAsistencia (IAsistenciaRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        } 
    }
}
