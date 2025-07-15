using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.UseCasesAsistencia
{
    public class EditAsistencia
    {
        private IAsistenciaRepository _repository;

        public EditAsistencia (IAsistenciaRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Asistencia asistencia)
        {
            if (asistencia is null) 
            {
                throw new ArgumentException("La asistencia a editar no es valida.");
            }

            await _repository.EditAsync(asistencia);
        }
    }
}
