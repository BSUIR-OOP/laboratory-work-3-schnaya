using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Lab3.Interfaces;

namespace Lab3.Classes
{
    public class JsonSerializator : IJsonSerializator
    {
        public LanguageList Deserialize(string json)
        {
            LanguageList res = new LanguageList();
            json = Regex.Replace(json, "[]['\n\t,\":]", string.Empty);
            string[] stream = json.Split('{', '}');
            foreach (string s in stream)
            {
                if (!s.Equals(""))
                {
                    Dictionary<string, string> tokens = new Dictionary<string, string>();
                    string[] token = s.Split(' ');
                    for (int i = 0; i < token.Length; i += 2)
                    {
                        tokens.Add(token[i], token[i + 1]);
                    }
                    Type type = Type.GetType(tokens["type"]);
                    Languages c = (Languages)Activator.CreateInstance(type);
                    foreach (var f in type.GetProperties())
                    {
                        if (f.PropertyType.Equals(typeof(string)))
                        {
                            f.SetValue(c, tokens[f.Name]);
                        }
                        else
                        {
                            f.SetValue(c, int.Parse(tokens[f.Name]));
                        }
                    }
                    foreach (var f in type.GetFields())
                    {
                        if (f.FieldType.Equals(typeof(string)))
                        {
                            f.SetValue(c, tokens[f.Name]);
                        }
                        else
                        {
                            f.SetValue(c, int.Parse(tokens[f.Name]));
                        }
                    }
                    res.Add(c);
                }
            }
            return res;
        }

        public string Serialize(LanguagesList langers)
        {
            int cnt = 0;
            string res = "[";
            foreach (Languages lang in languages)
            {
                cnt++;
                res += "\n\t{\n";
                Type type = lang.GetType();
                res += $"\t\t\"type\": \"{type.FullName}\",\n ";
                foreach (var f in type.GetFields())
                {
                    if (f.FieldType.Equals(typeof(string)))
                        res += $"\t\t\"{f.Languagename}\": \"{f.GetValue(lang)}\", \n";
                    else
                        res += $"\t\t\"{f.Languagename}\": {f.GetValue(lang)}, \n";
                }
                foreach (var f in type.GetProperties())
                {
                    if (f.PropertyType.Equals(typeof(string)))
                        res += $"\t\t\"{f.Languagename}\": \"{f.GetValue(lang)}\", \n";
                    else
                        res += $"\t\t\"{f.Languagename}\": {f.GetValue(lang)}, \n";
                }
                res = res.Remove(res.LastIndexOf(',')) + "\n";
                res += "\t},";
            }
            res = res.Remove(res.LastIndexOf(',')) + "\n";
            res += "]";
            return res;
        }
    }
}
