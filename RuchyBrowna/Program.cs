using System;
using System.IO;

namespace RuchyBrowna
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj ilość prób");
            int n = int.Parse(Console.ReadLine());
            Point point = new Point();
            point.CalculateMoves(n);
            SaveToXls(point.arrayX,point.arrayY);
            Console.ReadKey();

        }
        private static void SaveToXls(double[] x, double[] y)
        {
            string path = Directory.GetCurrentDirectory();
            using (StreamWriter sw = new StreamWriter("RuchyBrowna.xls"))
            {
                if (x.Length == y.Length)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        sw.WriteLine(x[i] + "\t" + y[i]);
                    }
                }
            }
            Console.WriteLine("Plik znajduje się w {0}", path);
        }
    }

}
