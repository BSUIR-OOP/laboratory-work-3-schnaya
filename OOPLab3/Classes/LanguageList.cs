using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab3.Classes
{
    public class LanguageList: IEnumerable
    {
        private List<Languages> languages= new List<Languages>();

        public int Count
            => languages.Count;

        public void Add(Languages l)
            =>languages.Add(l);

        public void Remove(Languages l)
            => languages.Remove(l);

        public List<Languages> GetTransports()
            => languages;

        public Languages Get(int index)
            =>languages[index];

        public IEnumerator GetEnumerator()
            => languages.GetEnumerator();
    }
}
