using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace matrixe
{
    public class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = DenseMatrix.OfArray(new double[,] {
            {3, 1, 4},
            {1, 5, 9},
            {2, 6, 5}
        });
            matrix1 = matrix1 * 3;
            Console.WriteLine("Резултат за умножение: ");
            Console.WriteLine(matrix1);

            var matrix2 = DenseMatrix.OfArray(new double[,] {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        });
            matrix2 = matrix1 + matrix2;
            Console.WriteLine("Резултат на събиране: ");
            Console.WriteLine(matrix2);

            var det = matrix1.Determinant();
            Console.WriteLine("Детерминанта: ");
            Console.WriteLine(det);

            var vector = new DenseVector(new[] { 12.0, 8.0, 5.0 });
            var v = new DenseVector(new[] { 0, 0, 0.0 });
            var solve = matrix1.Solve(vector);
            Console.WriteLine("Решение на матрица: ");
            Console.WriteLine(solve);
        }
    }
}