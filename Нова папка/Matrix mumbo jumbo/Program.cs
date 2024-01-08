using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace Matrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] data = {
                { 3, 1, 6 },
                { 3, 6, 4 },
                { 4, 5, 2 }
            };

            double[,] data2 = {
                { 3, 2, 3 },
                { 4, 4, 6 },
                { 2, 7, 1 }
            };

            string inputLine = Console.ReadLine();
            string[] inputValues = inputLine.Split(' ');
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    data[i, j] = double.Parse(inputValues[index]);
                    index++;
                }
            }

            string inputLine2 = Console.ReadLine();
            string[] inputValues2 = inputLine2.Split(' ');
            int index2 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    data2[i, j] = double.Parse(inputValues2[index2]);
                    index2++;
                }
            }

            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(data);
            Matrix<double> matrix2 = Matrix<double>.Build.DenseOfArray(data);

            Matrix<double> MultiplyResult = matrix * 2;
            Console.WriteLine(MultiplyResult);

            Matrix<double> AddResult = matrix + matrix2;
            Console.WriteLine(AddResult);

            Console.WriteLine("Determinant");
            double Determinant = matrix.Determinant();
            Console.WriteLine(Determinant);

            var Vector = new DenseVector(new[] { 12.0,8.0,5.0 });
            var Solve = matrix.Solve(Vector);
            Console.WriteLine(Solve);
        }
    }
}
