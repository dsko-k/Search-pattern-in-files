using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;


namespace Search_files_with_regex_JavaScript
{
    class PathHandler
    {

        // Extract folders and filename (with it's extension) which composing the userPath path
        public string[] SplitPath(string path)
        {
            List<string> splittedPath = new List<string>();

            string[] firstPartPath = new string[2];

            firstPartPath = path.Split(":\\");

            splittedPath.Add(firstPartPath[0]);

            string[] lastPartPath = (firstPartPath[1]).Split("\\");

            foreach (var part in lastPartPath)
            {
                splittedPath.Add(part);
            }

            return splittedPath.ToArray();
        }

        // Get the name of file or folder contains afler the last slash
        private string GetLastNamePath(string path)
        {
            return SplitPath(path).Last().ToString();
        }

        // Check is path to file with searched extension
        public bool IsTargetFile(string path, string searchedFileExtensions)
        {
            bool istargetFile = false;

            if (IsFile(path))
            {
                // if specified any extension (searchedFileExtensions = "") and path - to file
                if (string.IsNullOrEmpty(searchedFileExtensions) && IsFile(path))
                {
                    return true;
                }

                string[] extensions = searchedFileExtensions.Split(", ");

                foreach (var ext in extensions)
                {
                    string lastNamePath = GetLastNamePath(path);

                    Regex regex = new Regex(ext, RegexOptions.RightToLeft);
                    
                    if (regex.IsMatch(lastNamePath))
                    {
                        istargetFile = true;
                        break;
                    }
                }               

            }

            return istargetFile;
        }

        // Is path - file or directory
        public bool IsFile(string path)
        {
            FileAttributes attr = File.GetAttributes(path);                        

            if (attr.HasFlag(FileAttributes.Directory))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }


       


    }
}
