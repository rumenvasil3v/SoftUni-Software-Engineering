using System;

namespace _04.PrintTriangl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleRows = int.Parse(Console.ReadLine());
            TrianglePrintTop(triangleRows);
            TrianglePrintBottom(triangleRows);
        }

        static void TrianglePrintTop(int triangleRowsTop)
        {
            TriangleRowsTop(triangleRowsTop);
        }

        static void TriangleRowsTop(int triangleRowsTop)
        {
            for (int row = 1; row <= triangleRowsTop; row++)
            {
                int triangleColumnsTop = row;
                TriangleColumnsTop(triangleColumnsTop);
            }
        }

        static void TriangleColumnsTop(int triangleColumnsTop)
        {
            for (int col = 1; col <= triangleColumnsTop; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }

        static void TrianglePrintBottom(int triangleRowsBottom)
        {
            TriangleRowsBottom(triangleRowsBottom);
        }

        static void TriangleRowsBottom(int triangleRowsBottom)
        {
            for (int bottomRow = triangleRowsBottom - 1; bottomRow >= 0; bottomRow--)
            {
                int triangleColumnsBottom = bottomRow;
                TriangleColumnsBottom(triangleColumnsBottom);
            }
        }

        static void TriangleColumnsBottom(int triangleColumnsBottom)
        {
            for (int bottomCol = 1; bottomCol <= triangleColumnsBottom; bottomCol++)
            {
                Console.Write(bottomCol + " ");
            }

            Console.WriteLine();
        }
    }
}