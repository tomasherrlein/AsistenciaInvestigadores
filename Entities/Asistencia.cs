using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Asistencia
    {
        public int IDAsistencia { get; set; }
        public string IDInvestigador { get; set; }
        public DateTime Fecha { get; set; }
        public TimeOnly HoraEntrada { get; set; }
        public TimeOnly HoraSalida { get; set; }


        public TimeSpan GetTiempoEmpleado()
        {
            if (HoraSalida <= HoraEntrada)
                throw new InvalidOperationException("La hora de salida debe ser mayor que la hora de entrada.");

            return HoraSalida - HoraEntrada;
        }
    }
}
