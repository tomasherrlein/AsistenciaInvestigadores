using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ApplicationBussines
{
    public class AddInvestigador
    {
        private readonly IRepository<Investigador> _repository;

        public AddInvestigador(IRepository<Investigador> repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Investigador investigador)
        {
            if (string.IsNullOrEmpty(investigador.Nombre))
            {
                throw new Exception("El nombre del investigador es obligatorio");
            }

            await _repository.AddAsync(investigador);
        }
    }
}
