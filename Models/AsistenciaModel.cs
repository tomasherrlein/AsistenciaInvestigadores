using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AsistenciaModel
    {
        public int Idasistencia { get; set; }

        public int Idinvestigador { get; set; }

        public DateOnly Fecha { get; set; }

        public TimeOnly HoraEntrada { get; set; }

        public TimeOnly? HoraSalida { get; set; }

        public virtual InvestigadorModel IdinvestigadorNavigation { get; set; } = null!;
    }
}
