using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBussines.DTOs;
using Entities;

namespace ApplicationBussines
{
    public class AddInvestigador
    {
        private readonly IInvestigadorRepository _investigadorRepository;
        private readonly IRepository<Departamento> _departamentoRepository;

        public AddInvestigador(IInvestigadorRepository investigadorRepository,
            IRepository<Departamento> departamentoRepository)
        {
            _investigadorRepository = investigadorRepository;
            _departamentoRepository = departamentoRepository;
        }

        public async Task ExecuteAsync(InvestigadorDTO investigadorDTO)
        {
            if (string.IsNullOrEmpty(investigadorDTO.Nombre))
            {
                throw new Exception("El nombre del investigador es obligatorio");
            }

            if (investigadorDTO.IdDepartamentos == null || investigadorDTO.IdDepartamentos.Count() == 0)
            {
                throw new ArgumentException("Debe seleccionar al menos un departamento para el investigador.");
            }

            var nuevoInvestigador = new Investigador
            {
                Nombre = investigadorDTO.Nombre,
                Iddepartamentos = new List<Departamento>()
            };

            foreach (var id in investigadorDTO.IdDepartamentos) {
                var departamento = await _departamentoRepository.GetByIdAsync(id);

                if (departamento == null)
                {
                    throw new InvalidOperationException($"El departamento con ID {id} no se encontró.");
                }

                nuevoInvestigador.Iddepartamentos.Add(departamento);
            }

            await _investigadorRepository.AddAsync(nuevoInvestigador);
        }
    }
}
