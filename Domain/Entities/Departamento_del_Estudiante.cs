using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departamento_del_Estudiante
    {
         public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Carnet { get; set; }

        public Municipio Municipio { get; set; }

        public Departamento Departamento { get; set; }

        public int AlgebraLineal { get; set; }

        public int Matematicas { get; set; }

        public int ContabilidadDeCosto { get; set; }

        public int InglesII { get; set; }

        public int ProgramacionI { get; set; }

        public int Sociologia { get; set; }
        
    }
}
