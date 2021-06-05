using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\Exercise";
            string filePath = appPath + @"\calculations.txt";

            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.WriteLine(ActionTaker());
            }
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string readResult = streamReader.ReadToEnd();
                Console.WriteLine(readResult);
            }

            Console.WriteLine("Press ENTER to exit");

            Console.ReadKey();
            Console.Clear();
        }
        public static string Calculate(int num1, int num2)
        {
            int sum = num1 + num2;
            string result = $"{num1} + {num2} = {sum}\n" +
                $"";
            return result;
        }
        public static string ActionTaker()
        {
            string result = "";
            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine("Enter the first number:\n");
                bool number1 = int.TryParse(Console.ReadLine(), out int num1);
                Console.WriteLine("Enter the second number:\n");
                bool number2 = int.TryParse(Console.ReadLine(), out int num2);

                if (number1 && number2)
                {
                    result += Calculate(num1, num2);
                }

                i++;
            }
            return result;
        }
    }
}