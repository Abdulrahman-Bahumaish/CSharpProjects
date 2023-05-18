using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a class named Matrix that applies the following methods on a 2D-Array:
//-ReadMatrix: reads values from the user and assigns them to the 2D-Array.
//-Transpose: transpose the matrix.
//- Print: prints the 2D-Array as a matrix
namespace ExercisesOOPMatrix
{
    internal class Matrix
    {

        private int[,] Matrixs;
        private int Columns;
        private int Rows;

        public Matrix(int Columns, int Rows)
        {
            this.Columns = Columns;
            this.Rows = Rows;
            this.Matrixs = new int[Columns, Rows];
        }
        public void ReadMatrix()
        {
            for (int C = 0; C < Columns; C++)
            {
                for (int R = 0; R < Rows; R++)
                {
                    Console.WriteLine("Matrixs[{0},{1}]:", C, R);

                    //int value =int.Parse(Console.ReadLine());
                    //this.Matrixs[C, R] = value;
                }
            }
        }

        public void TransposeMatrix()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------");
            Console.WriteLine("TransposeMatrix :");
            for (int C = 0; C < Rows; C++)
            {
                for (int R = 0; R < Columns; R++)
                {
                    Console.WriteLine("Matrixs[{1},{0}]:", C, R);
                }
            }
        }
       
    }
}
