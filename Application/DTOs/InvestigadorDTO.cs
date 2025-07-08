using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBussines.DTOs
{
    public class InvestigadorDTO
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public ICollection<int> IdDepartamentos { get; set; }
    }
}
