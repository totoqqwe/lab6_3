using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quaternion q1 = new Quaternion(1, 2, 3, 4);
            Quaternion q2 = new Quaternion(5, 6, 7, 8);
            Quaternion sum = q1 + q2;

            Console.WriteLine($"Sum: {sum.W}, {sum.X}, {sum.Y}, {sum.Z}");

            Quaternion difference = q1 - q2;
            Console.WriteLine($"Difference: {difference.W}, {difference.X}, {difference.Y}, {difference.Z}");

            Quaternion product = q1 * q2;
            Console.WriteLine($"Product: {product.W}, {product.X}, {product.Y}, {product.Z}");

            double norm = q1.Norm();
            Console.WriteLine($"Norm of q1: {norm}");

            Quaternion conjugate = q1.Conjugate();
            Console.WriteLine($"Conjugate of q1: {conjugate.W}, {conjugate.X}, {conjugate.Y}, {conjugate.Z}");

            Quaternion inverse = q1.Inverse();
            Console.WriteLine($"Inverse of q1: {inverse.W}, {inverse.X}, {inverse.Y}, {inverse.Z}");

            Console.WriteLine($"Are q1 and q2 equal? {q1 == q2}");
            Console.WriteLine($"Are q1 and q2 not equal? {q1 != q2}");

            double[,] rotationMatrix = q1.ToRotationMatrix();
            Console.WriteLine("Rotation Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{rotationMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
