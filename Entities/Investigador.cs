namespace Entities
{
    public class Investigador
    {
        public int IdInvestigador {  get; set; }
        public string Nombre { get; set; }
        public bool Eliminado { get; set; }

        public ICollection<Asistencia> Asistencia { get; set; } = new List<Asistencia>();

        public ICollection<Departamento> Iddepartamentos { get; set; } = new List<Departamento>();
    }
}
