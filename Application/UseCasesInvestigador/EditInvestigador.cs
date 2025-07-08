using ApplicationBussines.DTOs;
using ApplicationBussines.Mappers;
using Entities;

namespace ApplicationBussines.UseCasesInvestigador
{
    public class EditInvestigador
    {
        private readonly IInvestigadorRepository _investigadorRepository;
        private readonly IRepository<Departamento> _departamentoRepository;

        public EditInvestigador(IInvestigadorRepository investigadorRepository, IRepository<Departamento> departamentoRepository)
        {
            _investigadorRepository = investigadorRepository;
            _departamentoRepository = departamentoRepository;
        }

        public async Task ExecuteAsync(int investigadorId, InvestigadorDTO investigadorDTO)
        {
            if (string.IsNullOrEmpty(investigadorDTO.Nombre))
            {
                throw new Exception("El nombre del investigador es obligatorio");
            }

            if (investigadorDTO.IdDepartamentos == null || !investigadorDTO.IdDepartamentos.Any())
            {
                throw new ArgumentException("Debe seleccionar al menos un departamento para el investigador.");
            }

            var investigador = await _investigadorRepository.GetByIdAsync(investigadorId);
            if (investigador == null)
            {
                throw new Exception("No se encontró el investigador");
            }

            investigador.Nombre = investigadorDTO.Nombre;
            investigador.Iddepartamentos.Clear();

            foreach (var id in investigadorDTO.IdDepartamentos)
            {
                var departamento = await _departamentoRepository.GetByIdAsync(id);
                if (departamento == null)
                {
                    throw new InvalidOperationException($"El departamento con ID {id} no se encontró.");
                }
                investigador.Iddepartamentos.Add(departamento);
            }

            await _investigadorRepository.EditAsync(investigador);
        }
    }
}
