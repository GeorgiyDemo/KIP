using System.IO;

namespace FileEditor
{
    class TextFileOperations
    {
        public static string ReadTextFileContents(string FileName)
        {
            return File.ReadAllText(FileName);
        }

        public static void WriteTextFileContents(string FileName, string Text)
        {
            File.WriteAllText(FileName, Text);
        }
    }
}
