namespace Models
{
    public class InvestigadorModel
    {
        public int Idinvestigador { get; set; }

        public string Nombre { get; set; } = null!;

        public virtual ICollection<AsistenciaModel> Asistencia { get; set; } = new List<AsistenciaModel>();

        public virtual ICollection<DepartamentoModel> Iddepartamentos { get; set; } = new List<DepartamentoModel>();

    }
}
