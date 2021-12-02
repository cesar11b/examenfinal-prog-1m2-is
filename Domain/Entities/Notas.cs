using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Notas
    {
         public Nota(Estudiante estudiante)
        {
            Estudiante = estudiante;
        }

        public Estudiante Estudiante { get; set; }

        public Asignatura Asignatura { get; set; }

        public int Sistematicos { get; set; }

        public int ParcialI { get; set; }

        public int ParcialII { get; set; }

        public int NotaFinal { get; set; }

        
        
    }
}
