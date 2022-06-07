using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    public class SQLlang: Languages
    {
        public override string Move()
            => $" {LanguageName}  is a language for specifying the organization of databases (collections of records).";
    }
}
