using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    public class Clang: Languages
    {
        public override string Move()
            => $"{LanguageName} uses a compact notation and provides the programmer with the ability to operate with the addresses of data as well as with their values.";
    }
}
