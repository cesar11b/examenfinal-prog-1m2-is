using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Estudiante
    {
        
        
         public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Carnet { get; set; }

        public Municipio Municipio { get; set; }

        public Departamento Departamento { get; set; }
    }
}
