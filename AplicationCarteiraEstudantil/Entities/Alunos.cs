using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;
using System.Globalization;

namespace Entities
{
    class Alunos
    {
        public string Nome { get; set; }
        public SerieTurma SerieTurmas { get; set; }
        public Sexo Sexo { get; set; }

        public Alunos(string nome, SerieTurma serieTurmas, Sexo sexo)
        {
            Nome = nome;
            SerieTurmas = serieTurmas;
            Sexo = sexo;
        }
        public override string ToString()
        {
            return SerieTurmas+" "+Nome+" "+Sexo;
        }
    }
}
