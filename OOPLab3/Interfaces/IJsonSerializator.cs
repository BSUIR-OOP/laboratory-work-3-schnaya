using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Classes;

namespace Lab3.Interfaces
{
    public interface IJsonSerializator
    {
        LanguageList Deserialize(string json);

        string Serialize(TeachersList teachers);
    }
}
