using ApplicationBussines;
using ApplicationBussines.QueryResults;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.QueryObjects
{
    public class InvestigadorConDepartamentosQuery
    {
        private readonly IInvestigadorRepository _repository;

        public InvestigadorConDepartamentosQuery(IInvestigadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<InvestigadorConDepartamentosResult>> ExecuteAsync()
        {
            var investigadores = await _repository.GetAllAsync();
            var query = new List<InvestigadorConDepartamentosResult>();

            foreach(var i in investigadores)
            {
                query.Add(new InvestigadorConDepartamentosResult()
                {
                    Nombre = i.Nombre,
                    Departamentos = string.Join(",", i.Iddepartamentos.Select(d => d.Nombre)),
                });
            }    
                
            return query;
        }

        public async Task<IEnumerable<InvestigadorConDepartamentosResult>> ExecuteAsyncFiltered(string nombreDepartamento)
        {
            var investigadores = await _repository.GetAllByDepartamentoNombreAsync(nombreDepartamento);
            var query = new List<InvestigadorConDepartamentosResult>();

            foreach (var i in investigadores)
            {
                query.Add(new InvestigadorConDepartamentosResult()
                {
                    Nombre = i.Nombre,
                    Departamentos = string.Join(",", i.Iddepartamentos.Select(d => d.Nombre)),
                });
            }

            return query;
        }
    }
}
