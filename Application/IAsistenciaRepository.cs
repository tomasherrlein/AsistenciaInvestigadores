using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines
{
    public interface IAsistenciaRepository : IRepository<Asistencia>
    {
        Task<IEnumerable<Asistencia>> GetAsistenciasDeInvestigadorPorMesAsync(int IdInvestigador, int año, int mes);

    }
}
