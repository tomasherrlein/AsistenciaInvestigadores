using ApplicationBussines.DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.UseCasesInvestigador
{
    public class SoftDeleteInvestigador
    {
        private readonly IInvestigadorRepository _repository;

        public SoftDeleteInvestigador(IInvestigadorRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(int id)
        {
            var investigador = await _repository.GetByIdAsync(id);
            if (investigador == null)
            {
                throw new Exception("No se encontró el investigador");
            }

            await _repository.SoftDeleteAsync(id);
        }
    }
}
