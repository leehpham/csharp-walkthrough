using System;
using System.IO;

namespace InnerExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int fn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / sn;

                    Console.WriteLine($"Result = {result}");
                }
                catch (Exception ex)
                {
                    string filePath = @"D:\hoang\git-repo\Log1.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, please try later.");
                    }
                    else 
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}
