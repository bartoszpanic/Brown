using System;

namespace RuchyBrowna
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double[] arrayX;
        public double[] arrayY;

        public void CalculateMoves(int n)
        {
            var random = new Random();
            double fi, s;
            arrayX = new double[n];
            arrayY = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                fi = Math.PI * random.Next() / Int32.MaxValue * 2;
                Y = Y + Math.Sin(fi);
                arrayY[i] = Y;
                X = X + Math.Cos(fi);
                arrayX[i] = X;
            }
            s = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            Console.WriteLine("Czasteczka przemiescila sie na odleglosc: {0}", s);
        }

    }
}
