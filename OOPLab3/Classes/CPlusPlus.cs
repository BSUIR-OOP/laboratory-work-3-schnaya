using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    public class CPlusPlus: Languages
    {
        public override string Move()
            => $"{LanguageName} extended C by adding objects to it while preserving the efficiency of C programs.";
    }
}
