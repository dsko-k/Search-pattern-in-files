using System;
using System.Text.RegularExpressions;

/*
    Дана папка с вложенными папками и файлами.
    1. Найти файлы, с указанным расширением
    2. Найти в файлах с указанным расширением строки, соответствующие шаблону Regex
    3. Записать результат в файл, указав найденную строку, номер, имя файла, путь
    Представить п.3 в виде html-файла с таблицей и JavaScript-кодом, который:
    4. Меняет фон строки, на которую наведён курсор
    5. Меняет фон строки, на которую кликнули
    6. Содержит кнопки выделения фона следующей и предыдущей строки таблицы
*/



namespace Search_files_with_regex_JavaScript
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDialog userDialog = new UserDialog();            


            //string pattern = userDialog.GetSearchingPatern();

            //string path = userDialog.GetSearchingPath();

            //string extensions = userDialog.GetSearchingFileExtension();



            PathHandler pathHandler = new PathHandler();

            //string[] splittedPath = pathHandler.SplitPath(path);

            //string lastName = pathHandler.GetLastNamePath(path);

            //bool isTargetFile = pathHandler.IsTargetFile(path, extensions);


            TagHandler tagHandler = new TagHandler();

            string patternAAA = @"(\d+)";

            Regex regex = new Regex(patternAAA);

            string newLine = tagHandler.InsertTagInText("ca100ccc50001ddd3fd20af", regex, "span", "red");


            string lineWithTag = tagHandler.InsertTagToStartEndText("1234567890", "span", "class", "red");

            Console.ReadKey();
        }
    }
}
