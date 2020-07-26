using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;

namespace Search_files_with_regex_JavaScript
{
    class SearchHandler
    {
        PathHandler pathHandler;
        RegexHandler regexHandler;

        public SearchHandler()
        {
            pathHandler = new PathHandler();
            regexHandler = new RegexHandler();
        }


        public string[] SearchMatches(string path, string pattern, string searchedFileExtensions)
        {
            List<string> list = new List<string>();

            if (pathHandler.IsTargetFile(path, searchedFileExtensions) && new FileInfo(path).Exists)
            {
                string[] lines = File.ReadAllLines(path, Encoding.Default);

                string updatedPattern = regexHandler.AddBracketsRegex(pattern);

                Regex regex = new Regex(updatedPattern);




            }

            return list.ToArray();
        }


       

            

    }
}
