using System.Collections.Generic;
using static System.Console;

namespace Compiler.IO
{
    /// <summary>
    /// An object for reporting errors in the compilation process
    /// </summary>
    public class ErrorReporter
    {
        List<string> Errors = new List<string>();
        /// <summary>
        /// The number of errors encountered so far
        /// </summary>
        public int ErrorCount { get; private set; } = 0;

        /// <summary>
        /// Whether or not any errors have been encounter
        /// </summary>
        public bool HasErrors { get { return ErrorCount > 0; } }

        /// <summary>
        /// Reports an error
        /// </summary>
        /// <param name="message">The message to display</param>
        public void ReportError(string message)
        {
            ErrorCount += 1;
            string errorMessage = $"ERROR: {message}";
            WriteLine(errorMessage);
            Errors.Add(errorMessage);
        }

        /// <summary>
        /// Print all reported errors
        /// </summary>
        public void printAllErrors()
        {
            if (HasErrors)
            {
                Errors.ForEach(message => WriteLine(message)); // print all errors;
            }
            else
            {
                WriteLine("No errors have been found!");
            }
        }
    }
}
