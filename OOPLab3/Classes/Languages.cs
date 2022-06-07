using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    public abstract class Languages
    {
        public string Languagename { get; set; }

        public int YearOfCreation { get; set; }

        public string Type { get; set; }

        public Languages() { }

        public string ShowInfo()
            => $"{Languagename} is {Type}. It was created in {YearOfCreation}";

        public abstract string Move();
    }
}
