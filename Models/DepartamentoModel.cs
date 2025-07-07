using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DepartamentoModel
    {
        public int Iddepartamento { get; set; }
        public string Nombre { get; set; } = null!;
        public virtual ICollection<InvestigadorModel> Idinvestigadores { get; set; } = new List<InvestigadorModel>();
    }
}
