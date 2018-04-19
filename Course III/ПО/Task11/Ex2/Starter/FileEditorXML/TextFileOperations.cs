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
            StringBuilder fileContents = new StringBuilder();
            char charCode;
            StreamReader fileReader = new StreamReader(fileName);
            StreamReader fileReader1 = new StreamReader(fileName);

            while (fileReader1.Read() != -1)
            {
                charCode = (char)fileReader.Read();
                switch (charCode)
                {
                    case ((char)34):
                        fileContents.Append("& quot;");
                        break;
                    case ((char)38):
                        fileContents.Append("& amp;");
                        break;
                    case ((char)39):
                        fileContents.Append("& apos;");
                        break;
                    case ((char)60):
                        fileContents.Append("& lt; ");
                        break;
                    case ((char)62):
                        fileContents.Append("& gt; ");
                        break;
                    default:
                        fileContents.Append(charCode);
                        break;
                }
            }
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
