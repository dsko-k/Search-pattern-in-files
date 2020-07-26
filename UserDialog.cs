using System;
using System.Collections.Generic;
using System.Text;

namespace Search_files_with_regex_JavaScript
{
    class UserDialog
    {
        // Get pattern to search from user 
        public string GetSearchingPatern()
        {
            return DialogToUser("Enter the pattern (including Regex) to search in files", ConsoleColor.Green);
        }

        // Get path to folder with searched files and subfolders
        public string GetSearchingPath()
        {         
            return DialogToUser("Enter the path to folder with searched files and subfolders (tip: copy path from folder and use context menu at console):", ConsoleColor.Yellow);         
        }

        // Get extension of the file to search
        public string GetSearchingFileExtension()
        {
            return DialogToUser("Enter the extension of the file in format:\n.<file extension 1>, .<file extension 2>, .<file extension 3>\nTo specify any extension, type here nothing and press Enter", ConsoleColor.Red);
        }


        private string DialogToUser(string proposalToUser, ConsoleColor foregroundColor)
        {
            string answerFromUser = "";

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(proposalToUser);



            Console.ForegroundColor = foregroundColor;

            answerFromUser = Console.ReadLine().ToString();


            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;

            return answerFromUser;
        }



        //public void ConsoleDialog()
        //{
        //    GetSearchingPatern();
        //    GetSearchingPath();
        //}

    }
}
