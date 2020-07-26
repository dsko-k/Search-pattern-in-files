using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;


namespace Search_files_with_regex_JavaScript
{
    class RegexHandler
    {

        // Add brackets to pattern to create Regex with Brackets groups
        public string AddBracketsRegex(string pattern)
        {
            if (! IsContainsBrackets(pattern))
            {
                pattern = "(" + pattern + ")";
            }

            return pattern;
        }


        // Check user's pattern for Brackets at the begin and the end
        private bool IsContainsBrackets(string pattern)
        {
            if (pattern[0] == '(' && pattern[pattern.Length - 1] == ')')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        




       

    }
}
