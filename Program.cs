using System;


namespace _1._1._002_алгебраїчна_сума
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Програма для вирішення алгебраїчного рівняння");
            Console.Write("Введіть кількість значень X:");
            int.TryParse(Console.ReadLine(), out int numberX);
            double[] arrey = new double [numberX];
            int number;
            for(number = 0; number < numberX; number++)
            {
                Console.WriteLine("Введіть значення А, В, С та D");
                Console.Write("A=");
                float.TryParse(Console.ReadLine(), out float A);
                Console.Write("B=");
                float.TryParse(Console.ReadLine(), out float B);
                Console.Write("C=");
                float.TryParse(Console.ReadLine(), out float C);
                Console.Write("D=");
                float.TryParse(Console.ReadLine(), out float D);
                arrey[number] = Math.Pow(A, 3) - B + Math.Pow(C, 2) / D;

            }
            double  y=0;
            for (number = 0; number < numberX; number++)
            {
                y += arrey[number];
            }
            Console.WriteLine("y=" + y);
            Console.ReadLine();
        }
    }
}
