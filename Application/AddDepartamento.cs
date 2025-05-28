using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ApplicationBussines
{
    public class AddDepartamento
    {
        private readonly IRepository<Departamento> _repository;

        public AddDepartamento(IRepository<Departamento> repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Departamento departamento)
        {
            await _repository.AddAsync(departamento);
        }
    }
}
