using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Converter
    {
        public string ReplaceCase(string originalText)
        {
            StringBuilder result = new StringBuilder(originalText.Length);

            foreach(char c in originalText)
            {
                if (char.IsUpper(c))
                    result.Append(char.ToLower(c));
                else if (char.IsLower(c))
                    result.Append(char.ToUpper(c));
                else
                    result.Append(c);
            }
            return result.ToString();
        }
    }
}
