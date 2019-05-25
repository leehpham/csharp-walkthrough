using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                // Create a StreamReader to read from a file.
                streamReader = new StreamReader(@"D:\hoang\csharp-walkthrough\40-exception-handling\ExceptionHandling\data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Please check if the file {ex.FileName} exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }

            Console.WriteLine("Get here anw");
        }
    }
}
