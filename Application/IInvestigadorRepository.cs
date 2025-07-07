using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines
{
    public interface IInvestigadorRepository : IRepository<Investigador>
    {
        Task<IEnumerable<Investigador>> GetAllByDepartamentoNombreAsync(string nombreDepartamento);

    }
}
