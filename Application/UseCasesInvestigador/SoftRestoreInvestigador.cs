using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.UseCasesInvestigador
{
    public class SoftRestoreInvestigador
    {
        private IInvestigadorRepository _repository;

        public SoftRestoreInvestigador (IInvestigadorRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync (int id)
        {
            await _repository.SoftRestoreAsync(id);
        }
    }
}
