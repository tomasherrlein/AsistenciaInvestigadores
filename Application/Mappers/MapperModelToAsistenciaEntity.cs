using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.Mappers
{
    public class MapperModelToAsistenciaEntity : IMapper<AsistenciaModel, Asistencia>
    {
        public Asistencia Map(AsistenciaModel asistenciaModel)
        {
            return new Asistencia
            {
                IDInvestigador = asistenciaModel.Idinvestigador,
                Fecha = asistenciaModel.Fecha,
                HoraEntrada = asistenciaModel.HoraEntrada,
                HoraSalida = asistenciaModel.HoraSalida
            };
        }
    }
}
