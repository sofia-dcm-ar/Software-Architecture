/*
Created by Metodologías de Programación I
Activity 7. 
Chain of responsability and Singleton patterns 

 IMPORTANT:
- This file can be modified by the student for the exercise
- Before running this code, the student must update 'file_path' with the actual path on their computer where the file is located.
- The chair provides the file
 */

using System;
using System.IO;
using MetodologíasDeProgramaciónI;

namespace Week7.ChainOfResponsability_Pattern
{
    public class FileDataReader : BaseHandler
    {
        /* * PORTABILITY UPDATE:
             The file path has been converted from an absolute path to a relative path.
             Using 'AppDomain.CurrentDomain.BaseDirectory' ensures the application 
             looks for "datos.txt" inside its own execution folder (bin/Debug).
         * IMPORTANT: The "datos.txt" file property in Visual Studio must be set to 
            "Copy to Output Directory: Copy always" to ensure it's available at runtime.
         */
        private static readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "datos.txt");
        // --------------------------------------------------------------------------------------------------------

        private StreamReader _fileReader;

        public FileDataReader(BaseHandler handler) : base(handler)
        {
            _fileReader = new StreamReader(_filePath);
        }

        public override double NumberFromFile(double max = 10)
        {
            string line = _fileReader.ReadLine();
            return Double.Parse(line.Substring(0, line.IndexOf('\t'))) * max;
        }

        public override string StringFromFile(int amout = 6)
        { 
            string line = _fileReader.ReadLine();
            line = line.Substring(line.IndexOf('\t')+1);
            amout = Math.Min(amout, line.Length);
            return line.Substring(0, amout);
        }
    }
}