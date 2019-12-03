using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace MatrixMemTest
{
    [MemoryDiagnoser]
    public class Program
    {
        static int rows = 15000;
        static int columns = 15000;
        

        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Program>();
        }

        [Benchmark]
        public  void RowAccess()
        {
            var matrix = new int[rows, columns];
            for (int ix = 0; ix < rows; ix++)
            {
                for (int iy = 0; iy < columns; iy++)
                {
                    matrix[ix, iy] = 0;
                }
            }
        }

        [Benchmark]
        public  void ColumnAccess()
        {
            var matrix = new int[rows, columns];
            for (int ix = 0; ix < rows; ix++)
            {
                for (int iy = 0; iy < columns; iy++)
                {
                    matrix[iy, ix] = 0;
                }
            }
        }
    }


}
