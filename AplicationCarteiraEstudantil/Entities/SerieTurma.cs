using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class SerieTurma
    {
        public string Serie { get; set; }
        public string Turma { get; set; }
        public SerieTurma(string serie, string turma)
        {
            Serie = serie;
            Turma = turma;
        }
        public override string ToString()
        {
            return Serie + " " + Turma;
        }
    }
}
