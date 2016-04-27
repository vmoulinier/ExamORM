using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamORM
{
    public partial class eleve
    {
        public override string ToString()
        {
            return this._nom + " - " + this._prenom;
        }
    }
}
