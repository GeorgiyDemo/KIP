using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;

namespace FileEditorXML
{

    /// <summary>
    /// Perform IO operations on text files
    /// </summary>
    class TextFileOperations
    {


        public static string ReadAndFilterTextFileContents(string fileName)
        {
            int charCode;
            StringBuilder fileContents = new StringBuilder();
            StreamReader fileReader = new StreamReader(fileName);
            string line;
            // Read and display lines from the file until the end of 
            // the file is reached.

            while (fileReader.Read() != -1)
            {
                charCode = fileReader.Read();
                MessageBox.Show(charCode.ToString());
                switch (charCode)
                {
                    case 34:
                        fileContents.Append("&quot;");
                        break;
                    case 38:
                        fileContents.Append("&amp;");
                        break;
                    case 39:
                        fileContents.Append("&apos;");
                        break;
                    case 60:
                        fileContents.Append("&lt;");
                        break;
                    case 62:
                        fileContents.Append("&gt;");
                        break;
                    default:
                        fileContents.Append(charCode.ToString());
                        break;
                }
            }
            fileContents.AppendLine();
            return fileContents.ToString();

        }
        /// <summary>
        /// Read contents of a text file
        /// </summary>
        /// <param name="fileName">Full file name including path</param>
        /// <returns>File contents</returns>
        public static string ReadTextFileContents(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        // TODO - Implement a new method in the TextFileOperations class
        // Add a method to read the contents of a file, replacing special XML characters
        // with their entities ( & becomes &amp; etc)

        /// <summary>
        /// Write to a text file
        /// </summary>
        /// <param name="fileName">Full file name including path</param>
        /// <param name="text">Text to write to file</param>
        public static void WriteTextFileContents(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
    }
}
