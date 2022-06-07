using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    public class Assembler: Languages
    {
        public override string Move()
            => $"{Languagename} is designed to be easily translated into machine language.";
    }
}
