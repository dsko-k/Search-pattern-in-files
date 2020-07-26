using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;


namespace Search_files_with_regex_JavaScript
{
    class TagHandler
    {

        // Insert tag into string which matches specified Regex
        public string InsertTagInText(string line, Regex regex, string tagName, string tagClass)
        {
            return regex.Replace(line, m => "<" + tagName + " class=\'" + $"{tagClass}" + "\'" + ">" + m.Groups[1].Value + "</" + $"{tagName}" + ">");
        }


        // Insert tag into start and end of text
        public string InsertTagToStartEndText(string line, string tagName, string attributeKey = "", string attributeValue ="")
        {
            string attributesLine = "";

            if (attributeKey != "" & attributeValue != "")
            {
                attributesLine = attributeKey + "=" + "\"" + attributeValue + "\"";
            }            

            return  "<"+ tagName + " " + attributesLine + ">"+ line + "</"+tagName + ">";
        }


    }
}
