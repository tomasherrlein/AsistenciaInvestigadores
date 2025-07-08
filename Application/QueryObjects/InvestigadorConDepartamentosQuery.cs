
using ApplicationBussines.QueryResults;

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
                    Id = i.IdInvestigador,
                    Nombre = i.Nombre,
                    Departamentos = string.Join(", ", i.Iddepartamentos.Select(d => d.Nombre)),
                });
            }    
                
            return query;
        }

        public async Task<InvestigadorConDepartamentosResult> ExecuteAsyncById(int id)
        {
            var investigador = await _repository.GetByIdAsync(id);
            return new InvestigadorConDepartamentosResult
            {
                Id = investigador.IdInvestigador,
                Nombre = investigador.Nombre,
                Departamentos = string.Join(", ", investigador.Iddepartamentos.Select(d => d.Nombre))
            };
        }

        public async Task<IEnumerable<InvestigadorConDepartamentosResult>> ExecuteAsyncFiltered(string nombreDepartamento)
        {
            var investigadores = await _repository.GetAllByDepartamentoNombreAsync(nombreDepartamento);
            var query = new List<InvestigadorConDepartamentosResult>();

            foreach (var i in investigadores)
            {
                query.Add(new InvestigadorConDepartamentosResult()
                {
                    Id = i.IdInvestigador,
                    Nombre = i.Nombre,
                    Departamentos = string.Join(", ", i.Iddepartamentos.Select(d => d.Nombre)),
                });
            }

            return query;
        }
    }
}
