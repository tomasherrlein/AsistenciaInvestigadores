using ApplicationBussines.DTOs;
using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.Mappers
{
    public class MapperModelToInvestigadorEntity : IMapper<InvestigadorModel, Investigador>
    {
        public Investigador Map(InvestigadorModel investigadorModel)
        {
            return new Investigador
            {
                IdInvestigador = investigadorModel.Idinvestigador,
                Nombre = investigadorModel.Nombre,
                Iddepartamentos = investigadorModel.Iddepartamentos.Select(d => new Departamento
                {
                    IDDepartamento = d.Iddepartamento,
                    Nombre = d.Nombre,
                }).ToList(), 
            };
        }
    }
}
